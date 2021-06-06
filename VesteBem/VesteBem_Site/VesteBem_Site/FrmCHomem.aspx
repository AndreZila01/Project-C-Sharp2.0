<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmCHomem.aspx.cs" Inherits="VesteBem.FrmCHomem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div style="background-color: red; width: 100%;">
		<div class="col-xs-4 col-sm-3 col-md-3 col-lg-3" style="background-color: white">
			<div style="padding: 15px 15px 2500px; font-size: 30px;">
				<br />
				<div style="color: black; font-size: 15px">
					<asp:Label runat="server" Text="Homem > "></asp:Label>
				</div>
				<p></p>
				<asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px">
                    <Items>
                        <asp:MenuItem Text="Camisa" Value="Camisa" NavigateUrl="~/Teste.aspx?TipoProduto=Camisa"></asp:MenuItem>
                       
                        <asp:MenuItem Text="Casaco" Value="Casaco" NavigateUrl="~/Teste.aspx?TipoProduto=Camisa"></asp:MenuItem>

                        <asp:MenuItem Text="T-Shirts" Value="T-Shirts" NavigateUrl="~/ItensMasculino.aspx?TipoProduto=T-Shirts"> </asp:MenuItem>
                        
                        <asp:MenuItem Text="Calças" Value="Calças" NavigateUrl="~/ItensMasculino.aspx?TipoProduto=Calças"></asp:MenuItem>
                       
                        <asp:MenuItem Text="Tenis" Value="Tenis" NavigateUrl="~/ItensMasculino.aspx?TipoProduto=Ténis"></asp:MenuItem>
                    </Items>
                    <StaticMenuStyle HorizontalPadding="60px" VerticalPadding="100px" />
                </asp:Menu>

				</div>

			</div>
		</div>
		<div class="col-xs-8 col-sm-8 col-md-8 col-lg-8" style="background-color: green;">
			<div class="col-xs-1 col-sm-2 col-md-1 col-lg-1" style="padding-bottom: 2500px"></div>
			<div id="Imagems" runat="server" class="col-xs-10 col-sm-8 col-md-10 col-lg-10" style="margin-top: 15px; padding-bottom: 2500px; padding-left: 0px; padding-right: 0px; background-color: aliceblue; font-size: 30px;"></div>
			<div class="col-xs-1 col-sm-2 col-md-1 col-lg-1" style="padding-bottom: 2500px"></div>
			<br />
			<br />
			<br />
		</div>
	
	<%--<div style="background-color: red; width: 100%;">
        <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3" style="background-color: white">
            <div style="padding: 15px 15px 2500px; font-size: 30px;">
                <br />
                <div style="color: black; font-size: 15px">
                    <asp:Label runat="server" Text="Homem > "></asp:Label>
                </div>
                <p></p>
                <div style="margin: -5px 10px 0px 10px; background-color: ghostwhite; font-size: 20px;">
                    <asp:LinkButton runat="server" Text="Calças" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Pijama" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Sapatos" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Camisola Interior" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Camisa" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Camisola Exterior" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Roupa Interior" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Casacos" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                    <p></p>
                    <asp:LinkButton runat="server" Text="Acessórios" OnClick="lblLink_Click"></asp:LinkButton><br />
                    <p />
                </div>
            </div>
        </div>
        <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9" style="background-color: green">
            <div style="padding: 15px 15px 2500px; font-size: 30px;">
                <br />
                <br />
                <br />
            </div>
        </div>
    </div>--%>

	<p>
		<br />
	</p>
	<p>
		&nbsp;
	</p>

</asp:Content>
