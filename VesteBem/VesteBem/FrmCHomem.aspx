<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmCHomem.aspx.cs" Inherits="VesteBem.FrmCHomem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div style="background-color: red; width: 100%;">
		<div class="col-xs-3 col-sm-3 col-md-3 col-lg-3" style="background-color: yellow; height:100%">
			<div style="padding: 15px 15px 0px; font-size: 30px;">
				<br />
				<div style="color: black; font-size: 15px">
					<asp:Label runat="server" Text="Homem > "></asp:Label></div>
				<br />
				<div style="margin: -20px 10px 0px 10px; background-color: green; font-size: 20px;">
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Calças</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Pijama</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Sapatos</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Camisola Interior</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Camisa</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Camisola Exterior</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Roupa Interior</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click">Casacos</asp:linkbutton><br /><p />
					<asp:linkbutton runat="server" OnClick="lblLink_Click" >Acessórios</asp:linkbutton><br /><p />
				</div>
				</div>
		</div>
		<div class="col-xs-9 col-sm-9 col-md-9 col-lg-9" style="background-color: green">
			<div style="padding: 15px 15px 2500px; font-size: 30px;">
				<br />
				<br />
				<br />
				<p><b>This example demonstrates how to hide a navbar when the user starts to scroll the page.</b></p>
				<p>Scroll down this frame to see the effect!</p>
				<p>Scroll up to show the navbar.</p>
				<p>Lorem ipsum dolor dummy text sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
				<p>Lorem ipsum dolor dummy text sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
			</div>
		</div>
	</div>
</asp:Content>
