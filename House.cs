﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_1
{
    public class House
    {
       public enum HouseStyle
        {
            Colonial,
            Ranch,
            Victorian,


        }
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string Country { get; set; }

        public HouseStyle HouseStyles { get; set; }


    }
}
