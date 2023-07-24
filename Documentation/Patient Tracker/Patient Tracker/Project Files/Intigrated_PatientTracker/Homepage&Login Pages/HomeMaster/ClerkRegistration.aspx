<%@ Page Title="" Language="C#" MasterPageFile="~/Clerk.Master" AutoEventWireup="true" CodeBehind="ClerkRegistration.aspx.cs" Inherits="HomeMaster.Clerk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Reset1
        {
            z-index: 1;
            left: 693px;
            top: 692px;
            position: absolute;
        }
    </style>

     <script type="text/javascript" language="javascript">


         //Function to allow only numbers to textbox

         function validatenum(key) {

             //getting key code of pressed key

             var keycode = (key.which) ? key.which : key.keyCode;

             var phn = document.getElementById('Txt_ContactNumber');

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

             var age = document.getElementById('Txt_Age');

             //comparing pressed keycodes

             if (!(keycode == 8 || keycode == 46) && (keycode < 48 || keycode > 57)) {

                 return false;

             }

             else {

                 //Condition to check textbox contains ten numbers or not 

//                 if (age.value.length < 2) {

                     return true;

//                 }
//                 else if (age.value.length == 2) {
//                     if (!(keycode == 8 || keycode == 46)) {
//                         return false;
//                     }
//                     else {
//                         return true;
//                     }

//                 }



//                 else {

//                     return false;

//                 }

             }

         }
         function validatename(key) {

             //getting key code of pressed key

             var keycode = (key.which) ? key.which : key.keyCode;

             var name = document.getElementById('Txt_ClerkName');

             //comparing pressed keycodes

             if (!(keycode == 8 || keycode == 46 || keycode == 10 || keycode == 32) && (keycode < 65 || keycode > 90) && (keycode < 97 || keycode > 122)) {

                 return false;

             }

             else {

                 //Condition to check textbox contains ten numbers or not 

//                 if (name.value.length < 20) {

                     return true;

//                 }
//                 else if (name.value.length == 20) {
//                     if (!(keycode == 8 || keycode == 46)) {
//                         return false;
//                     }
//                     else {
//                         return true;
//                     }

//                 }


//                 else {

//                     return false;

//                 }

             }

         }
         


         function validate() {
             flag = 1;
             var cname = document.getElementById("<%=Txt_ClerkName.ClientID %>");
             var cname_temp = cname.value;
             var cname_re = /^([a-zA-Z' ']{4,50})+$/;

             var cnumber = document.getElementById("<%=Txt_ContactNumber.ClientID %>");
             var cnumber_temp = cnumber.value;
             var cnumber_re = /^([0-9]{10})+$/;

             var email = document.getElementById("<%=Txt_Emailid.ClientID %>");
             var email_temp = email.value;
             var email_re = /^s*(([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+([;.](([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+)*\s*$/;

             var address = document.getElementById("<%=Txt_Address.ClientID %>");
             var address_temp = address.value;

             var user = document.getElementById("<%=Txt_UserType.ClientID %>");
             var user_temp = user.value;

             var doj = document.getElementById("<%=Txt_DateOfJoining.ClientID %>");
             var doj_temp = doj.value;

             var age = document.getElementById("<%=Txt_Age.ClientID %>");
             var age_temp = age.value;

             if (user_temp == "" || cname_temp == "" || address_temp == "" || doj_temp == "" || age_temp == "" || email_temp == "") {
                 flag = 1;
                 alert("All fields are mandatory");
             }
             else {
                 if (!email_re.test(email_temp)) {
                     flag = 1;
                     alert("Please enter valid email address");
                 }
                 else if (!cnumber_re.test(cnumber_temp)) {
                     flag = 1;
                     alert("Please enter valid Contact number");
                 }
                 else if (!cname_re.test(cname_temp)) {
                     flag = 1;
                     alert("Clerk name must contain alphabets and it should contain min 4 characters");
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

    
    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <asp:Panel ID="Panel1" runat="server" Height="439px" Width="1282px">
    
        <asp:Button ID="Btn_Register" runat="server" Text="Register" 
            style="z-index: 1; left: 474px; top: 693px; position: absolute"  
            OnClientClick = "return validate();" onclick="Btn_Register_Click" 
             />
        <asp:TextBox ID="Txt_ClerkName" runat="server" 
            
            
            style="z-index: 1; left: 350px; top: 400px; position: absolute; height: 18px; right: 859px;" 
            onkeydown="return validatename(event)"></asp:TextBox>
        <asp:Label ID="Lbl_ClerkName" runat="server" 
            style="z-index: 1; left: 215px; top: 393px; position: absolute" 
            Text="Clerk Name"></asp:Label>
        <asp:Label ID="Lbl_Address" runat="server" 
            style="z-index: 1; left: 213px; top: 503px; position: absolute" 
            Text="Address"></asp:Label>
        <asp:Label ID="lblStatus1" runat="server" 
            
            
            
            style="z-index: 1; left: 482px; top: 600px; position: absolute; width: 356px; height: 53px" 
            Font-Size="X-Large" ForeColor="#009900"></asp:Label>
        <asp:TextBox ID="Txt_Address" runat="server" 
            
            style="z-index: 1; left: 347px; top: 488px; position: absolute; right: 809px; height: 47px;" 
            TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="Txt_Age" runat="server" 
                    style="z-index: 1; left: 349px; top: 447px; position: absolute" 
            onkeydown="return validateage(event)"></asp:TextBox>
        <asp:Label ID="Lbl_Age" runat="server" 
            style="z-index: 1; left: 218px; top: 442px; position: absolute; height: 21px; width: 48px" 
            Text="Age"></asp:Label>
        <asp:Label ID="Lbl_ContactNumber" runat="server" 
            style="z-index: 1; left: 685px; top: 527px; position: absolute" 
            Text="Contact Number"></asp:Label>
        <asp:Label ID="Lbl_DateOfJoining" runat="server" Font-Bold="False" 
            Font-Italic="False" 
            style="z-index: 1; left: 682px; top: 384px; position: absolute; height: 21px;" 
            Text="Date of joining"></asp:Label>
        <asp:TextBox ID="Txt_DateOfJoining" runat="server" 
            
            
            
            style="z-index: 1; left: 831px; top: 385px; position: absolute; width: 115px;" 
            ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="Txt_UserType" runat="server" 
            style="z-index: 1; left: 832px; top: 476px; position: absolute" 
            ReadOnly="True">Clerk</asp:TextBox>
        <asp:Label ID="Lbl_UserType" runat="server" 
            style="z-index: 1; left: 683px; top: 473px; position: absolute; width: 56px;" 
            Text="UserType"></asp:Label>
        <asp:Label ID="Lbl_Emailid" runat="server" 
            style="z-index: 1; left: 682px; top: 428px; position: absolute; height: 17px" 
            Text="Email Id"></asp:Label>
        <asp:TextBox ID="Txt_Emailid" runat="server" 
            
            
            
            
            style="z-index: 1; left: 832px; top: 428px; position: absolute; right: 377px;"></asp:TextBox>
        <asp:TextBox ID="Txt_ContactNumber" runat="server"  
            style="z-index: 1; left: 833px;  top: 526px; position: absolute" 
            onkeydown="return validatenum(event)"></asp:TextBox>
        
        <%--<asp:Label ID="lblStatus" runat="server" 
            
            style="z-index: 1; left: 393px; top: 565px; position: absolute; width: 179px; height: 38px;" 
            ForeColor="#009933"></asp:Label>--%>
        
        <input id="Reset1" type="reset" value="Reset" />
        
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Home Images/download.png" 
            onclick="ImageButton2_Click" 
            
            
            style="z-index: 1; left: 958px; top: 384px; position: absolute; height: 21px; width: 28px" />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
            onselectionchanged="Calendar1_SelectionChanged" ShowGridLines="True" 
            style="z-index: 1; left: 991px; top: 396px; position: absolute; height: 154px; width: 170px" 
            Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
            style="z-index: 1; left: 399px; top: 323px; position: absolute" 
            Text="CLERK REGISTRATION"></asp:Label>
        
    </asp:Panel>
    
</asp:Content>
