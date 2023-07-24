<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Consultationhistory.aspx.cs" Inherits="HomeMaster.Consultationhistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p style="height: 559px; width: 1300px; background-color: #FFFFCC;">
        <asp:Label ID="Lbl_history" runat="server" Font-Bold="True" Font-Italic="True" 
            Font-Size="XX-Large" ForeColor="Red" 
            style="z-index: 1; left: 370px; top: 458px; position: absolute; width: 541px; height: 74px"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" 
            
            style="z-index: 1; left: 199px; top: 364px; position: absolute; height: 270px; width: 898px" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:Button ID="Btn_Consultationhistory" runat="server" onclick="Btn_Logout_Click" 
            
            style="z-index: 1; left: 156px; top: 220px; position: absolute; width: 1013px; height: 59px;" 
            Text="Consultation History" BackColor="#66FFFF" Enabled="False" 
            Font-Size="X-Large" ForeColor="Black" />
        <asp:Button ID="Btn_Home" runat="server" onclick="Btn_Logout_Click" 
            
            style="z-index: 1; left: 11px; top: 219px; position: absolute; width: 145px; height: 60px;" 
            Text="Home" BackColor="#66FFFF" Font-Size="X-Large" 
            PostBackUrl="~/Doctorhome.aspx" />
        <asp:Button ID="Btn_Logout" runat="server" onclick="Btn_Logout_Click" 
            
            style="z-index: 1; left: 1169px; top: 220px; position: absolute; width: 142px; height: 59px;" 
            Text="Logout" BackColor="#66FFFF" Font-Size="X-Large" />
    </p>

</asp:Content>
