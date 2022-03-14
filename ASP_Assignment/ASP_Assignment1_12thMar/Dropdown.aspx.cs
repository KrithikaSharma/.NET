using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment1_12thMar
{
    public partial class Dropdown : System.Web.UI.Page
    {
        Dictionary<string, string> ItemPrice = new Dictionary<string, string>();
        public static string sitem = "Sel";
        string[] str = { "select", "Headphones", "Laptop", "Speakers", "Mobile" };
        string[] price = { "", "999", "80000", "4000", "10000" };

        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < str.Length; i++)
            {
                ItemPrice.Add(str[i], price[i]);
            }
            if (!IsPostBack)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dropdown.sitem = DropDownList1.SelectedValue;
            Image1.ImageUrl = "~/Store/" + Dropdown.sitem + ".jpg";
            Dropdown.sitem = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Price of "+Dropdown.sitem+" is: "+ItemPrice[Dropdown.sitem.ToString()];
        }

    }
}