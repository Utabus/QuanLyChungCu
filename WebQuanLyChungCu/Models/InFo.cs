using System;
using System.Collections.Generic;

namespace WebQuanLyChungCu.Models
{
    public partial class InFo
    {
        public InFo()
        {
            Accounts = new HashSet<Account>();
        }

        public int InfoId { get; set; }
        public string? FullName { get; set; }
        public string? BirthDay { get; set; }
        public byte? Sex { get; set; }
        public string? CmndCccd { get; set; }
        public int? AddressId { get; set; }

        public virtual Address? Address { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
