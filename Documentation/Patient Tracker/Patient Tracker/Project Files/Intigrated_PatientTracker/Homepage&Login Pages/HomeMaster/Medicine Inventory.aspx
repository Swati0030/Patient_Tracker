<%@ Page Title="" Language="C#" MasterPageFile="~/Clerk.Master" AutoEventWireup="true" CodeBehind="Medicine Inventory.aspx.cs" Inherits="HomeMaster.Medicine_Inventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        <%-- #Reset1
        {
            z-index: 1;
            left: 751px;
            top: 1094px;
            position: absolute;
        }--%>
        #Reset1
        {
            z-index: 1;
            left: 666px;
            top: 666px;
            position: absolute;
            height: 27px;
        }
        #Reset1
        {
            z-index: 1;
            left: 649px;
            top: 350px;
            position: absolute;
            height: 25px;
        }
                
        .ButtonClass
        {
            cursor:pointer;
        }
    </style>

    <script type="text/javascript" language="javascript">
        function validate() {
            flag = 1;
            var mname = document.getElementById("<%=Txt_MedicineName.ClientID %>");
            var mname_temp = mname.value;
            var mname_re = /^([a-zA-Z0-9' '])+$/;

            var mid = document.getElementById("<%=Txt_Medicineid.ClientID %>");
            var mid_temp = mid.value;
            var mid_re = /^([0-9]{5})+$/;

            var cname = document.getElementById("<%=Txt_CompanyName.ClientID %>");
            var cname_temp = cname.value;
            var cname_re = /^([a-zA-Z' '])+$/;

            var quantity = document.getElementById("<%=Txt_Quantity.ClientID %>");
            var quantity_temp = quantity.value;
            var quantity_re = /^([0-9])+$/;

            var price = document.getElementById("<%=Txt_PricePerUnit.ClientID %>");
            var price_temp = price.value;
            var price_re = /^([0-9])+$/;

            var mdate = document.getElementById("<%=Txt_ManufacturingDate.ClientID %>");
            var mdate_temp = mdate.value;

            var edate = document.getElementById("<%=Txt_ExpiryDate.ClientID %>");
            var edate_temp = edate.value;

            var mtype = document.getElementById("<%=DDL_MedicineType.ClientID %>");
            var mtype_temp = mtype.value;

            var stype = document.getElementById("<%=DDL_StorageType.ClientID %>");
            var stype_temp = stype.value;




            if (mname_temp == "" || cname_temp == "" || quantity_temp == "" || price_temp == "" || mdate_temp == "" || edate_temp == "" || mtype_temp == "--Select--" || stype_temp == "--Select--" || mid_temp == "") {
                flag = 1;
                alert("All fields are Mandatory");
            }
            else {
                if (!mname_re.test(mname_temp)) {
                    flag = 1;
                    alert("Medicine name should contain only alphabets and numbers");
                }
                if (!cname_re.test(cname_temp)) {
                    flag = 1;
                    alert("Company name should contain only alphabets");
                }
                if (!quantity_re.test(quantity_temp)) {
                    flag = 1;
                    alert("Quantity should contain only numbers");
                }
                if (!price_re.test(price_temp)) {
                    flag = 1;
                    alert("Price should contain only numbers");
                }
                if (!mid_re.test(mid_temp)) {
                    flag = 1;
                    alert("Medicine id should contain numbers upto 5 digits");
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
    &nbsp;<asp:Panel ID="Panel1" runat="server" Height="467px">
    <asp:TextBox ID="Txt_ManufacturingDate" runat="server" 
                        
            
            style="z-index: 1; left: 898px; top: 605px; position: absolute; width: 87px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_ExpiryDate" runat="server" 
                        
            
            style="z-index: 1; left: 902px; top: 668px; position: absolute; width: 84px;"></asp:TextBox>
                                    

                        
                   
                        <asp:Label ID="Lbl_PricePerUnit" runat="server" Text="Price Per Unit" 
                            
                            style="z-index: 1; left: 699px; top: 538px; position: absolute; height: 19px;" 
                            Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_CompanyName" runat="server" 
                            style="z-index: 1; left: 274px; top: 605px; position: absolute; height: 19px;" 
                            Text="Company Name" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Quantity" runat="server" 
                            style="z-index: 1; left: 697px; top: 478px; position: absolute; height: 19px;" 
                            Text="Quantity" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_MedicineName" runat="server" 
                            style="z-index: 1; left: 272px; top: 548px; position: absolute; height: 19px;" 
                            Text="Medicine Name" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_StorageType" runat="server" 
                            style="z-index: 1; left: 693px; top: 408px; position: absolute; height: 19px;" 
                            Text="Storage Type" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Doctorid" runat="server" 
                            style="z-index: 1; left: 273px; top: 491px; position: absolute; height: 19px;" 
                            Text="Doctor ID" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_MedicineType" runat="server" 
                            style="z-index: 1; left: 276px; top: 667px; position: absolute; height: 19px;" 
                            Text="Medicine Type" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_ExpiryDate" runat="server" 
                            style="z-index: 1; left: 703px; top: 668px; position: absolute; height: 15px; right: 169px;" 
                            Text="Expiry Date" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_ManufacturingDate" runat="server" 
                            style="z-index: 1; left: 702px; top: 607px; position: absolute; height: 19px;" 
                            Text="Manufacturing Date" Font-Bold="True" Font-Size="Large" 
                            ForeColor="Black"></asp:Label>
                        <asp:Label ID="Lbl_Medicineid" runat="server" 
                            style="z-index: 1; left: 271px; top: 417px; position: absolute; height: 19px;" 
                            Text="Medicine ID" Font-Bold="True" Font-Size="Large" 
            ForeColor="Black"></asp:Label>
                        <asp:TextBox ID="Txt_Medicineid" runat="server" 
                            
                            
            
            style="z-index: 1; left: 454px; top: 413px; position: absolute; width: 137px; height: 23px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_MedicineName" runat="server" 
                            
                            
            
            style="z-index: 1; left: 458px; top: 554px; position: absolute; width: 143px; height: 20px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_Doctorid" runat="server" 
                            
                            
            
            style="z-index: 1; left: 456px; top: 488px; position: absolute; width: 140px; height: 24px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_PricePerUnit" runat="server" 
                            
                            
            
            style="z-index: 1; left: 894px; top: 528px; position: absolute; width: 89px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_Quantity" runat="server" 
                            
                            
            
            style="z-index: 1; left: 889px; top: 465px; position: absolute; width: 90px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_CompanyName" runat="server" 
                            
                            
            
            style="z-index: 1; left: 458px; top: 612px; position: absolute; width: 140px; height: 21px;"></asp:TextBox>
                        <asp:DropDownList ID="DDL_StorageType" runat="server" 
                            
                            
                            
                            
                            
                            
                            
                            
            
            style="z-index: 1; left: 884px; top: 403px; position: absolute; height: 24px; width: 96px">
                            <asp:ListItem>--Select--</asp:ListItem>
                            <asp:ListItem>Normal</asp:ListItem>
                            <asp:ListItem>Cold</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DDL_MedicineType" runat="server" 
                            
                            
                            
                            
            
            style="z-index: 1; left: 462px; top: 662px; position: absolute; width: 135px; height: 24px;">
                            <asp:ListItem>--Select--</asp:ListItem>
                            <asp:ListItem>Injection</asp:ListItem>
                            <asp:ListItem>Ointment</asp:ListItem>
                            <asp:ListItem>Tablets</asp:ListItem>
                            <asp:ListItem>Syrup</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                            style="z-index: 1; left: 480px; top: 321px; position: absolute" 
                            Text="MEDICINE INVENTORY" ForeColor="#3399FF"></asp:Label>
                        <asp:Button ID="Btn_AddMedicine" runat="server" 
                            style="z-index: 1; left: 502px; top: 744px; position: absolute; right: 695px;" 
                            Text="Add Medicine"  OnClientClick="return validate();" 
                            onclick="Btn_AddMedicine_Click" CssClass="ButtonClass" />
                        &nbsp;<asp:Label ID="Lbl_Date" 
                            runat="server" ForeColor="Red" 
                            
            style="z-index: 1; left: 901px; top: 639px; position: absolute"></asp:Label>
                        
                        &nbsp;<asp:ImageButton ID="ImageButton4" runat="server" 
            ImageUrl="~/Home Images/download.png" onclick="ImageButton4_Click" 
            
            style="z-index: 1; left: 999px; top: 603px; position: absolute; height: 26px; width: 27px;" />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" 
            onselectionchanged="Calendar1_SelectionChanged1" ShowGridLines="True" 
            
            style="z-index: 1; left: 1054px; top: 586px; position: absolute; height: 71px; width: 103px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <asp:ImageButton ID="calanderImage" runat="server" ImageUrl="~/Home Images/download.png" 
            onclick="calanderImage_Click" 
            
            style="z-index: 1; left: 999px; top: 668px; position: absolute; height: 25px; width: 29px" />
        <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" 
            BorderColor="#FFCC66" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" 
            onselectionchanged="Calendar2_SelectionChanged" 
            
            
            
            style="z-index: 1; left: 1060px; top: 628px; position: absolute; height: 194px; width: 215px" Height="200px" 
            Width="220px" BorderWidth="1px" DayNameFormat="Shortest" 
            ShowGridLines="True">
            <DayHeaderStyle Font-Bold="True" Height="1px" BackColor="#FFCC66" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
                        
                        <input id="Reset1" type="reset" 
    value="Reset" style="z-index: 1; left: 778px; top: 744px; position: absolute;" title="Reset" class="ButtonClass" />
                        
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ButtonClass" 
            NavigateUrl="~/ClerkHome.aspx">Home</asp:HyperLink>
                        
    </asp:Panel>
</asp:Content>
