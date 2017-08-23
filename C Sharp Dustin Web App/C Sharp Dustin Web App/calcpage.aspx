<%@ Page Title="" Language="C#" MasterPageFile="~/MasterCalc.Master" AutoEventWireup="true" CodeBehind="calcpage.aspx.cs" Inherits="C_Sharp_Dustin_Web_App.calcpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label id="helloWorld" runat="server"></asp:Label><br />
    <br />
   <asp:TextBox ID="number1" runat="server"></asp:TextBox>
    <asp:Label ID="Operator" runat="server"></asp:Label>
    <asp:TextBox ID="number2" runat="server"></asp:TextBox>
    <asp:Button ID="Calculate" runat="server" Text="Calculate" OnClick="addition" />
     
    <asp:Label ID="answer" runat="server"></asp:Label>
    <asp:Label ID="Error" runat="server" Forecolor ="Red"></asp:Label>
    
</asp:Content>
