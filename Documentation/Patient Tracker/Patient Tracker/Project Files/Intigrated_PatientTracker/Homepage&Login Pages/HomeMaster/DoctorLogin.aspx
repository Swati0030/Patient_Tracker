<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DoctorLogin.aspx.cs" Inherits="HomeMaster.DoctorLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" language="javascript">
　
　
    function validate() {
        flag = 1;
        var userid = document.getElementById("<%=Txt_Userid.ClientID %>");
        var userid_temp = userid.value;

        var password = document.getElementById("<%=Txt_Password.ClientID %>");
        var password_temp = password.value;


        if (userid_temp == "") {
            flag = 1;
            alert("Please enter Userid");
        }
        
        else if (password_temp == "") {
            flag = 1;
            alert("Please enter Password");
        }
        else {
            flag = 0;
        }

        if (flag == 1) {
            return false;
        }
        else {
            return true;
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="345px">
        <asp:Button ID="Btn_DoctorLogin" runat="server" Text="Login" 
            style="z-index: 1; left: 486px; top: 421px; position: absolute; height: 29px; width: 90px;" 
             OnClientClick="return validate();" onclick="Btn_DoctorLogin_Click" 
            CssClass="ButtonClass" />
        <asp:Label ID="Lbl_Userid" runat="server" 
            style="z-index: 1; left: 372px; top: 275px; position: absolute; right: 730px; height: 20px;" 
            Text="User ID"></asp:Label>
        <asp:TextBox ID="Txt_Userid" runat="server" 
            style="z-index: 1; left: 529px; top: 276px; position: absolute"></asp:TextBox>
           
        <asp:Label ID="Lbl_Password" runat="server" 
            style="z-index: 1; left: 369px; top: 326px; position: absolute" 
            Text="Password"></asp:Label>
            
        <asp:TextBox ID="Txt_Password" runat="server" 
            style="z-index: 1; left: 530px; top: 319px; position: absolute" 
            TextMode="Password"></asp:TextBox>
            
        <asp:Label ID="Lbl_UserType" runat="server" 
            style="z-index: 1; left: 368px; top: 369px; position: absolute" 
            Text="User Type"></asp:Label>
            
            
        <asp:TextBox ID="Txt_UserType" runat="server" Font-Bold="True" 
            ReadOnly="True" 
            
            style="z-index: 1; left: 530px; top: 365px; position: absolute; width: 114px;">Doctor</asp:TextBox>
            
        <asp:HyperLink ID="Home" runat="server" Font-Bold="True" Font-Size="X-Large" 
            NavigateUrl="~/Firstpage.aspx" 
            style="z-index: 1; left: 27px; top: 214px; position: absolute">Home</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
            style="z-index: 1; left: 370px; top: 203px; position: absolute" 
            Text="DOCTOR LOGIN"></asp:Label>
    </asp:Panel>
</asp:Content>
