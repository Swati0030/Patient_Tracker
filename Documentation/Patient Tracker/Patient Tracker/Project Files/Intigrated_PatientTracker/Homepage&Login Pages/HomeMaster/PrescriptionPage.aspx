<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PrescriptionPage.aspx.cs" Inherits="HomeMaster.PrescriptionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Reset1
        {
            z-index: 1;
            left: 778px;
            top: 819px;
            position: absolute;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript" language="javascript">
　
　
    function validate() {
        flag = 1;
        var patient_num = document.getElementById("<%=Txt_PatientNumber.ClientID %>");
        var patient_num_temp = patient_num.value;

        var presc_date = document.getElementById("<%=Txt_PrescriptionDate.ClientID %>");
        var presc_date_temp = presc_date.value;

        var prblm_dscr = document.getElementById("<%=Txt_ProblemDescription.ClientID %>");
        var prblm_dscr_temp = prblm_dscr.value;

        var presc_mdcn = document.getElementById("<%=Txt_PrescribedMedicineName.ClientID %>");
        var presc_mdcn_temp = presc_mdcn.value;

        var altr_mdcn = document.getElementById("<%=Txt_AlternateMedicineName.ClientID %>");
        var altr_mdcn_temp = altr_mdcn.value;

        var adtln_notes = document.getElementById("<%=Txt_AdditionalNotes.ClientID %>");
        var adtln_notes_temp = adtln_notes.value;

        var quant = document.getElementById("<%=Txt_QuantityToPurchase.ClientID %>");
        var quant_temp = quant.value;

        var dosage = document.getElementById("<%=Txt_Dosage.ClientID %>");
        var dosage_temp = dosage.value;

        var duration = document.getElementById("<%=Txt_DurationToContinue.ClientID %>");
        var duration_temp = duration.value;

        var nxtdate = document.getElementById("<%=Txt_NextConsultationDate.ClientID %>");
        var nxtdate_temp = nxtdate.value;

        if (patient_num_temp == "" || presc_date_temp == "" || prblm_dscr_temp == "" || presc_mdcn_temp == "" || altr_mdcn_temp == "" || adtln_notes_temp == "" || quant_temp == "" || dosage_temp == "" || duration_temp == "" || nxtdate_temp=="" ) {
            flag = 1;
            alert("All fields are mandatory");
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
    <asp:Panel ID="Panel1" runat="server" Height="693px">
   
                        <asp:Label ID="Lbl_Dosage" runat="server" 
    style="z-index: 1; left: 755px; top: 655px; position: absolute" Text="Dosage"></asp:Label>
                        <asp:Label ID="Lbl_NextConsultationDate" runat="server" 
                            style="z-index: 1; left: 752px; top: 745px; position: absolute" 
                            Text="Next Consultation Date"></asp:Label>
                        <asp:Label ID="Lbl_QuantityToPurchase" runat="server" 
                            style="z-index: 1; left: 750px; top: 615px; position: absolute" 
                            Text="Quantity To Purchase"></asp:Label>
                        <asp:Label ID="Lbl_ProblemDescription" runat="server" 
                            style="z-index: 1; left: 192px; top: 673px; position: absolute" 
                            Text="Problem Description"></asp:Label>
                        <asp:Label ID="Lbl_AdditionalNotes" runat="server" 
                            style="z-index: 1; left: 753px; top: 549px; position: absolute" 
                            Text="Additional Notes"></asp:Label>
                        <asp:Label ID="Lbl_PrescribedMedicine" runat="server" 
                            style="z-index: 1; left: 189px; top: 743px; position: absolute" 
                            Text="Prescribed Medicine"></asp:Label>
                        <asp:Label ID="Lbl_Prescriptionid" runat="server" 
                            style="z-index: 1; left: 197px; top: 496px; position: absolute" 
                            Text="Prescription ID"></asp:Label>
                        <asp:Label ID="Lbl_PrescriptionDate" runat="server" 
                            style="z-index: 1; left: 191px; top: 610px; position: absolute" 
                            Text="Prescription Date"></asp:Label>
                        <asp:Label ID="Lbl_AlternateMedicineName" runat="server" 
                            style="z-index: 1; left: 754px; top: 496px; position: absolute" 
                            Text="Alternate Medicine Name"></asp:Label>
                        <asp:Label ID="Lbl_Doctorid" runat="server" 
                            style="z-index: 1; left: 754px; top: 348px; position: absolute; height: 19px;" 
                            Text="Doctor ID"></asp:Label>
                        <asp:Label ID="Lbl_PatientNumber" runat="server" 
                            style="z-index: 1; left: 196px; top: 549px; position: absolute" 
                            Text="Patient Number"></asp:Label>
                        <asp:TextBox ID="Txt_ProblemDescription" runat="server" 
                            
                            style="z-index: 1; left: 361px; top: 660px; position: absolute; height: 52px; right: 491px;" 
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:TextBox ID="Txt_DurationToContinue" runat="server" 
                            
                            
                            
                            
                            style="z-index: 1; left: 932px; top: 697px; position: absolute;  width: 87px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_Consultationid" runat="server"                        
                            style="z-index: 1; left: 367px; top: 396px; position: absolute; width: 105px;" 
                            Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox>
                        <asp:TextBox ID="Txt_QuantityToPurchase" runat="server"                             
                            
                            style="z-index: 1; left: 934px; top: 614px; position: absolute; width: 86px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_AlternateMedicineName" runat="server" 
                            
                            
                            style="z-index: 1; left: 935px; top: 491px; position: absolute; width: 82px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_PatientNumber" runat="server" 
                            
                            
                            style="z-index: 1; left: 365px; top: 546px; position: absolute; width:  87px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_NextConsultationDate" runat="server" 
                            
                            
                            
                            style="z-index: 1; left: 932px; top: 740px; position: absolute; width: 84px;" 
                            BackColor="White" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="Txt_AdditionalNotes" runat="server" 
                            
                            style="z-index: 1; left: 934px; top: 543px; position: absolute; height: 49px;" 
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:TextBox ID="Txt_PrescribedMedicineName" runat="server" 
                            style="z-index: 1; left: 357px; top: 742px; position: absolute"></asp:TextBox>
                        <asp:TextBox ID="Txt_Doctorid" runat="server" 
                            
                            style="z-index: 1; left: 935px; top: 349px; position: absolute; width: 77px;" 
                            Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox>
                        <asp:TextBox ID="Txt_Dosage" runat="server" 
                            
                            
                            style="z-index: 1; left: 934px; top: 653px; position: absolute; width: 87px;"></asp:TextBox>
                        <asp:TextBox ID="Txt_Prescriptionid" runat="server" 
                            
                            style="z-index: 1; left: 367px; top: 445px; position: absolute; width: 108px;" 
                            Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox>
                        <asp:TextBox ID="Txt_PrescriptionDate" runat="server" 
                            
                            
                            
                            
                            style="z-index: 1; left: 362px; top: 611px; position: absolute; width: 99px;" 
                            BackColor="White" ForeColor="Black" ReadOnly="True"></asp:TextBox>
                        <asp:Label ID="Lbl_Consultationid" runat="server" 
                            style="z-index: 1; left: 199px; top: 397px; position: absolute; height: 17px;" 
                            Text="Consultation ID"></asp:Label>
                        <asp:Button ID="Btn_Createprescription" runat="server" 
                            style="z-index: 1; left: 333px; top: 822px; position: absolute" 
                            Text="Create Prescription"  OnClientClick="return validate();" 
                            onclick="Btn_Createprescription_Click" />
                        &nbsp;&nbsp;<asp:Label ID="Lbl_Patientid" runat="server" 
                            style="z-index: 1; left: 201px; top: 360px; position: absolute" 
                            Text="Patient ID"></asp:Label>
                        <asp:Button ID="Btn_Home" runat="server" BackColor="#999966" 
                            PostBackUrl="~/Doctorhome.aspx" 
                            style="z-index: 1; left: 11px; top: 194px; position: absolute; width: 126px; height: 67px" 
                            Text="HOME" Font-Bold="True" />
                        <asp:TextBox ID="Txt_Patientid" runat="server" 
                            
                            style="z-index: 1; left: 366px; top: 361px; position: absolute; width: 105px; height: 22px;" 
                            Enabled="False" BackColor="White" ForeColor="Black" ></asp:TextBox>
                        <asp:TextBox ID="Txt_PrescriptionNumber" runat="server" 
                            
                            
                            
                            style="z-index: 1; left: 366px; top: 498px; position: absolute; height: 21px; width: 112px;" 
                            Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox>
                        <asp:Label ID="Lbl_PrescriptionNumber" runat="server" 
                            style="z-index: 1; left: 197px; top: 446px; position: absolute" 
                            Text="Prescription Number"></asp:Label>
                        <asp:Label ID="Lbl_Consultationdate" runat="server" 
                            style="z-index: 1; left: 755px; top: 396px; position: absolute; width: 120px; height: 18px" 
                            Text="Consultation Date"></asp:Label>
                        <asp:TextBox ID="Txt_Consultationdate" runat="server" 
                            
                            style="z-index: 1; left: 933px; top: 395px; position: absolute; width: 83px;" 
                            Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox>
                        <asp:Label ID="Lbl_timeofvisit" runat="server" 
                            style="z-index: 1; left: 756px; top: 442px; position: absolute" 
                            Text="Time of Visit"></asp:Label>
                        <asp:TextBox ID="Txt_timeofvisit" runat="server" 
                            
                            style="z-index: 1; left: 935px; top: 439px; position: absolute; width: 79px;" 
                            Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" BackColor="#999966" Enabled="False" 
                            Font-Size="XX-Large" 
                            style="z-index: 1; left: 135px; top: 194px; position: absolute; height: 67px; width: 975px" 
                            Text="PRESCRIPTION PAGE" ForeColor="Black" />
                            <asp:Button ID="Btn_Logout" runat="server" 
                            style="z-index: 1; left: 1107px; top: 194px; position: absolute; height: 67px; width: 129px;" 
                            Text="Logout" onclick="Btn_Logout_Click" BackColor="#999966" 
                            Font-Bold="True" />
                        <asp:Label ID="Lbl_DurationToContinueMedicine0" runat="server" 
                            style="z-index: 1; left: 753px; top: 698px; position: absolute" 
                            Text="Duration To Continue "></asp:Label>
                        <asp:Calendar ID="Calendar_Prescription" runat="server" BackColor="#FFFFCC" 
                            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" 
                            onselectionchanged="Calendar_Prescription_SelectionChanged" ShowGridLines="True" 
                            
                            
                            
                            
                            style="z-index: 1; left: 502px; top: 607px; position: absolute; height: 48px; width: 114px" 
                            ondayrender="Calendar_Prescription_DayRender">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                                ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                        <asp:Calendar ID="Calendar_NextDate" runat="server" BackColor="#FFFFCC" 
                            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" 
                             ShowGridLines="True" 
                            
                            
                            
                            style="z-index: 1; left: 1063px; top: 684px; position: absolute; height: 119px; width: 139px" 
                            onselectionchanged="Calendar_NextDate_SelectionChanged" 
                            ondayrender="Calendar_NextDate_DayRender">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                                ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                        <asp:ImageButton ID="ImageButton_Prescription" runat="server" ImageUrl="~/download.png" 
                            onclick="ImageButton_Prescription_Click" 
                            
                            
                            
                            style="z-index: 1; left: 472px; top: 608px; position: absolute; height: 22px; width: 28px" />
                        <input id="Reset1" type="reset" 
    value="reset" />
                    
                        <asp:ImageButton ID="ImageButton_NextDate" runat="server" ImageUrl="~/download.png" 
                            onclick="ImageButton_NextDate_Click" 
                            
                            
                            style="z-index: 1; left: 1029px; top: 739px; position: absolute; height: 22px; width: 28px" />
                    
    </asp:Panel>
</asp:Content>
