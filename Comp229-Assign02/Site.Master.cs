using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign02
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Determine the filename for this page
            // source: https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-getting-started/master-pages/specifying-the-title-meta-tags-and-other-html-headers-in-the-master-page-cs
            string pageName = System.IO.Path.GetFileNameWithoutExtension(Request.PhysicalPath);
            Page.Title = "User Survey :: " + pageName;

        }
    }
}