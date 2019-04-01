using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            prac8.WebService1 calc = new WebService1();
            lblResult.Text = calc.Sub(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            prac8.WebService1 calc = new WebService1();
            lblResult.Text = calc.Add(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            prac8.WebService1 calc = new WebService1();
            lblResult.Text = calc.Mul(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            prac8.WebService1 calc = new WebService1();
            lblResult.Text = calc.Div(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

       
    }
}