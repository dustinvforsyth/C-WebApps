<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="interfaceExample.aspx.cs" Inherits="C_Sharp_Dustin_Web_App.interfaces.interfaceExample" %>

<!DOCTYPE html>
<style>
    div#outputfields {
        display: inline-flex;
    }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tire Size Calculated Differences</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tire Size Calculator</h1>
            <h2>Used to Compare two Tires</h2>
        </div>
        <div id="tire1Inputfields">
            <div>Current Tire</div>
            <asp:TextBox ID="TextBoxSectionWidth" runat="server"></asp:TextBox>/
            <asp:TextBox ID="TextBoxSectionHeight" runat="server"></asp:TextBox>R-
            <asp:TextBox ID="TextBoxRimSize" runat="server"></asp:TextBox>
        </div>
        <div id="tire2Inputfields">
            <div>New Tire</div>
            <asp:TextBox ID="TextBoxSectionWidth2" runat="server"></asp:TextBox>/
            <asp:TextBox ID="TextBoxSectionHeight2" runat="server"></asp:TextBox>R-
            <asp:TextBox ID="TextBoxRimSize2" runat="server"></asp:TextBox>
        </div>
        <div id="outputfields">
            <div id="labelsForOutput">
                <div>Tire Specs</div>
                <div style="height: 20px">Sidewall Height: </div>
                <div style="height: 20px">Section Height: </div>
                <div style="height: 20px">OverallDiameter: </div>
                <div style="height: 20px">Circumference: </div>
                <div style="height: 20px">Revolutions Per Mile: </div>
            </div>
            <div id="tire1Ouputs">
                <div>
                    <div>Current Tire</div>
                </div>
                <div>
                    <asp:TextBox ID="tire1SidewallHeight" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tire2SidewallHeight" runat="server"></asp:TextBox>
                    <asp:TextBox ID="differenceInSidewallHeight" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:TextBox ID="tire1SectionWidth" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tire2SectionWidth" runat="server"></asp:TextBox>
                    <asp:TextBox ID="differenceInSectionWidth" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:TextBox ID="tire1OverallDiameter" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tire2OverallDiameter" runat="server"></asp:TextBox>
                    <asp:TextBox ID="differenceInOverallDiameter" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:TextBox ID="tire1Circumference" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tire2Circumference" runat="server"></asp:TextBox>
                    <asp:TextBox ID="differenceInCircumference" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:TextBox ID="tire1RevsPerMile" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tire2RevsPerMile" runat="server"></asp:TextBox>
                    <asp:TextBox ID="differenceInRevsPerMile" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <asp:Button ID="calculateBtn" runat="server" OnClick="calculateTireSize" Text="Calculate" />
            </div>

        </div>
            <div>
                <div>Change in MPH:<asp:TextBox ID="differenceInMph" runat="server"></asp:TextBox></div>
                <div>Percent Change:<asp:TextBox ID="differencePercent" runat="server"></asp:TextBox></div>
                <div>Change in Odometer Reading:<asp:TextBox ID="differenceMiles" runat="server"></asp:TextBox></div>
            </div>



    </form>
</body>
</html>
