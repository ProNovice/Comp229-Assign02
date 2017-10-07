using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp229_Assign02
{
    public class SurveyResult
    {
        public static bool youTubeExperience { get; private set; }
        public static string accessFrequency { get; private set; }
        public static bool heardYouTube { get; private set; }
        public static bool usingOtherSite { get; private set; }
        public static List<string> preferredGenres { get; private set; }
        public static string preferredVideoTime { get; private set; }
        public static string evaluatingFrequency { get; private set; }
        public static string commentingFrequency { get; private set; }
        public static string numberOfUploading { get; private set; }
        public static string uploadingPurpose { get; private set; }
        public static List<string> uploadingGenres { get; private set; }
        public static string numberOfViewrs { get; private set; }
        public static string numberOfRecommendations { get; private set; }
        public static string numberOfSubscribers { get; private set; }
        public static string userEmail { get; private set; }
        public static string youTubeOpinion { get; private set; }
        public static string surveyOpinion { get; private set; }


        public static void ResetProperties()
        {
            youTubeExperience = new bool();
            accessFrequency = "";
            heardYouTube = new bool();
            usingOtherSite = new bool();
            preferredGenres = new List<string>();
            preferredVideoTime = "";
            evaluatingFrequency = "";
            commentingFrequency = "";
            numberOfUploading = "";
            uploadingPurpose = "";
            uploadingGenres = new List<string>();
            numberOfViewrs = "";
            numberOfRecommendations = "";
            numberOfSubscribers = "";
            userEmail = "";
            youTubeOpinion = "";
            surveyOpinion = "";
        }

        #region Setters
        public static void SetYouTubeExperience(bool experience)
        {
            youTubeExperience = experience;
        }
        public static void SetAccessFrequency(string frequency)
        {
            accessFrequency = frequency;
        }
        public static void SetHeardYouTube(bool experience)
        {
            heardYouTube = experience;
        }
        public static void SetUsingOtherSite(bool usingOther)
        {
            usingOtherSite = usingOther;
        }
        public static void SetPrefferedGenres(List<string> genres)
        {
            preferredGenres = genres;
        }
        public static void SetEvaluatingFrequency(string frequency)
        {
            evaluatingFrequency = frequency;
        }
        public static void SetCommentingFrequency(string frequency)
        {
            commentingFrequency = frequency;
        }
        public static void SetNumberOfUploading(string range)
        {
            numberOfUploading = range;
        }
        public static void SetUploadingPurpose(string purpose)
        {
            uploadingPurpose = purpose;
        }
        public static void SetUploadingGenres(List<string> genres)
        {
            uploadingGenres = genres;
        }
        public static void SetNumberOfViewrs(string range)
        {
            numberOfViewrs = range;
        }
        public static void SetNumberOfRecommendations(string range)
        {
            numberOfRecommendations = range;
        }
        public static void SetNumberOfSubscribers(string range)
        {
            numberOfSubscribers = range;
        }
        public static void SetUserEmail(string email)
        {
            userEmail = email;
        }
        public static void SetYouTubeOpinion(string opinion)
        {
            youTubeOpinion = opinion;
        }
        public static void SetSurveyOpinion(string opinion)
        {
            surveyOpinion = opinion;
        }

        #endregion

        public static string GetSurveyResult()
        {
            string result = "";
            result += "<p>Result:</p>";
            result += "<br /><p>About using YouTube</p>";
            if (youTubeExperience)
            {                
                //watching YouTube
                result += "<p>Access Frequency: " + accessFrequency + "</p>";
                result += "<p>Prefferd Genres: ";
                string prfGenres = "";
                foreach (string s in preferredGenres)
                {
                    prfGenres += s + ", ";
                }
                prfGenres = prfGenres.Substring(0, prfGenres.Length - 2);   // to remove last two letters ", "
                result += prfGenres + "</p>";

                result += "<p>Preffered Video time: " + preferredVideoTime + "</p>";
                result += "<p>Evaluating frequency: " + evaluatingFrequency + "</p>";
                result += "<p>Commenting frequency: " + commentingFrequency + "</p>";
                //uploading vidoe
                result += "<br /><br /><p>About uploading video</p>";
                result += "<p>Number of uploading video: " + numberOfUploading + "</p>";
                result += "<p>Uploading purpose: " + uploadingPurpose + "</p>";
                result += "<p>Uploading genres: ";
                string upldGenres = "";
                foreach (string s in preferredGenres)
                {
                    upldGenres += s + ", ";
                }
                upldGenres = prfGenres.Substring(0, prfGenres.Length - 2);
                result += upldGenres + "</p>";
                result += "<p>Average number of viewers: " + numberOfViewrs + "</p>";
                result += "<p>Average number of recommendations: " + numberOfRecommendations + "</p>";
                result += "<p>Average number of Subscrivers: " + numberOfSubscribers + "</p>";
            }
            else
            {
                if (heardYouTube)
                    result += "<p>Never have used, but heard about YouTube</p>";
                else
                    result += "<p>Never have used, and have not heard about YouTube</p>";
                if (usingOtherSite)
                    result += "<p>Using other vidoe web sites" + "</p>";
                else
                    result += "<p>Do not use any video website.</p>";
            }

            //respondent information and opinions
            result += "<br /><br /><p>Respondent email: " + userEmail + "</p>";
            result += "<p>Opinions about YouTube: <br />" + youTubeOpinion + "</p>";
            result += "<p>Opinions about this survey: <br />" + surveyOpinion + "</p>";
            //thanks message
            result += "<br /><br />";
            result += "<p>Thank you for your participating our survey.</p>";
            return result;
        }

    }
}