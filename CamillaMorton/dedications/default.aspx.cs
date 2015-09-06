using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CamillaMorton.MasterPages;

namespace CamillaMorton.dedications
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
            parent.SectionTitle = "Dedicated to&#8230;";

            //set metadata
            parent.SeoPageDescription = "Camilla Morton's dedications";
            parent.SeoPageKeywords = "Camilla Morton,Camilla,Morton,A Girl For All Seasons,A Year in High Heels,dedications,dedicated to,Steven Robinson";
        }
    }
}
