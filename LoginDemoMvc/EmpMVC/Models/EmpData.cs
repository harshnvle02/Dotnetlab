using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpMVC.Models
{
    [Table("EmpData")]
    public class EmpData
    {
        [Key]
        [Column("Id", TypeName ="int")]
        public int EmpId { get; set; }
        [Column("Name", TypeName = "varchar(40)")]
        public string Name { get; set; }
        [Column("Address", TypeName = "varchar(40)")]
        public string Address { get; set; }
    }
}
