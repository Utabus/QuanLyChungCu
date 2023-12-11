using System;
using System.Collections.Generic;

namespace WebQuanLyChungCu.Models
{
    public partial class Relationship
    {
        public Relationship()
        {
            Accounts = new HashSet<Account>();
        }

        public int RelationshipId { get; set; }
        public string RelationshipName { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
