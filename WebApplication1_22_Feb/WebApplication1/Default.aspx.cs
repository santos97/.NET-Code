using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BookCar(object sender, EventArgs e)
        {
            CarModels model = new CarModels
            {
                DLNumber = DLNumber.Text,
                BorrowerName = BorrowerName.Text,
                Car = Car.Text,
                Hours = Convert.ToInt32(Hours.Text),
                deposit = DepositType.cash
            };
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.BeginTransaction();
            context.CarModels.Add(model);
            context.SaveChanges();
            context.Database.CurrentTransaction.Commit();
            DLNumber.Text = "";
            BorrowerName.Text = "";
            Car.Text = ""; 
            Hours.Text = ""; 
        }
    }

}