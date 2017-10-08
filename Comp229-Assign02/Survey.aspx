<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="Comp229_Assign02.Survey" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-background padding-left-100px">
        <h1><strong>Survey</strong></h1>
        <p></p>
        <div>
            <%-- About Experience --%>
            <div id="aboutExperience" runat="server"><h3>Experience of YouTube</h3>
                <div id="q1" class="question" runat="server">
                    <div class="q-question">
                        Q1. Have you used YouTube?
                    </div>
                        <%-- show questions according to the selection --%>
                        <asp:RadioButtonList ID="rbYouTubeExperience" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ShowQuestion2">
                            <%-- To execute an event whenever the value is changed, AutoPostBack have to be true. --%>
                            <asp:ListItem Text="Yes" Value="yes" />
                            <asp:ListItem Text="No" Value="no" />
                        </asp:RadioButtonList>
                    <%-- Required field validator for the question --%>
                    <asp:RequiredFieldValidator id="rfvYouTubeExperience" runat="server" ControlToValidate="rbYouTubeExperience" ErrorMessage="Answer is required" ForeColor="Red" />
                </div>

                <%-- if 'Yes' was selected at the previous question --%>
                <div id="q2_1" class="question" runat="server">
                    <div class="q-question">
                        Q2. How often do you access YouTube in a week?
                    </div>
                    <div class="q-answer">
                        <select id="sltAccessFrequency" runat="server" multiple="false">
                            <option>1-10</option>
                            <option>11-20</option>
                            <option>21-30</option>
                            <option>31-40</option>
                            <option>More than 40</option>
                        </select>
                    </div>
                </div>

                <%-- if 'No' was selected at the previous question --%>
                <div id="q2_2" class="question" runat="server">
                    <div class="q-question">
                        Q2. Have you heard about YouTube?
                    </div>
                    <asp:RadioButtonList ID="rbHeardYouTube" runat="server">
                        <asp:ListItem Text="Yes" Value="yes" />
                        <asp:ListItem Text="No" Value="no" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator id="rfvHeardYouTube" runat="server" ControlToValidate="rbHeardYouTube" ErrorMessage="Answer is required" ForeColor="Red" />
                </div>

                <div id="q3" class="question" runat="server">
                    <div class="q-question">
                        Q3. Do you use other video websites more than YouTube?
                    </div>
                    <asp:RadioButtonList ID="rbUsingOtherSite" runat="server">
                        <asp:ListItem Text="Yes" Value="yes" />
                        <asp:ListItem Text="No" Value="no" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator id="rfvUsingOtherSite" runat="server" ControlToValidate="rbUsingOtherSite" ErrorMessage="Answer is required" ForeColor="Red" />
                </div>
                <%-- if it is yes, just go to Thanks page --%>
                <button id="btnNext1" runat="server" onserverclick="nextButton1_click">Next</button>
            </div>



            <%-- About preference --%>
            <div id="aboutPreference" runat="server"><h3>Content Preference</h3>
                <div id="q4" class="question" runat="server">
                    <div class="q-question">
                        Q4. What genres do you prefer?
                    </div>
                    <asp:CheckBoxList ID="cklGenresPreference" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Movie">Movie</asp:ListItem>
                        <asp:ListItem Value="Drama">Drama</asp:ListItem>
                        <asp:ListItem Value="Comedy">Comedy</asp:ListItem>
                        <asp:ListItem Value="Funny Video">Funny video</asp:ListItem>
                        <asp:ListItem Value="Education">Education</asp:ListItem>
                        <asp:ListItem Value="Game">Game</asp:ListItem>
                        <asp:ListItem Value="Others">Others</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <div id="q5" class="question" runat="server">
                    <div class="q-question">
                        Q5. The preferred video time
                    </div>
                    <select id="sltPreferredVideoTime" runat="server" multiple="false">
                        <option>1-10 minutes</option>
                        <option>11-30 minutes</option>
                        <option>31-60 minutes</option>
                        <option>More than a hour</option>
                        <option>Do not care</option>
                    </select>
                </div>
                <div id="q6" class="question" runat="server">
                    <div class="q-question">
                        Q6. How frequently do you evaluate a video?
                    </div>
                    <asp:RadioButtonList ID="rbEvaluatingFrequency" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Always" Value="always" />
                        <asp:ListItem Text="Often" Value="often" />
                        <asp:ListItem Text="Usally" Value="usually" />
                        <asp:ListItem Text="Rarely" Value="rarely" />
                        <asp:ListItem Text="Never" Value="never" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator id="rfvEvaluatingFrequency" runat="server" ControlToValidate="rbEvaluatingFrequency" ErrorMessage="Answer is required" ForeColor="Red" />
                </div>
                <div id="q7" class="question" runat="server">
                    <div class="q-question">
                        Q7. How frequently do you write comments?
                    </div>
                     <asp:RadioButtonList ID="rbCommentingFrequency" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Always" Value="always" />
                        <asp:ListItem Text="Often" Value="often" />
                        <asp:ListItem Text="Usally" Value="usually" />
                        <asp:ListItem Text="Rarely" Value="rarely" />
                        <asp:ListItem Text="Never" Value="never" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator id="rfvCommentingFrequency" runat="server" ControlToValidate="rbCommentingFrequency" ErrorMessage="Answer is required" ForeColor="Red" />
                </div>
                <button id="btnNext2" runat="server" onserverclick="nextButton2_click">Next</button>
            </div>

            <%-- About uploading video --%>
            <div id="aboutUploadingVideo" runat="server"><h3>Uploading Video</h3>
                <div id="q8" class="question" runat="server">

                    <div class="q-question">
                        Q8. How much video did you upload?
                    </div>
                    <select id="sltNumberOfUploading" runat="server" multiple="false">
                        <option>None</option>
                        <option>1-5</option>
                        <option>6-20</option>
                        <option>20-50</option>
                        <option>51-100</option>
                        <option>More than 100</option>
                    </select>
                </div>
                <div id="q9" class="question" runat="server">
                    
                    <%-- if 'Yes', below quesions follow --%>
                    <div class="q-question">
                        Q9. What purpose did you upload the videos for?
                    </div>
                    <input type="text" id="txtUnploadingPurpose" runat="server" />
                    <asp:RequiredFieldValidator id="rfvUploadingPurpose" runat="server" ControlToValidate="txtUnploadingPurpose" ErrorMessage="Answer is required" ForeColor="Red" />
                </div>
                <div id="q10" class="question" runat="server">
                    <div class="q-question">
                        Q10. What genres do you usually post?
                    </div>
                    <asp:CheckBoxList class="margin-right-20px"  ID="cklUploadingGenres" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Movie">Movie</asp:ListItem>
                        <asp:ListItem Value="Drama">Drama</asp:ListItem>
                        <asp:ListItem Value="Comedy">Comedy</asp:ListItem>
                        <asp:ListItem Value="Funny Video">Funny Video</asp:ListItem>
                        <asp:ListItem Value="Education">Education</asp:ListItem>
                        <asp:ListItem Value="Game">Game</asp:ListItem>
                        <asp:ListItem Value="Others">Others</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <div id="q11" class="question" runat="server">
                    <div class="q-question">
                        Q11. How many views did you get on average?
                    </div>
                    <select id="sltNumberOfViewers" runat="server" multiple="false">
                        <option>less than 100</option>
                        <option>less than 1000</option>
                        <option>less than 10000</option>
                        <option>more than 10000</option>
                    </select>

                </div>
                <div id="q12" class="question" runat="server">
                    <div class="q-question">
                        Q12. How many recommendations do you get on average?</div>
                    <select id="sltNumberOfRecommendations" runat="server" multiple="false">
                        <option>less than 100</option>
                        <option>less than 1000</option>
                        <option>less than 10000</option>
                        <option>more than 10000</option>
                    </select>
                </div>
                <div id="q13" class="question" runat="server">
                    <div class="q-question">
                        Q13. How many subscribers do you have on average?
                    </div>
                    <input type="number" id="numSubscribers" runat="server" min="0" onchange="" />
                    <asp:RequiredFieldValidator id="rfvNumSubscribers" runat="server" ControlToValidate="numSubscribers" ErrorMessage="Please put the number of subscribers" ForeColor="Red" />
                    <br />
                </div>
                <button id="btnNext3" runat="server" onserverclick="nextButton3_click">Next</button>
            </div>
            <%-- information of user --%>
            <div id="aboutUserInformation" runat="server">
                <h3>User information and opinions</h3>
                <div id="qUserEmail" class="question">
                    <div class="q-question">
                        What is your E-mail?
                    </div>
                    <input type="email" id="inputEmail" runat="server" />
                    <asp:RequiredFieldValidator id="rfvUserEmail" runat="server" ControlToValidate="inputEmail" ErrorMessage="Please put the your E-mail address." ForeColor="Red" />
                </div>
                
                <div id="qOpnionAboutYouTube" class="question">
                    <div class="q-question">
                        Please write any opinion about YouTube.
                    </div>
                    <textarea id="txtYouTubeOpinion" class="textarea-opinion" runat="server" placeholder="Plase put your opinion"></textarea>
                </div>
                <div id="qOpinionAboutSurvey" class="question">
                    <div class="q-question">
                        Please write your opinion about this survey.
                    </div>
                    <textarea id="txtSurveyOpinion" class="textarea-opinion" runat="server" placeholder="Plase put your opinion"></textarea>
                </div>
                <p>                    
                    <asp:Button runat="server" Text="submit" ID="submitButton" OnClick="submitButton_click" />
                </p>           
            </div>
            <asp:Label ID="lbMessage" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
