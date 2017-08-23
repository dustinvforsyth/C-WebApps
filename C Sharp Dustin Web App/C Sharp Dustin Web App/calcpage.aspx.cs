using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C_Sharp_Dustin_Web_App
{
    public partial class calcpage : System.Web.UI.Page
    {
        
      
        public void addition(object sender, EventArgs e)
        {

            answer.Text = "";
            Error.Text = "";
            int value1 = 0;
            int value2 = 0;

            if (int.TryParse(number1.Text, out value1) && int.TryParse(number2.Text, out value2))
            {
                helloWorld.Text = null;
                var calculator = (Calculator)Session["Calculator"];
                answer.Text = calculator.Execute(value1, value2).ToString();
            }
            else
            {
                helloWorld.Text = null;
                Error.Text = "Please use only Whole numbers";
            };

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Calculator"] == null)
            {
                Session["Calculator"] = new Calculator();
            }

            if (IsPostBack)
            {
                return;
            }
            helloWorld.Text = "Hello Select the type of Calculator you need";
            Operator.Text = "";


        }


    }


}

