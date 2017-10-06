<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Comp229_Assign02.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="hero-image">
        <%-- image source: http://getreelcinemas.com/chilton-cinema/ --%>
        <div class="row home-body">
            <div class="col-md-4">
                <img class="home-logo" src="Assets/youtube_logo.png" />
            </div>
            <div class="col-md-6">
                <p>User Survey about using YouTube</p>
                <p id="disclaimer" class="home-disclaimer" runat="server">
                    We're conducting research on user experience of YouTube. We'd love to hear from you about watching and uploading videos, and advertisements in YouTube.
                    This will help us make statistics of user experience of YouTube. The survey should only take 5 minutes, and your responses are completely anonymous.
                    Questions marked with an asterisk (*) are required.
                    If you have any questions about the survey, please email us: mchoi34@my.centennialcollege.ca
                    We really appreciate your input!
                </p>
                <a href="survey.aspx">
                    <p class="">Go to survey!</p>
                </a>
            </div>
        </div>
    </div>
</asp:Content>
