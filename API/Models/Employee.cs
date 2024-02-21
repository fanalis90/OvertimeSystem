﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tbl_m_employees")]
    public class Employee
    {
        [Key, Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }
        [Column("nik", TypeName = "varchar(6)")]
        public string NIK { get; set; } = string.Empty;
        [Column("first_name", TypeName = "varchar(50)")]
        public string FristName { get; set; } = string.Empty;
        [Column("last_name", TypeName = "varchar(50)")]
        public string? LastName { get; set; }
        [Column("salary")]
        public int Salary { get; set; }
        [Column("joined_date")]
        public DateTime JoinedDate { get; set; }
        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; } = string.Empty;
        [Column("position", TypeName = "varchar(50)")]
        public string Position { get; set; } = string.Empty;
        [Column("department", TypeName = "varchar(50)")]
        public string Department { get; set; } = string.Empty;
        [Column("manager_id", TypeName = "char(36)")]
        public Guid? ManagerId { get; set; }

        //cardinality
        public Account? Account { get; set; }
        public Employee? Manager {  get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
