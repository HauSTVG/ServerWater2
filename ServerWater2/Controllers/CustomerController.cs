﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static ServerWater2.APIs.MyCustomer;

namespace ServerWater2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        [Route("createCustomer")]
        public async Task<IActionResult> createCustomerAsync([FromHeader] string token, ItemCustomer customer)
        {

            long id = Program.api_user.checkAdmin(token);
            if (id >= 0)
            {
                bool flag = await Program.api_customer.createCustomerAsync(customer.maDB, customer.sdt, customer.tenkh, customer.diachi,customer.note, customer.x, customer.y);
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
        [Route("editCustomer")]
        public async Task<IActionResult> editCustomerAsync([FromHeader] string token, ItemCustomer customer)
        {

            long id = Program.api_user.checkAdmin(token);
            if(id >= 0)
            {
                bool flag = await Program.api_customer.editCustomerAsync(customer.maDB, customer.sdt, customer.tenkh, customer.diachi,customer.note,customer.x, customer.y);
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
        [Route("{maDB}/deleteCustomer")]
        public async Task<IActionResult> deleteCustomerAsync([FromHeader] string token, string maDB)
        {
            long id = Program.api_user.checkAdmin(token);
            if (id >= 0)
            {
                bool flag = await Program.api_customer.deleteCustomerAsync(maDB);
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
        [Route("getListCustomer")]
        public IActionResult GetListCustomer([FromHeader] string token)
        {
            long id = Program.api_user.checkAdmin(token);
            if (id >= 0)
            {
                return Ok(Program.api_customer.listCustomer());
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
