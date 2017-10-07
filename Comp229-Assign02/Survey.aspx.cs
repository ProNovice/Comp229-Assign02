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
                aboutExperience.Visible = false;
                aboutPreference.Visible = true;
                aboutUploadingVideo.Visible = false;
                aboutUserInformation.Visible = false;
            }
            else if (rbYouTubeExperience.SelectedValue == "no")
            {
                Response.Redirect("Thanks.aspx");   // same as Server.Transfer("YourPage.aspx");
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
            Response.Redirect("Thanks.aspx");
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