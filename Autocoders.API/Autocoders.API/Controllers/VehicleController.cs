﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting.Web.Http;

namespace Autocoders.API.Controllers
{
    [RoutePrefix("api/vehicle")]
    public class VehicleController : ApiController
    {
         [GET("show")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}