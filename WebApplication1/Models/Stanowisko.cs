﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    
    public class Stanowisko
    {
        public int StanowiskoId { get; set; }
        public string Name { get; set; }
    }
}