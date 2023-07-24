<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="HomeMaster.Contactus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
     img {
    opacity: 0.4;
    filter: alpha(opacity=40);
         height: 257px;
         width: 377px;
         margin-left: 132px;
     }




img:hover {
    opacity: 1.0;
    filter: alpha(opacity=100); /* For IE8 and earlier */
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server" 
        
        
        
        style="position: absolute; z-index: 1; left: 14px; top: 287px; height: 413px; width: 1081px">
        <img src="\Home Images\phone_icon2.png" width="750"><img 
            src="\Home Images\e-mail1.png"></img></asp:Panel>
    <p style="height: 416px">
     
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
            Font-Size="X-Large" NavigateUrl="~/Firstpage.aspx">Home</asp:HyperLink>
    <div class=alternate">
</div>
&nbsp;</p>
</asp:Content>
