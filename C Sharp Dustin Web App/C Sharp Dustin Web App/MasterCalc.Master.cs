using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using C_Sharp_Dustin_Web_App;



namespace C_Sharp_Dustin_Web_App
{
    public partial class MasterCalc : System.Web.UI.MasterPage
    {
        protected void Add_Button_Click(object sender, EventArgs e)
        {
            var calculator = (Calculator)Session["Calculator"];
            calculator.SetStateToAdded();
            currentState.Text = "Adding";

        }

        protected void Subtract_Button_Click(object sender, EventArgs e)
        {
            var calculator = (Calculator)Session["Calculator"];
            calculator.SetStateToSubtract();
            currentState.Text = "Subtracting";

        }

        protected void Divide_Button_Click(object sender, EventArgs e)
        {
            var calculator = (Calculator)Session["Calculator"];
            calculator.SetStateToDivide();
            currentState.Text = "Dividing";
        }

        protected void Multiply_Button_Click(object sender, EventArgs e)
        {
            var calculator = (Calculator)Session["Calculator"];
            calculator.SetStateToMultiply();
            currentState.Text = "Multiplying";
        }
    }
}