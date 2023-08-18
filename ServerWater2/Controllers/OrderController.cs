﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerWater2.APIs;
using static ServerWater2.APIs.MyCustomer;
using static ServerWater2.APIs.MyLogOrder;
using static ServerWater2.APIs.MyOrder;
using static System.Net.Mime.MediaTypeNames;

namespace ServerWater2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public class HttpItemOrder
        {
            public string customer { get; set; } = "";
            public string phone { get; set; } = "";
            public string addressCustomer { get; set; } = "";
            public string group { get; set; } = "";
            public string area { get; set; } = "";
            public string addressWater { get; set; } = "";
            public string addressContract { get; set; } = "";
            public string service { get; set; } = "";
            public string type { get; set; } = "";
            public List<string> certificates { get; set; } = new List<string>();
            public string note { get; set; } = "";

        }
        [HttpPost]
        [Route("createOrder")]
        public async Task<IActionResult> CreateOrderAsync(HttpItemOrder item)
        {


            string order = await Program.api_order.createNewOrder(item.customer, item.phone, item.addressCustomer, item.group, item.area, item.addressWater, item.addressContract, item.service, item.type, item.certificates, item.note);
            if (string.IsNullOrEmpty(order))
            {
                return BadRequest();
            }
            else
            {
                return Ok(order);
            }
        }

        public class ItemHttpRequest
        {
            public string code { get; set; } = "";
            public string name { get; set; } = "";
            public string customer { get; set; } = "";
            public string phone { get; set; } = "";
            public string address { get; set; } = "";
            public string addressContract { get; set; } = "";
            public string type { get; set; } = "";
            public string note { get; set; } = "";
        }

        public class ItemHttpSetAction
        {
            public string code { get; set; } = "";
            public string action { get; set; } = "";
            public string note { get; set; } = "";
            public string latitude { get; set; } = "";
            public string longitude { get; set; } = "";
        }

        [HttpPost]
        [Route("createRequestOrder")]
        public async Task<IActionResult> CreateRequestOrderAsync(ItemHttpRequest item)
        {


            string order = await Program.api_order.createRequestOrder(item.code, item.name, item.phone, item.customer, item.address, item.addressContract, item.type, item.note);
            if (string.IsNullOrEmpty(order))
            {
                return BadRequest();
            }
            else
            {
                return Ok(order);
            }
        }
        [HttpPut]
        [Route("{code}/setAssginOrder")]
        public async Task<IActionResult> SetAssginOrder([FromHeader] string token, string code, string user)
        {
            long id = Program.api_user.checkSystem(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.setAssginOrder(token, code, user);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpPut]
        [Route("{id}/addImageWorkOrder")]
        public async Task<IActionResult> AddImageWorkOrder([FromHeader] string token, string id, IFormFile image)
        {
            long ID = Program.api_user.checkUser(token);
            if (ID >= 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    string tmp = await Program.api_order.addImageWorkingAsync(token, id, ms.ToArray());
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        return Ok(tmp);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }

            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpDelete]
        [Route("{id}/removeImageWorkOrder")]
        public async Task<IActionResult> RemoveImageWorkOrder([FromHeader] string token, string id, string image)
        {
            long ID = Program.api_user.checkUser(token);
            if (ID >= 0)
            {
                bool flag = await Program.api_order.removeImageWorkingAsync(token, id, image);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }



        [HttpPut]
        [Route("{id}/addImageFinishOrder")]
        public async Task<IActionResult> AddImageFinishOrder([FromHeader] string token, string id, IFormFile image)
        {
            long ID = Program.api_user.checkUser(token);
            if (ID >= 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    string tmp = await Program.api_order.addImageFinishAsync(token, id, ms.ToArray());
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        return Ok(tmp);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpDelete]
        [Route("{id}/removeImageFinishOrder")]
        public async Task<IActionResult> RemoveImageFinishOrder([FromHeader] string token, string id, string image)
        {
            long ID = Program.api_user.checkUser(token);
            if (ID >= 0)
            {
                bool flag = await Program.api_order.removeImageFinishAsync(token, id, image);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpPut]
        [Route("{id}/addImageSign")]
        public async Task<IActionResult> addImageCustomer([FromHeader] string token, string id, IFormFile image)
        {
            long ID = Program.api_user.checkUser(token);
            if (ID >= 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    string tmp = await Program.api_order.addImageSignAsync(token, id, ms.ToArray());
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        return Ok(tmp);

                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpDelete]
        [Route("{id}/removeImageSign")]
        public async Task<IActionResult> removeImageCustomer([FromHeader] string token, string id, string image)
        {
            long ID = Program.api_user.checkUser(token);
            if (ID >= 0)
            {
                bool flag = await Program.api_order.removeImageSignAsync(token, id, image);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPut]
        [Route("setAction")]
        public async Task<IActionResult> SetAction([FromHeader] string token, [FromBody] ItemHttpSetAction items)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(items.code) || string.IsNullOrEmpty(items.action))
            {
                return BadRequest();
            }
            string tmp = await Program.api_order.setAction(token, items.code, items.action, items.note, items.latitude, items.longitude);
            if (!string.IsNullOrEmpty(tmp))
            {
                return Ok(tmp);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("{code}/confirmOrder")]
        public async Task<IActionResult> ConfirmOrder([FromHeader] string token, string code)
        {
            long id = Program.api_user.checkSystem(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.confirmOrder(token, code);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }


        [HttpPut]
        [Route("{code}/setCustomer")]
        public async Task<IActionResult> SetCustomer([FromHeader] string token, string maDB, string code)
        {
            long id = Program.api_user.checkSystem(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.setCustomer(token, maDB, code);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }


        [HttpPut]
        [Route("{code}/setConfirmedOrder")]
        public async Task<IActionResult> SetConfirmedOrder([FromHeader] string token, string code)
        {
            long id = Program.api_user.checkSystem(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.setConfirmedOrder(token, code);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }


        public class ItemHttpJob
        {
            public string code { get; set; } = "";
            public string latitude { get; set; } = "";
            public string longitude { get; set; } = "";
            public string note { get; set; } = "";
        }

        [HttpPut]
        [Route("beginWorkOrder")]
        public async Task<IActionResult> BeginWorkOrder([FromHeader] string token, ItemHttpJob job)
        {
            if (string.IsNullOrEmpty(job.code))
            {
                return BadRequest();
            }
            long id = Program.api_user.checkUser(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.beginWorkOrder(token, job.code, job.latitude, job.longitude, job.note);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }


        [HttpPut]
        [Route("{code}/finishOrder")]
        public async Task<IActionResult> FinishOrder([FromHeader] string token, string code)
        {
            long id = Program.api_user.checkUser(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.finishOrder(token, code);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpPut]
        [Route("{code}/confirmSignOrder")]
        public async Task<IActionResult> confirmSignOrder([FromHeader] string token, string code)
        {
            long id = Program.api_user.checkUser(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.confirmSignOrder(token, code);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }
        [HttpPut]
        [Route("finishWorkOrder")]
        public async Task<IActionResult> FinishWorkOrder([FromHeader] string token, ItemHttpJob job)
        {
            if (string.IsNullOrEmpty(job.code))
            {
                return BadRequest();
            }
            long id = Program.api_user.checkUser(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.finishWorkOrder(token, job.code, job.note);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }



        [HttpDelete]
        [Route("{code}/cancelOrder")]
        public async Task<IActionResult> CancelOrder([FromHeader] string token, string code)
        {
            long id = Program.api_user.checkSystem(token);
            if (id >= 0)
            {
                bool flag = await Program.api_order.cancelOrder(token, code);
                if (flag)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpGet]
        [Route("getListService")]
        public IActionResult GetListService()
        {
            return Ok(Program.api_service.getListService());
        }

        [HttpGet]
        [Route("getListOrder")]
        public IActionResult GetListNewOrder([FromHeader] string token, string begin, string end)
        {
            DateTime time_begin = DateTime.MinValue;
            try
            {
                time_begin = DateTime.ParseExact(begin, "dd-MM-yyyy", null);
            }
            catch (Exception e)
            {
                time_begin = DateTime.MinValue;
            }
            DateTime time_end = DateTime.MinValue;
            try
            {
                time_end = DateTime.ParseExact(end, "dd-MM-yyyy", null);
            }
            catch (Exception e)
            {
                time_end = DateTime.MaxValue;
            }
            long id = Program.api_user.checkUser(token);
            if (id >= 0)
            {
                return Ok(Program.api_order.getListOrder(token, time_begin, time_end));
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet]
        [Route("getInfoOrder")]
        public IActionResult GetInfoOrder([FromHeader] string token, string code)
        {
            return Ok(Program.api_order.getInfoOrder(token, code));
        }

        [HttpGet]
        [Route("getFindOrder")]
        public IActionResult GetFindOrder(string code)
        {
            return Ok(Program.api_order.getFindOrder(code));
        }

        [HttpGet]
        [Route("getInfoCustomer")]
        public IActionResult GetInfoCustomer(string code)
        {
            ItemCustomer info = Program.api_order.getInfoCustmer(code);
            return Ok(info);
        }


    }
}
