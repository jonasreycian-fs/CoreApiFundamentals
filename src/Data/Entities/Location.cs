﻿using System.ComponentModel.DataAnnotations;

namespace CoreCodeCamp.Data
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string? VenueName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? CityTown { get; set; }
        public string? StateProvince { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
    }
}