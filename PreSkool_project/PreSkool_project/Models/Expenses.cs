using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ExpensesType"), Required]
        public int ExpensesTypeId { get; set; }
        public ExpensesType ExpensesType { get; set; }
        [MaxLength(100), Required]
        public string Quality { get; set; }
        [MaxLength(100), Required]
        public string Name { get; set; }
        [MaxLength(100), Required]
        public string Amount { get; set; }
        [MaxLength(100), Required]
        public string SourceOfPurchase { get; set; }
        [Required]
        public DateTime ExpensesDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
