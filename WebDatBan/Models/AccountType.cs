using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
