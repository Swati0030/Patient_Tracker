<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Clerklogin.aspx.cs" Inherits="HomeMaster.Clerklogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="502px" BorderStyle="None" 
        Font-Bold="True">
        <asp:Label ID="Lbl_Password" runat="server" Text="Password" 
            style="z-index: 1; left: 315px; top: 326px; position: absolute"></asp:Label>
            <asp:Label ID="Lbl_Userid" runat="server" Text="User ID" 
            style="z-index: 1; left: 316px; top: 278px; position: absolute"></asp:Label>
        <asp:Label ID="Lbl_UserType" runat="server" 
            style="z-index: 1; left: 316px; top: 369px; position: absolute" 
            Text="User Type"></asp:Label>
        <asp:TextBox ID="Txt_Userid" runat="server" 
            style="z-index: 1; left: 476px; top: 276px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="Txt_Password" runat="server" 
            style="z-index: 1; left: 474px; top: 319px; position: absolute" 
            TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="Txt_UserType" runat="server" 
            
            style="z-index: 1; left: 475px; top: 365px; position: absolute; width: 114px;" 
            Enabled="False" Font-Bold="True" ReadOnly="True">Clerk</asp:TextBox>
        <asp:Button ID="Btn_ClerkLogin" runat="server" 
            style="z-index: 1; left: 431px; top: 448px; position: absolute; height: 27px; width: 79px;" 
            Text="Login" Font-Bold="True" onclick="Btn_ClerkLogin_Click" />
        <asp:HyperLink ID="Home" runat="server" Font-Bold="True" Font-Size="X-Large" 
            NavigateUrl="~/Firstpage.aspx" 
            style="z-index: 1; left: 27px; top: 214px; position: absolute">Home</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
            style="z-index: 1; left: 370px; top: 203px; position: absolute" 
            Text="CLERK LOGIN"></asp:Label>
    </asp:Panel>
    
</asp:Content>
