<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PatientLogin.aspx.cs" Inherits="HomeMaster.PatientLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="476px">
        <asp:HyperLink ID="Home" runat="server" Font-Bold="True" 
    Font-Size="X-Large" NavigateUrl="~/Firstpage.aspx" 
    style="z-index: 1; left: 27px; top: 214px; position: absolute">Home</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
            style="z-index: 1; left: 370px; top: 203px; position: absolute" 
            Text="PATIENT LOGIN"></asp:Label>
        <asp:Label ID="Lbl_UserName" runat="server" 
            style="z-index: 1; left: 105px; top: 278px; position: absolute; right: 856px;" 
            Text="User Name"></asp:Label>
        <asp:TextBox ID="Txt_UserName" runat="server" 
            style="z-index: 1; left: 259px; top: 276px; position: absolute"></asp:TextBox>
        <asp:Label ID="Lbl_Password" runat="server" 
            style="z-index: 1; left: 105px; top: 326px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="Txt_Password" runat="server" 
            style="z-index: 1; left: 260px; top: 319px; position: absolute" 
            TextMode="Password"></asp:TextBox>
        <asp:Label ID="Lbl_UserType" runat="server" 
            style="z-index: 1; left: 106px; top: 369px; position: absolute" 
            Text="User Type"></asp:Label>
        <asp:TextBox ID="Txt_UserType" runat="server" Enabled="False" Font-Bold="True" 
            ReadOnly="True" 
            style="z-index: 1; left: 260px; top: 365px; position: absolute; width: 114px;">Patient</asp:TextBox>
        <asp:Button ID="Btn_PatientLogin" runat="server" 
            style="z-index: 1; left: 344px; top: 421px; position: absolute" 
            Text="Login" onclick="Btn_PatientLogin_Click" />
        <asp:Label ID="Lbl_status" runat="server" BackColor="White" ForeColor="Red" 
            style="z-index: 1; left: 650px; top: 292px; position: absolute"></asp:Label>
    </asp:Panel>
</asp:Content>
