﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F
{
    public partial class ShowTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ShowTime_Click(object sender, EventArgs e)
        {
            Response.Write("目前的時間： " + DateTime.Now.ToString());
        }
    }
}