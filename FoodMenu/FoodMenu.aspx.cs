using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodMenu
{
    public partial class FoodMenu : System.Web.UI.Page
    {
        FoodDBLogic db = new FoodDBLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Text = "";
            lblStatus.Text = "";
            lbCategory.Items.Clear();
            ArrayList l = db.getItems(ddlCategory.SelectedValue);
            if(l != null)
            {
                foreach(var item in l)
                {
                    lbCategory.Items.Add(item.ToString());
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string str = lbCategory.SelectedValue;
                int index = str.IndexOf('$');
                string itemName = str.Substring(0, index - 3);
                string itemPriceS = str.Substring(index + 1);
                int quantity = Convert.ToInt32(txtquantity.Text);
                double totalPrice = Convert.ToDouble(itemPriceS) * Convert.ToDouble(txtquantity.Text);
                bool status = db.addItems(itemName, quantity, totalPrice);
                if (status)
                {
                    lblStatus.Text = "Sucessfully added to the cart!";
                }
            }
        }
    }
}