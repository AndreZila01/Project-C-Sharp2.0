<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmCMulher.aspx.cs" Inherits="VesteBem.FrmCMulher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: red; width: 100%;">
        <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3" style="background-color: white">
            <div style="padding: 15px 15px 2500px; font-size: 30px;">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                <br />
                <div style="color: black; font-size: 15px">
                    <asp:Label runat="server" Text="Mulher > "></asp:Label>
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
    </div>
</asp:Content>
