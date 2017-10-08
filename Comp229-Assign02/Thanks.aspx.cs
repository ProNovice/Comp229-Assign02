using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign02
{
    public partial class Thanks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowResult();
        }

        protected void ShowResult()
        {
            string result = "<h2>Result: </h2><br /><p>";
            try
            {
                // about Experience
                if (Application["UsingExperience"] != null) // check if application value is null
                {
                    //when user has any experience of YouTube
                    if (Application["UsingExperience"].ToString() == "yes")
                    {
                        // about Watching Video
                        result += "</p><p>";
                        result += "<br /><h3>About watching video</h3>";
                        result += "</p><p>";

                        if (Application["PreferredGenres"] != null)
                            result += "<br />-Preferred Genres: " + Application["PreferredGenres"];
                        result += "</p><p>";

                        if (Application["PreferredVideoTime"] != null)
                            result += "<br />-Preferred video time: " + Application["PreferredVideoTime"];
                        result += "</p><p>";

                        if (Application["EvaluatingFrequency"] != null)
                            result += "<br />-Evaluating frequency: " + Application["EvaluatingFrequency"];
                        result += "</p><p>";

                        if (Application["CommentingFrequency"] != null)
                            result += "<br />-Commenting frequency: " + Application["CommentingFrequency"];
                        result += "</p><p>";

                        // about Uploading Video
                        result += "</p><p>";
                        result += "<br /><h3>About uploading video</h3>";
                        result += "</p><p>";
                        if (Application["NumberOfUploading"] != null)
                            result += "<br />-Number of uploading: " + Application["NumberOfUploading"];
                        result += "</p><p>";

                        if (Application["UploadingPurpose"] != null)
                            result += "<br />-Purpose of uploading: " + Application["UploadingPurpose"];
                        result += "</p><p>";

                        if (Application["UploadingGenres"] != null)
                            result += "<br />-Uploading genres: " + Application["UploadingGenres"];
                        result += "</p><p>";

                        if (Application["NumberOfViewers"] != null)
                            result += "<br />-Number of viewers: " + Application["NumberOfViewers"];
                        result += "</p><p>";

                        if (Application["NumberOfRecommendations"] != null)
                            result += "<br />-Number of recommendations: " + Application["NumberOfRecommendations"];
                        result += "</p><p>";

                        if (Application["NumberOfSubscribers"] != null)
                            result += "<br />-Number of subscribers: " + Application["NumberOfSubscribers"];
                        result += "</p><p>";

                    }
                    //when user does not have any experience of YouTube
                    else if (Application["UsingExperience"].ToString() == "no")
                    {
                        if (Application["HeardYouTube"].ToString() == "yes")
                            result += "<br />You never have used YouTube, but heard about it.";
                        else
                            result += "<br />You never have used YouTube, and not heard about it.";
                        result += "</p><p>";
                        if (Application["UsingOtherSite"].ToString() == "yes")
                            result += "<br />And you are using other video web stie.";
                        else
                            result += "<br />And you are not using any other video web site.";
                        result += "</p><p>";
                    }
                }

                // about User information and opinions
                result += "</p><p>";
                result += "<br /><h3>Others</h3>";
                result += "</p><p>";
                if (Application["UserEmail"] != null)
                    result += "<br />-Your E-mail: " + Application["UserEmail"];
                result += "</p><p>";

                if (Application["YouTubeOpinion"].ToString() != "")
                    result += "<br />-Opinion for YouTube: " + Application["YouTubeOpinion"];
                result += "</p><p>";

                if (Application["SurveyOpinion"].ToString() != "")
                    result += "<br />-Opinion for this survey: " + Application["SurveyOpinion"];
                result += "</p>";

                txtResult.InnerHtml = result;
            }
            catch(ArgumentException e)
            {
                txtResult.InnerHtml = e.ToString();
            }
        }
    }
}