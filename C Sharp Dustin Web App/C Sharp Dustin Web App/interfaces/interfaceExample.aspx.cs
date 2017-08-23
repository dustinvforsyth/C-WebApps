using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C_Sharp_Dustin_Web_App.interfaces
{
    public partial class interfaceExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateTireSize(object sender, EventArgs e)
        {
            TireCalculator tc = new TireCalculator();
            CompareTires Diff = new CompareTires();
            ICalcTireSize cts = (ICalcTireSize)tc;
            ICompareTire ct = (ICompareTire)Diff;

            var tire1Sizes = cts.tireSizeCalc(TextBoxSectionWidth.Text, TextBoxSectionHeight.Text, TextBoxRimSize.Text);
            var tire1AspectRatio = tc.convertToAspectRatio(TextBoxSectionHeight.Text);
            var tire1Circum = cts.circumferenceTire(tire1Sizes[0]);
            var tire1Sidewall = cts.sidewallHeight(tire1Sizes[1], tire1AspectRatio);
            var tire1RPM = cts.revolutionsPerMile(tire1Circum);
            tire1SidewallHeight.Text = tire1Sidewall.ToString();
            tire1SectionWidth.Text = tire1Sizes[1].ToString();
            tire1OverallDiameter.Text = tire1Sizes[0].ToString();
            tire1Circumference.Text = tire1Circum.ToString();
            tire1RevsPerMile.Text = cts.revolutionsPerMile(tire1Circum).ToString();

            var tire2Sizes = cts.tireSizeCalc(TextBoxSectionWidth2.Text, TextBoxSectionHeight2.Text, TextBoxRimSize2.Text);
            var tire2AspectRatio = tc.convertToAspectRatio(TextBoxSectionHeight2.Text);
            var tire2Circum = cts.circumferenceTire(tire2Sizes[0]);
            var tire2Sidewall = cts.sidewallHeight(tire2Sizes[1], tire2AspectRatio);
            var tire2RPM = cts.revolutionsPerMile(tire2Circum);
            tire2SidewallHeight.Text = tire2Sidewall.ToString();
            tire2SectionWidth.Text = tire2Sizes[1].ToString();
            tire2OverallDiameter.Text = tire2Sizes[0].ToString();
            tire2Circumference.Text = tire2Circum.ToString();
            tire2RevsPerMile.Text = cts.revolutionsPerMile(tire2Circum).ToString();

            differenceInSidewallHeight.Text = ct.differenceInTires(tire1Sidewall, tire2Sidewall).ToString();
            differenceInSectionWidth.Text = ct.differenceInTires(tire1Sizes[1], tire2Sizes[1]).ToString();
            differenceInOverallDiameter.Text = ct.differenceInTires(tire1Sizes[0], tire2Sizes[0]).ToString();
            differenceInCircumference.Text = ct.differenceInTires(tire1Circum, tire2Circum).ToString();
            differenceInRevsPerMile.Text = ct.differenceInTires(tire1RPM, tire2RPM).ToString();
            differenceInMph.Text = ct.mphChangeInTires(tire1RPM, tire2RPM).ToString();
            differencePercent.Text = ct.percentChangeInTires(tire1RPM, tire2RPM).ToString();
            differenceMiles.Text = ct.changedOdometer(tire1Sizes[0], tire2Sizes[0]).ToString();
        }

    }
}