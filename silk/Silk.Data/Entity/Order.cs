﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Silk.Data.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int ClientId { get; set; }
        public float TotalPirce { get; set; }
        public string Status { get; set; }
        public string PaymentOption { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string AWB { get; set; }
    }
}