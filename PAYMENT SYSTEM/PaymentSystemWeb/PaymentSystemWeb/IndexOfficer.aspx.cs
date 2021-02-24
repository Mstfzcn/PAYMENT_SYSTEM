﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentSystemWeb
{
    public partial class IndexOfficer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            Response.Redirect(e.Item.Value);
        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Session["UserInfo"] = null;
            Response.Redirect("LoginOfficer.aspx");
        }
    }
}