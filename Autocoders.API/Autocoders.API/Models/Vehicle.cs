﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Autocoders.API.Models
{
    public class Vehicle
    {
        [BsonId]
        public string Id { get; set; }

        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string UserId { get; set; }
    }
}