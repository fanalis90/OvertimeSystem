﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tbl_tr_account_roles")]
    public class AccountRole
    {
        [Key,Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }
        [Column("account_id", TypeName = "char(36)")]
        public Guid AccountId { get; set; }
        [Column("role_id", TypeName = "char(36)")]
        public Guid RoleId { get; set; }

        //cardinality
        public Account? Account { get; set; }
        public Role? Role { get; set; }
    }
}
