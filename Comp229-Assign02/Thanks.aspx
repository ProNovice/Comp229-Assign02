<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Thanks.aspx.cs" Inherits="Comp229_Assign02.Thanks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-background">
        <div class="thanks-message">            
            <p>Thank you for participating our survey!</p>
            <p>Have a nice day!</p>
            <img src="Assets/smiling_image.png" class="thanks-image" />
            <p><a href="https://www.youtube.com/">Go to YouTube</a></p>
        </div>
        <div id="txtResult" class="result" runat="server">
            

        </div>
    </div>
</asp:Content>
