<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Doctorhome.aspx.cs" Inherits="HomeMaster.Doctorhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" language="javascript">
　
　
function validate() {
flag = 1;
var pid = document.getElementById("<%=Txt_Patientid.ClientID %>");
var pid_temp = pid.value;

if (pid_temp=="") {
    flag = 1;
    alert("Please enter Patient ID");
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

    <p style="height: 382px; background-color: #FFFFCC;">
        <asp:Label ID="Lbl_Patientid" runat="server" 
            style="z-index: 1; left: 330px; top: 381px; position: absolute" 
            Text="Enter Patient Id"></asp:Label>
        <asp:TextBox ID="Txt_Patientid" runat="server" 
            
            style="z-index: 1; left: 472px; top: 380px; position: absolute"></asp:TextBox>
        <asp:Button ID="Btn_viewhistory" runat="server"  OnClientClick="return validate();" onclick="Btn_viewhistory_Click" 
            style="z-index: 1; left: 511px; top: 430px; position: absolute" 
            Text="View history" />
        <asp:Button ID="Btn_prescription" runat="server" 
              OnClientClick="return validate();" onclick="Btn_prescription_Click" 
            style="z-index: 1; left: 313px; top: 430px; position: absolute" 
            Text="New Prescription" />
        <asp:Button ID="Btn_Logout" runat="server" 
            style="z-index: 1; left: 900px; top: 241px; position: absolute" 
            Text="Logout" onclick="Btn_Logout_Click" />
        &nbsp;
        <asp:Label ID="Lbl_Load" runat="server" Font-Size="XX-Large" 
            ForeColor="#009900" 
            
            
            style="z-index: 1; left: 363px; top: 255px; position: absolute; width: 314px; height: 56px" 
            Font-Italic="True"></asp:Label>
    </p>

</asp:Content>
