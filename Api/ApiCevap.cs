﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip12AApp.Api
{
    public class ApiCevap
    {
        public bool BasariliMi { get; set; }
        public string HataMesaji { get; set; }
        public object Data { get; set; }
    }
}
