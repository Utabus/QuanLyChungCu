using System;
using System.Collections.Generic;

namespace WebQuanLyChungCu.Models
{
    public partial class Address
    {
        public Address()
        {
            InFos = new HashSet<InFo>();
        }

        public int AddressId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? StreetAddress { get; set; }

        public virtual ICollection<InFo> InFos { get; set; }
    }
}
