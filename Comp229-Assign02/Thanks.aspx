<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Thanks.aspx.cs" Inherits="Comp229_Assign02.Thanks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-background">
        <div class="thanks-message">            
            <p>Thank you for participating our survey!</p>
        </div>
        <div id="txtResult" class="result" runat="server">
        </div>
        <h2 class="padding-left-100px"><a href="https://www.youtube.com/">Go to YouTube</a></h2>
    </div>
</asp:Content>
