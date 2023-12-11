using System;
using System.Collections.Generic;

namespace WebQuanLyChungCu.Models
{
    public partial class ApartmentService
    {
        public int ApartmentId { get; set; }
        public int ServiceId { get; set; }
        public DateTime? StartDay { get; set; }
        public DateTime? EndDay { get; set; }
        public byte? Status { get; set; }

        public virtual Apartment Apartment { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
