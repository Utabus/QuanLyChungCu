using System;
using System.Collections.Generic;

namespace WebQuanLyChungCu.Models
{
    public partial class ElectricMeter
    {
        public int ElectricMeterId { get; set; }
        public int? ApartmentId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? Code { get; set; }
        public DateTime? DeadingDate { get; set; }
        public double? NumberOne { get; set; }
        public double? NumberEnd { get; set; }
        public decimal? Price { get; set; }
        public byte? Status { get; set; }

        public virtual Apartment? Apartment { get; set; }
    }
}
