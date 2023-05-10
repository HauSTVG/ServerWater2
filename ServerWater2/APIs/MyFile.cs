﻿using ServerWater2.Models;
using Microsoft.EntityFrameworkCore;
using RestSharp;

namespace ServerWater2.APIs
{
    public class MyFile
    {
        public MyFile()
        {
        }

        private string createKey(string file)
        {
            string key = file + "|" + DateTime.Now.Ticks.ToString();
            return String.Concat(key.Select(x => ((int)x).ToString("x")));
        }

        public async Task<string> saveFileAsync(string file, byte[] data)
        {
            using (DataContext context = new DataContext())
            {
                string code = createKey(file);
                string link_file = "Data/" + code + ".file";
                try
                {
                    await File.WriteAllBytesAsync(link_file, data);
                }
                catch (Exception ex)
                {
                    code = "";
                }
                if (string.IsNullOrEmpty(code))
                {
                    return code;
                }
                SqlFile m_file = new SqlFile();
                m_file.ID = DateTime.Now.Ticks;
                m_file.key = code;
                m_file.link = link_file;
                m_file.name = file;
                m_file.time = DateTime.Now.ToUniversalTime();
                context.files!.Add(m_file);
                int rows = await context.SaveChangesAsync();
                if (rows > 0)
                {
                    return code;
                }
                else
                {
                    return "";
                }
            }
        }

        public byte[]? readFile(string code)
        {
            using (DataContext context = new DataContext())
            {
                List<SqlFile> files = context.files!.Where(s => s.key.CompareTo(code) == 0).ToList();
                if (files.Count <= 0)
                {
                    return null;
                }
                byte[] data = File.ReadAllBytes(files[0].link);
                return data;
            }
        }

        public async Task<byte[]?> getImageChanged(byte[] data)
        {
            //Console.WriteLine("getImageChanged");
            var client = new RestClient("http://office.stvg.vn:59073/image");
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", data, String.Format("{0}.jpg", DateTime.Now.Ticks));
            request.Timeout = 10000;
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.StatusCode.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return response.RawBytes;
            }
            else
            {
                /*Console.Write(response.StatusCode.ToString());*/
                return null;
            }
        }
    }
}
