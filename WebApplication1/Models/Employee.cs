using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    
        [Table("Employee")]
        public class Employee
        {
            public int Id { get; set; }
            public string EmpName { get; set; }

            [Column(TypeName = "decimal(18,4)")]
            public decimal salary { get; set; }

            public int DeptNo { get; set; }
        }
}
