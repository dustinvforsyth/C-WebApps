using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            MyLabel.Text = "Hello World This is Crazy";
        }
    }

    }