using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Hotel.Models
{
    public class MenuContext: DbContext
    {
        public MenuContext() : base("Name=MVCConnect")
        {

        }
        public DbSet<Menu> menudetailes { get; set; }

        //public System.Data.Entity.DbSet<MVC_Hotel.ViewModel.MenuViewModel> MenuViewModels { get; set; }
    }
}