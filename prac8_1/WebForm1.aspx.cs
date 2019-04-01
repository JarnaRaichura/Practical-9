using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.prac8.WebService1 calc = new ServiceReference1.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

     
    }
}