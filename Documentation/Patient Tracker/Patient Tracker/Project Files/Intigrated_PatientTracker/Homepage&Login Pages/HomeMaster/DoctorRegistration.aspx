<%@ Page Title="" Language="C#" MasterPageFile="~/Clerk.Master" AutoEventWireup="true" CodeBehind="DoctorRegistration.aspx.cs" Inherits="HomeMaster.DoctorRegistration1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Reset1
        {
            z-index: 1;
            left: 743px;
            top: 429px;
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
        function validatename(key) {

            //getting key code of pressed key

            var keycode = (key.which) ? key.which : key.keyCode;

            var name = document.getElementById('Txt_DoctorName');

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
        function validateexperience(key) {

            //getting key code of pressed key

            var keycode = (key.which) ? key.which : key.keyCode;

            var exp = document.getElementById('Txt_Experience');

            //comparing pressed keycodes

            if (!(keycode == 8 || keycode == 46) && (keycode < 48 || keycode > 57)) {

                return false;

            }

            else {

                //Condition to check textbox contains ten numbers or not 

                if (exp.value.length < 2) {

                    return true;

                }
                else if (exp.value.length == 2) {
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
            var dname = document.getElementById("<%=Txt_DoctorName.ClientID %>");
            var dname_temp = dname.value;
            var dname_re = /^([a-zA-Z' ']{4,50})+$/;

            var exp = document.getElementById("<%=Txt_Experience.ClientID %>");
            var exp_temp = exp.value;
            var exp_re = /^([\d]{1,2})+$/;


            var cnumber = document.getElementById("<%=Txt_ContactNumber.ClientID %>");
            var cnumber_temp = cnumber.value;
            var cnumber_re = /^([0-9' ']{10})+$/;

            var email = document.getElementById("<%=Txt_Emailid.ClientID %>");
            var email_temp = email.value;
            var email_re = /^s*(([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+([;.](([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+)*\s*$/;

            var address = document.getElementById("<%=Txt_Address.ClientID %>");
            var address_temp = address.value;

            var user = document.getElementById("<%=Txt_UserType.ClientID %>");
            var user_temp = user.value;

            var qualif = document.getElementById("<%=DDL_Qualification.ClientID %>");
            var qualif_temp = qualif.value;

            var age = document.getElementById("<%=Txt_Age.ClientID %>");
            var age_temp = age.value;

            if (user_temp == "" || dname_temp == "" || address_temp == "" || qualif_temp == "" || age_temp == "" || exp_temp == "" || email_temp == "") {
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
                else if (!dname_re.test(dname_temp)) {
                    flag = 1;
                    alert("Doctor name must contain alphabets and it should contain min 4 characters");
                }
                else if (!exp_re.test(exp_temp) || exp_temp == 3 || exp_temp == 2 || exp_temp == 1 || exp_temp == 0) {
                    flag = 1;
                    alert("Experience should be greater than 3");
                }
                else if (age_temp - exp_temp <= 20) {
                    flag = 1;
                    alert("Age should be greater than experience!");
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
    <td>
                    <asp:Panel ID="Panel2" runat="server" ForeColor="#993333" Width="1233px" 
        style="position: relative; top: 0px; left: 0px; height: 485px">
                        <asp:Label ID="Lbl_UserType" runat="server" 
    style="z-index: 1; left: 741px; top: 235px; position: absolute" Text="User Type" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Qualification" runat="server" 
                            style="z-index: 1; left: 278px; top: 233px; position: absolute" 
                            Text="Qualification" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Emailid" runat="server" 
                            style="z-index: 1; left: 743px; top: 284px; position: absolute" 
                            Text="Email ID" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Age" runat="server" 
                            
                            style="z-index: 1; left: 282px; top: 285px; position: absolute; width: 39px;" Text="Age" 
                            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Experience" runat="server" 
                            style="z-index: 1; left: 739px; top: 124px; position: absolute" 
                            Text="Experience" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_ContactNumber" runat="server" 
                            style="z-index: 1; left: 737px; top: 180px; position: absolute" 
                            Text="Contact Number" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Address" runat="server" 
                            style="z-index: 1; left: 281px; top: 179px; position: absolute" 
                            Text="Address" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_DoctorName" runat="server" 
                            style="z-index: 1; left: 282px; top: 128px; position: absolute" 
                            Text="Doctor Name" ForeColor="Black"></asp:Label>
                        <asp:TextBox ID="Txt_DoctorName" runat="server" 
                            style="z-index: 1; left: 420px; top: 131px; position: absolute" 
                            onkeypress="return validatename(event)"></asp:TextBox>
                        <asp:TextBox ID="Txt_UserType" runat="server" 
                            style="z-index: 1; left: 854px; top: 231px; position: absolute" 
                            ReadOnly="True">Doctor</asp:TextBox>
                        <asp:TextBox ID="Txt_Address" runat="server" 
                            style="z-index: 1; left: 419px; top: 174px; position: absolute" 
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:TextBox ID="Txt_Experience" runat="server" 
                            style="z-index: 1; left: 854px; top: 125px; position: absolute; height: 28px;" 
                            onkeypress="return validateexperience(event)"></asp:TextBox>
                        <asp:TextBox ID="Txt_Emailid" runat="server" 
                            style="z-index: 1; left: 853px; top: 280px; position: absolute"></asp:TextBox>
                        <asp:TextBox ID="Txt_Age" runat="server" 
                            style="z-index: 1; left: 416px; top: 281px; position: absolute" 
                            onkeypress="return validateage(event)"></asp:TextBox>
                        <asp:TextBox ID="Txt_ContactNumber" runat="server" 
                            style="z-index: 1; left: 854px; top: 174px; position: absolute" 
                            onkeypress="return validatenum(event)"></asp:TextBox>
                        <asp:Button ID="Btn_Register" runat="server" 
                            style="z-index: 1; left: 464px; top: 430px; position: absolute" 
                            Text="Register"  OnClientClick= "return validate();" 
                            onclick="Btn_Register_Click" />
                        <asp:HyperLink ID="Hyp_Home" runat="server" Font-Bold="True" Font-Size="X-Large" 
                            ForeColor="Blue" 
                            
                            style="z-index: 1; left: 27px; top: 13px; position: absolute; width: 71px; height: 27px;" 
                            NavigateUrl="~/ClerkHome.aspx">Home</asp:HyperLink>
                        <asp:Label ID="Lbl_Status1" runat="server" 
                            
                            
                            
                            
                            style="z-index: 1; left: 405px; top: 324px; position: absolute; height: 65px; width: 389px"></asp:Label>
                        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                            style="z-index: 1; left: 436px; top: 23px; position: absolute; height: 38px; width: 328px" 
                            Text="Doctor Registration"></asp:Label>
                        <input id="Reset1" type="reset" 
    value="Reset" />
                        <asp:DropDownList ID="DDL_Qualification" runat="server" 
                            style="z-index: 1; left: 422px; top: 231px; position: absolute; height: 28px; width: 176px">
                            <asp:ListItem>--Select--</asp:ListItem>
                            <asp:ListItem>BMed</asp:ListItem>
                            <asp:ListItem>M.D</asp:ListItem>
                            <asp:ListItem>BDS</asp:ListItem>
                            <asp:ListItem>RMP</asp:ListItem>
                            <asp:ListItem>FRCS</asp:ListItem>
                            <asp:ListItem>MRCS</asp:ListItem>
                            <asp:ListItem>FACS</asp:ListItem>
                        </asp:DropDownList>
                    </asp:Panel>
                </td>
</asp:Content>
