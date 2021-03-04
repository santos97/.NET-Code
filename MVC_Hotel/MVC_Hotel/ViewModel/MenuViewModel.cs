using MVC_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Hotel.ViewModel
{
    public class MenuViewModel
    {
        public int ID { get; set; }
        [Required]
        public string Cusine_Name { get; set; }
        [DisplayName("CUSINE_Type")]
        public cusine_type Cusine_Type { get; set; }
        public int Cost { get; set; }
        public string ModifiedBy { get; set; }
    }
}