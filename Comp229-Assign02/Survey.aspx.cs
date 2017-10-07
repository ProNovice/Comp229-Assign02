using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign02
{
    public partial class Survey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SurveyResult.ResetProperties();
            showQuestions(0);
        }

        protected void showQuestions(int process)
        {
            // survey about experience
            aboutExperience.Visible = true;
            aboutPreference.Visible = false;
            aboutUploadingVideo.Visible = false;
            aboutUserInformation.Visible = false;

            //hide changeable questions
            q2_1.Visible = false;
            q2_2.Visible = false;
            q3.Visible = false;
        }


        #region Next buttons

        // survey about preference
        protected void nextButton1_click(object sender, EventArgs e)
        {
            if (rbYouTubeExperience.SelectedValue == "yes")
            {
                //experience
                SurveyResult.SetYouTubeExperience(true);
                //access frequency
                SurveyResult.SetAccessFrequency(sltAccessPrequency.Value);

                aboutExperience.Visible = false;
                aboutPreference.Visible = true;
                aboutUploadingVideo.Visible = false;
                aboutUserInformation.Visible = false;
            }
            else if (rbYouTubeExperience.SelectedValue == "no")
            {
                //experience
                SurveyResult.SetYouTubeExperience(false);
                if (rbHeardYouTube.SelectedValue == "yes")
                    SurveyResult.SetHeardYouTube(true);
                else if (rbHeardYouTube.SelectedValue == "no")
                    SurveyResult.SetHeardYouTube(false);
                //using other sites
                if (rbUsingOtherSite.SelectedValue == "yes")
                    SurveyResult.SetUsingOtherSite(true);
                else if (rbUsingOtherSite.SelectedValue == "no")
                    SurveyResult.SetUsingOtherSite(false);
                //skip questions about experience of YouTube
                aboutExperience.Visible = false;
                aboutPreference.Visible = false;
                aboutUploadingVideo.Visible = false;
                aboutUserInformation.Visible = true;
            }
        }

        // survey about uploading
        protected void nextButton2_click(object sender, EventArgs e)
        {
            //preferredGenres
            List<string> preferredGenres = new List<string>();
            foreach (ListItem item in cklGenresPreference.Items)
                preferredGenres.Add(item.Value);
            SurveyResult.SetPrefferedGenres(preferredGenres);
            //preferred video time

            //evaluating frequency

            //commenting frequency
            

            aboutExperience.Visible = false;
            aboutPreference.Visible = false;
            aboutUploadingVideo.Visible = true;
            aboutUserInformation.Visible = false;
        }

        // user information
        protected void nextButton3_click(object sender, EventArgs e)
        {
            //number of uploading

            //uploading purpose

            //uploading genres

            //number of viewers

            //number of recommendations user got

            //number of subscribers

            aboutExperience.Visible = false;
            aboutPreference.Visible = false;
            aboutUploadingVideo.Visible = false;
            aboutUserInformation.Visible = true;
        }

        // finish survey
        protected void submitButton_click(object sender, EventArgs e)
        {
            //user email

            //opinion about YouTube

            //opinion about the survey

            Response.Redirect("Thanks.aspx");   // same as Server.Transfer("YourPage.aspx");
        }

        #endregion





        #region Exprience

        protected void showQuestions2(object sender, EventArgs e)
        {
            // show the first question
            if (rbYouTubeExperience.SelectedValue == "yes")
            {
                q2_1.Visible = true;
                q2_2.Visible = false;
                q3.Visible = false;
            }
            // show the second question
            else if (rbYouTubeExperience.SelectedValue == "no")
            {
                q2_1.Visible = false;
                q2_2.Visible = true;
                q3.Visible = true;
            }
            // the other situation
            else
            {
                q2_1.Visible = false;
                q2_2.Visible = false;
                q3.Visible = false;
            }
        }


        #endregion

        #region Preference
        #endregion

        #region Uploading video
        #endregion

    }
}