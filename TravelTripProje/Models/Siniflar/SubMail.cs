﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class SubMail
    {
        [Key]
        public int ID { get; set; }
        public string SubEMail { get; set; }


    }
}
