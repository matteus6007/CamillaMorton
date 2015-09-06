using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CamillaMorton.MasterPages;
using CodeBase;

namespace CamillaMorton.about
{
    public partial class _default : System.Web.UI.Page
    {
        #region Static Variables

        private Base parent;

        #endregion

        protected void Page_Init(object sender, EventArgs e)
        {
            parent = (Base)Page.Master;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set section title
            parent.SectionTitle = "About me";

            //set metadata
            parent.SeoPageDescription = "All about Camilla Morton";
            parent.SeoPageKeywords = "Camilla Morton,Camilla,Morton,about me";
        }
    }
}
