﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteAPI.Models
{
    public class Order
    {
        [JsonIgnore]
        public Guid? ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Date { set; get; }

        [Required]
        public string Client { set; get; }

        [Required]
        public int Status { set; get; }
        [NotMapped]
        public Guid[] Products { get; set; }
        [JsonIgnore]
        [NotMapped]
        public ICollection<OrderedProduct> ProductsOrdered { get; set; } // TODO: must change to ordered products
        public bool HasValidDate()
        {
            return DateTime.TryParse(this.Date, out _);

        }
    }
}
