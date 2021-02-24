using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("CustomerDetails")]
    public class CarModels
    {
        [Key]
        public string DLNumber { get; set; }
        public string BorrowerName { get; set; }
        [Required]
        public string Car { get; set; }
        [Required]
        public DepositType deposit { get; set; }
        [Required]
        public int Hours { get; set; }
        
    }
    public enum DepositType
    {
        cash=1,
        OnlinePay=2
    }
}