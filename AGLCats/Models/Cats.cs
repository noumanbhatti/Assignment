﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGLCats.Models
{
    public class Cats
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
