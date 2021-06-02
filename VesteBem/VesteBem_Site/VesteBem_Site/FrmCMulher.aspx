<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmCMulher.aspx.cs" Inherits="VesteBem.FrmCMulher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: red; width: 100%;">
        <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3" style="background-color: white">
            <div style="padding: 15px 15px 2500px; font-size: 30px;">
                <br />
                <div style="color: black; font-size: 15px">
                    <asp:Label runat="server" Text="Mulher > "></asp:Label>
                </div>
                <p></p>
               <asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px">
                    <Items>
                        <asp:MenuItem Text="Camisa" Value="Camisa" NavigateUrl="~/Teste.aspx?TipoProduto=Camisa"></asp:MenuItem>
                       
                        <asp:MenuItem Text="T-Shirts" Value="T-Shirts" NavigateUrl="~/ItensMasculino.aspx?TipoProduto=T-Shirts"> </asp:MenuItem>
                        
                        <asp:MenuItem Text="Calças" Value="Calças" NavigateUrl="~/ItensMasculino.aspx?TipoProduto=Calças"></asp:MenuItem>
                       
                        <asp:MenuItem Text="Tenis" Value="Tenis" NavigateUrl="~/ItensMasculino.aspx?TipoProduto=Ténis"></asp:MenuItem>
                    </Items>
                    <StaticMenuStyle HorizontalPadding="60px" VerticalPadding="100px" />
                </asp:Menu>
                </div>

            </div>
        
        <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9" style="background-color: green">
            <div style="padding: 15px 15px 2500px; font-size: 30px;">
                <br />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
