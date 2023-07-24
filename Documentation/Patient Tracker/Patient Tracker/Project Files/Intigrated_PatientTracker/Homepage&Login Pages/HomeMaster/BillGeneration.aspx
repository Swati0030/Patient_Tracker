<%@ Page Title="" Language="C#" MasterPageFile="~/Clerk.Master" AutoEventWireup="true" CodeBehind="BillGeneration.aspx.cs" Inherits="HomeMaster.BillGeneration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            height: 751px;
        }
        .style5
        {
            height: 32px;
        }
        .style6
        {
            height: 308px;
        }
    .style7
    {
        height: 94px;
    }
    </style>
     <script type="text/javascript" language="javascript">
　
　
         function validate() {
             flag = 1;

             
             var pid = document.getElementById("<%=Txt_Patientid.ClientID %>");
             var pid_temp = pid.value;

             var cfee = document.getElementById("<%=Txt_ConsultationFee.ClientID %>");
             var cfee_temp = cfee.value;
             var cfee_re = /^([0-9])+$/;

             var mcost = document.getElementById("<%=Txt_MedicineCost.ClientID %>");
             var mcost_temp = mcost.value;
             var mcost_re = /^([0-9])+$/;

             var tcost = document.getElementById("<%=Txt_TotalCost.ClientID %>");
             var tcost_temp = tcost.value;
             var tcost_re = /^([0-9])+$/;

             var bill = document.getElementById("<%=DDL_IsBillPaid.ClientID %>");
             var bill_temp = bill.value;

             var payment = document.getElementById("<%=DDL_PaymentMode.ClientID %>");
             var payment_temp = payment.value;

             var ccnumber = document.getElementById("<%=Txt_CCNumber.ClientID %>");
             var ccnumber_temp = ccnumber.value;
             var ccnumber_re = /^([0-9]{16})+$/;


             if (pid_temp == "") {
                 flag = 1;
                 alert("Please enter Patientid");
             }
             else if (cfee_temp == "" || mcost_temp == "" || tcost_temp == "" || bill_temp == "--SELECT--" || payment_temp == "--SELECT--") {
                 flag = 1;
                 alert("All fields are mandatory");
             }

             else {

                 if (!cfee_re.test(cfee_temp)) {
                     flag = 1;
                     alert("Consultation fee should contain only numbers");
                 }
                 else if (!mcost_re.test(mcost_temp)) {
                     flag = 1;
                     alert("Medicine Cost should contain only numbers");
                 }
                 else if (!tcost_re.test(tcost_temp)) {
                     flag = 1;
                     alert("Total Cost should contain only numbers");
                 }

                 if (payment_temp == "Debit/Credit Card") {


                     if (ccnumber_temp == "") {
                         flag = 1;
                         alert("Please enter CC Number");
                     }
                     else if (!ccnumber_re.test(ccnumber_temp)) {
                         flag = 1;
                         alert("Enter valid CC Number");
                     }
                     else {
                         flag = 0;
                     }
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

    <table class="style3">
        <tr>
            <td class="style5">
                <asp:Panel ID="Panel3" runat="server" Height="102px" Width="1224px">
                    <asp:TextBox ID="Txt_Patientid" runat="server" 
                        style="z-index: 1; left: 413px; top: 416px; position: absolute; width: 126px; height: 21px;"></asp:TextBox>
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
                        Font-Size="X-Large" NavigateUrl="~/Bill.aspx">Home</asp:HyperLink>
                    <asp:Button ID="Btn_Submit" runat="server" CssClass="ButtonClass" 
                        ForeColor="Blue" onclick="Btn_Submit_Click" 
                        style="z-index: 1; left: 642px; top: 412px; position: absolute; height: 22px; width: 101px;" 
                        Text="Submit" onclientclick="return validate() ;" />
                    <asp:Label ID="Lbl_Patientid" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 203px; top: 419px; position: absolute" 
                        Text="Enter Patient ID"></asp:Label>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Panel ID="Panel2" runat="server" BackColor="#D9E8E8" BorderStyle="Inset" 
                    BorderWidth="1px" 
                    
                    style="margin-left: 0px; margin-top: 0px; height: 550px; width: 1279px; z-index: 1; left: 20px; top: 509px; position: absolute;">
                    <asp:Label ID="Lbl_CCNnumber" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 769px; top: 273px; position: absolute" 
                        Text="CC Number"></asp:Label>
                    <asp:Label ID="Lbl_NextConsultationDate" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 176px; top: 155px; position: absolute" 
                        Text="Next Consultation Date"></asp:Label>
                    <asp:Label ID="Lbl_DateOfPrescription" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 174px; top: 281px; position: absolute" 
                        Text="Date of Prescription"></asp:Label>
                    <asp:Label ID="Lbl_TotalCost" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 768px; top: 195px; position: absolute; width: 94px; height: 22px;" 
                        Text="Total Cost"></asp:Label>
                    <asp:Label ID="Lbl_PatientNumber" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 176px; top: 373px; position: absolute" 
                        Text="Patient Number"></asp:Label>
                    <asp:Label ID="Lbl_QuantityToConsume" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 766px; top: 75px; position: absolute; height: 19px" 
                        Text="Quantity To Consume"></asp:Label>
                    <asp:Label ID="Lbl_DoctorName" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 178px; top: 70px; position: absolute" 
                        Text="Doctor Name"></asp:Label>
                    <asp:Label ID="Lbl_Medicineid" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 175px; top: 322px; position: absolute" 
                        Text="Medicine ID"></asp:Label>
                    <asp:Label ID="Lbl_PaymentMode" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 769px; top: 234px; position: absolute; right: 313px;" 
                        Text="Payment Mode"></asp:Label>
                    <asp:Label ID="Lbl_ConsultationFee" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 768px; top: 113px; position: absolute" 
                        Text="Consultation Fee"></asp:Label>
                    <asp:Label ID="Lbl_PrescriptionNumber" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 175px; top: 200px; position: absolute; height: 24px; width: 141px" 
                        Text="Prescription Number"></asp:Label>
                    <asp:Label ID="Lbl_IsBillPaid" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 770px; top: 318px; position: absolute" 
                        Text="Is Bill Paid"></asp:Label>
                    <asp:Label ID="Lbl_ConsultationDate" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 176px; top: 109px; position: absolute" 
                        Text="Consultation Date"></asp:Label>
                    <asp:Label ID="Lbl_MedicineCost" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 768px; top: 154px; position: absolute" 
                        Text="Medicine Cost"></asp:Label>
                    <asp:Label ID="Lcl_Doctorid" runat="server" ForeColor="Black" 
                        style="z-index: 1; left: 176px; top: 242px; position: absolute" 
                        Text="Doctor ID"></asp:Label>
                    <asp:TextBox ID="Txt_CCNumber" runat="server" 
                        style="z-index: 1; left: 950px; top: 279px; position: absolute; width: 125px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_Medicineid" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 327px; top: 324px; position: absolute; width: 124px; right: 820px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_TotalCost" runat="server" 
                        
                        style="z-index: 1; left: 951px; top: 192px; position: absolute; width: 120px;" 
                        ontextchanged="Page_Load"></asp:TextBox>
                    <asp:TextBox ID="Txt_PrescriptionNumber" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 328px; top: 199px; position: absolute; width: 125px; height: 22px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_ConsultationFee" runat="server" 
                        style="z-index: 1; left: 949px; top: 116px; position: absolute; width: 128px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_DateOfPrescription" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 326px; top: 282px; position: absolute; width: 126px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_Doctorid" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 326px; top: 241px; position: absolute; width: 123px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_MedicineCost" runat="server" 
                        style="z-index: 1; left: 951px; top: 156px; position: absolute" 
                        AutoPostBack="True" ontextchanged="Txt_MedicineCost_TextChanged"></asp:TextBox>
                    <asp:TextBox ID="Txt_DoctorName" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 328px; top: 72px; position: absolute; height: 20px; width: 128px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_PatientNumber" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 325px; top: 370px; position: absolute; width: 127px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_NextConsultationDate" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 329px; top: 153px; position: absolute; width: 126px; height: 20px;"></asp:TextBox>
                    <asp:TextBox ID="Txt_QuantityToConsume" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 949px; top: 75px; position: absolute"></asp:TextBox>
                    <asp:TextBox ID="Txt_ConsultationDate" runat="server" ReadOnly="True" 
                        style="z-index: 1; left: 328px; top: 110px; position: absolute; width: 126px; height: 20px;"></asp:TextBox>
                    <asp:DropDownList ID="DDL_IsBillPaid" runat="server" 
                        style="z-index: 1; left: 949px; top: 321px; position: absolute; width: 134px;">
                        <asp:ListItem>--SELECT--</asp:ListItem>
                        <asp:ListItem>YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DDL_PaymentMode" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="DDL_PaymentMode_SelectedIndexChanged" 
                        style="z-index: 1; left: 950px; top: 235px; position: absolute; width: 134px;">
                        <asp:ListItem>--SELECT--</asp:ListItem>
                        <asp:ListItem>Cash</asp:ListItem>
                        <asp:ListItem>Debit/Credit Card</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Btn_GenerateBill" runat="server" BackColor="White" 
                        BorderColor="Blue" BorderWidth="1px" CssClass="ButtonClass" Font-Bold="True" 
                        ForeColor="Blue" onclick="Btn_GenerateBill_Click" 
                        OnClientClick="return validate();" 
                        style="z-index: 1; left: 600px; top: 450px; position: absolute; height: 24px; right: 555px;" 
                        Text="Generate Bill" />
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" 
                        ForeColor="#663300" 
                        style="z-index: 1; left: 543px; top: 369px; position: absolute; width: 226px" 
                        Text="All fields are Mandatory"></asp:Label>
                    &nbsp;&nbsp;
                        
                        <input id="Reset1" type="reset" 
    value="Reset" style="border-color: #0000FF; background-color: #FFFFFF; color: #0000FF; font-weight: bold; height: 27px; width: 55px; z-index: 1; left: 862px; top: 444px; position: absolute;" class="ButtonClass" />
                    </asp:Panel>
            </td>
        </tr>
    </table>

</asp:Content>
