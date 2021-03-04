using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Hotel.Models
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Cusine_Name { get; set; }
        [DisplayName("CUSINE_Type")]
        public cusine_type Cusine_Type { get; set; }
        public int Cost { get; set; }
    }
    public enum cusine_type
    {
        INdian = 1,
        AfricanNomad = 2,
        Mexicon = 3,
        Chinese = 4
    }
}