<%@ Page Title="" Language="C#" MasterPageFile="~/Clerk.Master" AutoEventWireup="true" CodeBehind="PatientRegistration.aspx.cs" Inherits="HomeMaster.PatientRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    #Reset2
    {
        z-index: 1;
        left: 750px;
        top: 713px;
        position: absolute;
    }
</style>
 <script type="text/javascript" language="javascript">

     function validatename(key) {

         //getting key code of pressed key

         var keycode = (key.which) ? key.which : key.keyCode;

         var name = document.getElementById('Txt_PatientName');

         //comparing pressed keycodes

         if (!(keycode == 8 || keycode == 46 || keycode == 10 || keycode == 32) && (keycode < 65 || keycode > 90) && (keycode < 97 || keycode > 122)) {

             return false;

         }

         else {

             //Condition to check textbox contains ten numbers or not 

             if (name.value.length < 20) {

                 return true;

             }
             else if (name.value.length == 20) {
                 if (!(keycode == 8 || keycode == 46)) {
                     return false;
                 }
                 else {
                     return true;
                 }

             }


             else {

                 return false;

             }

         }

     }
     //Function to allow only numbers to textbox

     function validatenum(key) {

         //getting key code of pressed key

         var keycode = (key.which) ? key.which : key.keyCode;

         var phn = document.getElementById('Txt_PatientContactNumber');

         //comparing pressed keycodes

         if (!(keycode == 8 || keycode == 46) && (keycode < 48 || keycode > 57)) {

             return false;

         }

         else {

             //Condition to check textbox contains ten numbers or not 

             if (phn.value.length < 10) {

                 return true;

             }
             else if (phn.value.length == 10) {
                 if (!(keycode == 8 || keycode == 46)) {
                     return false;
                 }
                 else {
                     return true;
                 }

             }



             else {

                 return false;

             }

         }

     }
     function validateage(key) {

         //getting key code of pressed key

         var keycode = (key.which) ? key.which : key.keyCode;

         var age = document.getElementById('Txt_PatientAge');

         //comparing pressed keycodes

         if (!(keycode == 8 || keycode == 46) && (keycode < 48 || keycode > 57)) {

             return false;

         }

         else {

             //Condition to check textbox contains ten numbers or not 

             if (age.value.length < 2) {

                 return true;

             }
             else if (age.value.length == 2) {
                 if (!(keycode == 8 || keycode == 46)) {
                     return false;
                 }
                 else {
                     return true;
                 }

             }



             else {

                 return false;

             }

         }

     }
     function validate() {
         flag = 1;
         var pname = document.getElementById("<%=Txt_PatientName.ClientID %>");
         var pname_temp = pname.value;
         var pname_re = /^([a-zA-Z' ']{4,})+$/;

         var page = document.getElementById("<%=Txt_Age.ClientID %>");
         var page_temp = page.value;
         var page_re = /^([\d\d])/;

         var email = document.getElementById("<%=Txt_Emailid.ClientID %>");
         var email_temp = email.value;
         var email_re = /^\s*(([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+([;.](([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+)*\s*$/;

         var pcontactno = document.getElementById("<%=Txt_PatientContactNumber.ClientID %>");
         var pcontactno_temp = pcontactno.value;
         var pcontactno_re = /^(([789]{1})+([0-9]{9}))+$/;

         var paddress = document.getElementById("<%=Txt_PatientAddress.ClientID %>");
         var paddress_temp = paddress.value;

         var gender = document.getElementById("<%=DDL_Gender.ClientID %>");
         var gender_temp = gender.value;


         if (gender_temp == "--SELECT--" || paddress_temp == "" || pcontactno_temp == "" || email_temp == "" || page_temp == "" || pname_temp == "") {
             flag = 1;
             alert("All fields are mandatory");
         }
         else {

             if (!pname_re.test(pname_temp)) {
                 flag = 1;
                 alert("Patient name should contain only alphabets and it should contain minimum of 4 charecters");
             }

             else if (!page_re.test(page_temp)) {
                 flag = 1;
                 alert("Please enter valid Age");
             }
             else if (!pcontactno_re.test(pcontactno_temp)) {
                 flag = 1;
                 alert("Pease enter valid Contact Number");
             }
             else if (!email_re.test(email_temp)) {
                 flag = 1;
                 alert("Please enter valid Email ID");
             }
             else {
                 flag = 0;
             }
         }

         if (flag == 1) {
             return false;
         }
         else {
             return true;
         }
     }
     function Reset2_onclick() {

     }

 </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server" Height="457px" Width="1291px">
           <asp:Label ID="Lbl_Gender" runat="server" 
    style="z-index: 1; left: 746px; top: 482px; position: absolute; height: 19px; bottom: 216px;" 
                            Text="Gender"></asp:Label>
                        <asp:Label ID="Lbl_PatientContactNumber" runat="server" ForeColor="Black" 
                            style="z-index: 1; left: 745px; top: 541px; position: absolute" 
                            Text="Contact Number"></asp:Label>
                        <asp:Label ID="Lbl_Emailid" runat="server" 
                            style="z-index: 1; left: 742px; top: 418px; position: absolute" 
                            Text="Email ID"></asp:Label>
                        <asp:Label ID="Lbl_PatientAddress" runat="server" 
                            style="z-index: 1; left: 249px; top: 531px; position: absolute" 
                            Text="Address"></asp:Label>
                        <asp:Label ID="Lbl_PatientAge" runat="server" 
                            style="z-index: 1; left: 252px; top: 473px; position: absolute" 
                            Text="Age"></asp:Label>
                        <asp:Label ID="Lbl_PatientName" runat="server" 
                            style="z-index: 1; left: 249px; top: 423px; position: absolute" 
                            Text="Patient Name"></asp:Label>
                        <asp:TextBox ID="Txt_PatientContactNumber" runat="server"                        
                                                        
                           
               style="z-index: 1; left: 927px; top: 537px; position: absolute; height: 20px; width: 175px;" 
               onkeypress="return validatenum(event)"></asp:TextBox>
                        <asp:TextBox ID="Txt_Emailid" runat="server" 
                            
                            
                            
                            
               style="z-index: 1; left: 920px; top: 416px; position: absolute; height: 20px; width: 174px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_PatientAddress" runat="server" 
                            style="z-index: 1; left: 423px; top: 510px; position: absolute; height: 47px; width: 172px;" 
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:TextBox ID="Txt_Age" runat="server" 
                            
               style="z-index: 1; left: 422px; top: 469px; position: absolute; height: 20px; width: 35px;" 
               onkeypress="return validateage(event)"></asp:TextBox>
                        <asp:Label ID="Lbl_Result" runat="server" Font-Bold="True" Font-Size="X-Large" 
                            
                            
               
               style="z-index: 1; left: 480px; top: 606px; position: absolute; width: 344px; height: 67px" 
               ForeColor="#009900"></asp:Label>
                        <asp:DropDownList ID="DDL_Gender" runat="server" 
                            
                            
               style="z-index: 1; left: 924px; top: 474px; position: absolute; height: 16px; width: 89px;">
                            <asp:ListItem>--SELECT--</asp:ListItem>
                            <asp:ListItem>MALE</asp:ListItem>
                            <asp:ListItem>FEMALE</asp:ListItem>
                            <asp:ListItem>OTHERS</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="Txt_PatientName" runat="server"                                                   
                           
                            
               style="z-index: 1; left: 421px; top: 422px; position: absolute;  height: 20px; width: 175px;" 
               onkeypress="return validatename(event)"></asp:TextBox>
                        
                        &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" 
               NavigateUrl="~/ClerkHome.aspx">Home</asp:HyperLink>
                        
                        <input id="Reset2" type="reset" 
    value="Reset" class="ButtonClass" onclick="return Reset2_onclick()" />
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" 
               Font-Size="XX-Large" 
               style="z-index: 1; left: 435px; top: 335px; position: absolute" 
               Text="Patient Registration"></asp:Label>
           <asp:Button ID="Btn_Register" runat="server"  
               OnClientClick= "return validate();" onclick="Btn_Register_Click" 
               style="z-index: 1; left: 513px; top: 714px; position: absolute" 
               Text="Register" />
    </asp:Panel>

</asp:Content>
