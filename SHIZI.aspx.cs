using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SHIZI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string wenzi = "天地人你我他一二三四五上下";
        Random rand = new Random();
        int rand2 = rand.Next(1, wenzi.Length);

        string zi = wenzi.Substring(rand2, 1);
        Label1.Text = zi;
        Label1.Font.Size = FontUnit.Point(100);
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
}