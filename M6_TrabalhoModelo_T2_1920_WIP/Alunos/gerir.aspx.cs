﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M6_TrabalhoModelo_T2_1920_WIP.Alunos
{
    public partial class gerir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                if (dr["fotografia"] is DBNull==false)
                {
                    string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["fotografia"]);
                    (e.Row.FindControl("fotografia") as Image).ImageUrl = imageUrl;
                }
            }
        }
    }
}