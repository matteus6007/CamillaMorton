using System;
using System.Web.UI;
using CamillaMorton.MasterPages;
using CodeBase;

namespace CamillaMorton.camilla_morton_biography
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
            parent.SectionTitle = "Biography";

            //set metadata
            parent.SeoPageDescription = "Camilla Morton's biography";
            parent.SeoPageKeywords = "Camilla Morton,Camilla,Morton,biography,biog";
        }
    }
}
