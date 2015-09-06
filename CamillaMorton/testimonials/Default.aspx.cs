using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CamillaMorton.MasterPages;
using CodeBase;

namespace CamillaMorton.testimonials
{
    public partial class Default : System.Web.UI.Page
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
            parent.SectionTitle = "Praise";

            //set metadata
            parent.SeoPageDescription = "Camilla Morton's reviews";
            parent.SeoPageKeywords = "Camilla Morton,Camilla,Morton,press cuttings,what the experts say,ratings,praise,testimonials,reviews,praise for";

            //set breadcrumb
            parent.BreadcrumbTrail.Add(new BreadcrumbItem("Praise"));
        }
    }
}
