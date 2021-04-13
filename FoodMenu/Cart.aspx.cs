using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodMenu
{
    
    public partial class Cart : System.Web.UI.Page
    {
        FoodDBLogic db = new FoodDBLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblClear.Text = "";
            lblTotal.Text = "";
            txtCart.Text = "";
            ArrayList l = db.showCarts();
            if (l != null)
            {
                for(int i = 0;i < l.Count; i++)
                {
                    txtCart.Text += l[i].ToString() + "\n";
                }
            }
            string totalPrice = db.getTotal();
            if(totalPrice != "")
            {
                lblTotal.Text = "$" + totalPrice;
            }
            else
            {
                lblTotal.Text = "";
            }
            
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            bool status = db.clearCarts();
            if (status)
            {
                lblTotal.Text = "";
                txtCart.Text = "";
                lblClear.Text = "Successfully deleted!";
            }
        }
    }
}