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
            // reset all variables stored in Application
            Application.RemoveAll();
            ShowQuestions(0);

            // Application values; When they are declared in other methods, they are reset in other page.
            SettingApplications();
        }

        protected void ShowQuestions(int process)
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

        protected void SettingApplications()
        {
            //about Experience
            Application["UsingExperience"] = rbYouTubeExperience.SelectedValue;
            Application["AccessFrequency"] = sltAccessFrequency.Value;
            Application["HeardYouTube"] = rbHeardYouTube.SelectedValue;
            Application["UsingOtherSite"] = rbUsingOtherSite.SelectedValue;

            //about Watching Video
            string preferredgGenres = "";
            foreach (ListItem item in cklGenresPreference.Items)
            {
                if(item.Selected)
                    preferredgGenres += item.Value + ", ";
            }
            if (preferredgGenres != "")  // check if there is text
                preferredgGenres = preferredgGenres.Substring(0, preferredgGenres.Length - 2);  // to remove ", "
            else
                preferredgGenres = "none";
            Application["PreferredGenres"] = preferredgGenres;
            Application["PreferredVideoTime"] = sltPreferredVideoTime.Value;
            Application["EvaluatingFrequency"] = rbEvaluatingFrequency.SelectedValue;
            Application["CommentingFrequency"] = rbCommentingFrequency.SelectedValue;

            //about uploading video
            Application["NumberOfUploading"] = sltNumberOfUploading.Value;
            Application["UploadingPurpose"] = txtUnploadingPurpose.Value;
            string uploadingGenres = "";
            foreach (ListItem item in cklUploadingGenres.Items)
            {
                if(item.Selected)
                    uploadingGenres += item.Value + ", ";
            }
            if(uploadingGenres != "")
                uploadingGenres = uploadingGenres.Substring(0, uploadingGenres.Length - 2);
            else
                preferredgGenres = "none";
            Application["UploadingGenres"] = uploadingGenres;
            Application["NumberOfViewers"] = sltNumberOfViewers.Value;
            Application["NumberOfRecommendations"] = sltNumberOfRecommendations.Value;
            Application["NumberOfSubscribers"] = numSubscribers.Value;

            //about user information and opinions
            Application["UserEmail"] = inputEmail.Value;
            Application["YouTubeOpinion"] = txtYouTubeOpinion.Value;
            Application["SurveyOpinion"] = txtSurveyOpinion.Value;

        }
        

        

        #region Next buttons

        // survey about preference
        protected void nextButton1_click(object sender, EventArgs e)
        {
            Application["UsingExperience"] = rbYouTubeExperience.SelectedValue;
            if (rbYouTubeExperience.SelectedIndex == 0)
            {
                aboutExperience.Visible = false;
                aboutPreference.Visible = true;
                aboutUploadingVideo.Visible = false;
                aboutUserInformation.Visible = false;
            }
            else if (rbYouTubeExperience.SelectedIndex == 1)
            {
                //experience
                Application["HeardYouTube"] = rbHeardYouTube.SelectedValue;
                Application["UsingOtherSite"] = rbUsingOtherSite.SelectedValue;
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
            aboutExperience.Visible = false;
            aboutPreference.Visible = false;
            aboutUploadingVideo.Visible = true;
            aboutUserInformation.Visible = false;
        }

        // user information
        protected void nextButton3_click(object sender, EventArgs e)
        {
            aboutExperience.Visible = false;
            aboutPreference.Visible = false;
            aboutUploadingVideo.Visible = false;
            aboutUserInformation.Visible = true;
        }

        // finish survey
        protected void submitButton_click(object sender, EventArgs e)
        {
            Response.Redirect("Thanks.aspx");   // same as Server.Transfer("YourPage.aspx");
        }
        #endregion

        #region condition in Exprience
        protected void ShowQuestion2(object sender, EventArgs e)
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
        
    }
}