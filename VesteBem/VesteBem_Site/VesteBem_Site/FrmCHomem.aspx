<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmCHomem.aspx.cs" Inherits="VesteBem.FrmCHomem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
        <asp:DropDownList ID="DDListClasse" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CategoriaClasse" DataValueField="CategoriaClasse">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdConnectionString %>" SelectCommand="SELECT DISTINCT [CategoriaClasse] FROM [tbl_Produtos]"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="IdProduto" DataSourceID="SqlDataSource2" Width="758px">
            
            <Columns>
                <asp:BoundField DataField="IdProduto" HeaderText="IdProduto" InsertVisible="False" ReadOnly="True" SortExpression="IdProduto" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="NomedaEmpresa" HeaderText="NomedaEmpresa" SortExpression="NomedaEmpresa" />
                <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                <asp:ImageField DataImageUrlField="Icon" HeaderText="Imagem do Produto">
                    <ItemStyle Height="100px" />
                </asp:ImageField>
            </Columns>
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
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:bdConnectionString %>" SelectCommand="SELECT [IdProduto], [Valor], [Nome], [NomedaEmpresa], [Icon] FROM [tbl_Produtos] WHERE ([CategoriaClasse] = @CategoriaClasse)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DDListClasse" Name="CategoriaClasse" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    </p>
    <p>
        &nbsp;</p>
   
</asp:Content>
