<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PatientHome.aspx.cs" Inherits="HomeMaster.PatientHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="507px">
    <asp:Label ID="Label1" runat="server" 
    style="z-index: 1; left: 394px; top: 204px; position: absolute" Text="WELCOME" 
                Font-Bold="True" Font-Size="XX-Large"></asp:Label>

            <asp:Button ID="Btn_viewhistory" runat="server" 
                style="z-index: 1; left: 650px; top: 630px; position: absolute" 
                Text="View History" onclick="Btn_viewhistory_Click" />
            <asp:Button ID="Btn_SubmitFeedback" runat="server" 
                style="z-index: 1; left: 335px; top: 631px; position: absolute; height: 26px;" 
                Text="Submit Feedback" onclick="Btn_SubmitFeedback_Click" />
           
            <asp:Label ID="Lbl_Prescriptionid" runat="server" 
                style="z-index: 1; left: 240px; top: 296px; position: absolute; right: 888px;" 
                Text="Prescription ID"></asp:Label>
            <asp:TextBox ID="Txt_Prescriptionid" runat="server" 
                style="z-index: 1; left: 473px; top: 306px; position: absolute" 
                 ReadOnly="True"></asp:TextBox>
                <asp:Label ID="Lbl_consultationdate" runat="server" 
                style="z-index: 1; left: 238px; top: 343px; position: absolute; height: 17px;" 
                Text="Consultationdate"></asp:Label>
       
            <asp:TextBox ID="Txt_ConsultationDate" runat="server" 
                style="z-index: 1; left: 472px; top: 346px; position: absolute" 
                ReadOnly="True"></asp:TextBox>
            <asp:Label ID="Lbl_DoctorName" runat="server" 
                style="z-index: 1; left: 239px; top: 390px; position: absolute; height: 19px;" 
                Text="Doctor Name"></asp:Label>
            <asp:TextBox ID="Txt_DoctorName" runat="server" 
                
                style="z-index: 1; left: 471px; top: 387px; position: absolute; right: 696px;" 
                ReadOnly="True"></asp:TextBox>
            <asp:Label ID="Lbl_ProblemDescription" runat="server" 
                style="z-index: 1; left: 239px; top: 443px; position: absolute; height: 22px;" 
                Text="Problem Description"></asp:Label>
            <asp:TextBox ID="Txt_ProblemDescription" runat="server" 
                style="z-index: 1; left: 471px; top: 438px; position: absolute; height: 36px; width: 265px;" 
                TextMode="MultiLine" ReadOnly="True"></asp:TextBox>

            
            <asp:Label ID="Lbl_AdditionalNotes" runat="server" 
                style="z-index: 1; left: 238px; top: 537px; position: absolute" 
                Text="Additional Notes"></asp:Label>
            <asp:TextBox ID="Txt_AdditionalNotes" runat="server" 
                style="z-index: 1; left: 471px; top: 516px; position: absolute; height: 47px; width: 328px;" 
                TextMode="MultiLine"></asp:TextBox>

            <asp:Button ID="Btn_Logout1" runat="server" onclick="Btn_Logout1_Click" 
                style="z-index: 1; left: 1150px; top: 200px; position: absolute" 
            Text="Logout" />

            <asp:Label ID="Lbl_Status" runat="server" ForeColor="Red" 
                
            style="z-index: 1; left: 470px; top: 600px; position: absolute; margin-bottom: 0px"></asp:Label>
        <asp:Label ID="Lbl_State" runat="server" Font-Size="X-Large" ForeColor="Red" 
            style="z-index: 1; left: 375px; top: 405px; position: absolute; height: 84px; width: 337px"></asp:Label>
    </asp:Panel>
</asp:Content>
