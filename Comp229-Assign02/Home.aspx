<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Comp229_Assign02.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="hero-image">
        <%-- image source: http://getreelcinemas.com/chilton-cinema/ --%>
        <div class="row home-body">
            <div class="col-md-4">
                <p>
                    <img class="home-logo" src="Assets/logo_image_vertical_black_background.PNG" />
                </p>
            </div>
            <div class="col-md-6">
                <p>Survey about user experience of YouTube</p>
                <p id="disclaimer" class="home-disclaimer" runat="server">
                    We, <strong>User Survey</strong> is a question investigation agent.
                    We are conducting research on user experience by order of YouTube.
                    We'd love to hear from you about watching and uploading videos on YouTube.
                    This will help us make statistics to improve user experience of YouTube.
                    The survey should only take 5 minutes, and your responses are completely anonymous.
                    All questions require answers.
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
