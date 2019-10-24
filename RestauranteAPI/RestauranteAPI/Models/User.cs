﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace RestauranteAPI.Models
{
    public class User
    {
        [JsonIgnore]
        public Guid? ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"^\S*$")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
