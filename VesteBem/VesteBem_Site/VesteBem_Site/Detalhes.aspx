<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="VesteBem_Site.Detalhes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
.detailsImage{
width: 400px;
height: 400px;
margin-right: 20px;
}
         .auto-style1 {
             margin-left: 13px;
         }
     </style>
    
   
        <div>
            
            <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            <br />
            <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblItem" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblPreco" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="btncomprar" runat="server" Text="Comprar" OnClick="btncomprar_Click" />
            <asp:TextBox ID="txtquant" runat="server" CssClass="auto-style1" TextMode="Number"></asp:TextBox>
            <br />
        </div>

       <!-- src="roupa%20HM/cl2.jfif">-->




</asp:Content>
