﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookStore.Web.Common.Routing;
using BookStore.Models;
using BookStore.Web.Common;

namespace BookStore.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("Order")]
    [UnitOfWorkActionFilter]
    public class OrderController : ApiController
    {
        [Route("", Name = "AddOrderRoute")]
        [HttpPost]
        public Order AddOrder(HttpRequestMessage requestMessage, Order newOrder)
        {
            return new Order
            {
            };
        }
    }
}
