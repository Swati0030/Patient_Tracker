<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PatientHistory.aspx.cs" Inherits="HomeMaster.ViewHistory111" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="748px">
    
            <asp:Button ID="Btn_Logout" runat="server" onclick="Btn_Logout_Click" 
                
                style="z-index: 1; left: 1100px; top: 193px; position: absolute; width: 135px; height: 67px;" 
                Text="Logout" BackColor="#999966" BorderStyle="None" Font-Size="X-Large" />
            <asp:GridView ID="GridView1" runat="server" 
                
                
                
                style="z-index: 1; left: 259px; top: 330px; position: absolute; height: 249px; width: 694px" 
                BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <asp:Label ID="Lbl_consulid" runat="server" 
                style="z-index: 1; left: 306px; top: 621px; position: absolute" 
                Text="Consultation Id"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                style="z-index: 1; left: 457px; top: 618px; position: absolute"  >
            </asp:DropDownList>
            <asp:GridView ID="GridView2" runat="server"             
                
                
                
                
                style="z-index: 1; left: 300px; top: 714px; position: absolute; height: 133px; width: 452px" 
                CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:Button ID="Btn_Search" runat="server" onclick="Btn_Search_Click" 
                style="z-index: 1; left: 624px; top: 618px; position: absolute" 
                Text="Search" />
            <asp:Button ID="Button2" runat="server" BackColor="#999966" Enabled="False" 
                Font-Size="XX-Large" ForeColor="Black" 
                style="z-index: 1; left: 140px; top: 192px; position: absolute; height: 68px; width: 960px" 
                Text="Consultation History" />
            <asp:Button ID="Btn_home" runat="server" 
                
                style="z-index: 1; left: 10px; top: 194px; position: absolute; height: 66px; width: 131px;" 
                Text="Home" BackColor="#999966" BorderStyle="None" Font-Size="X-Large" 
                PostBackUrl="~/PatientHome.aspx" />
        
    </asp:Panel>
</asp:Content>
