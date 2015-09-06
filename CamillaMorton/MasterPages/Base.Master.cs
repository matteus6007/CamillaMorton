using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CodeBase;

namespace CamillaMorton.MasterPages
{
    public partial class Base : System.Web.UI.MasterPage
    {
        #region Instance Variables

        private string _sectionTitle;
        private string _seoPageTitle;
        private string _seoPageDescription;
        private string _seoPageKeywords;

        #endregion

        #region Properties

        /// <summary>
        /// Section title
        /// </summary>
        public string SectionTitle
        {
            get { return _sectionTitle; }
            set { _sectionTitle = value; }
        }

        /// <summary>
        /// Page SEO title
        /// </summary>
        public string SeoPageTitle
        {
            get
            {
                if (string.IsNullOrEmpty(_seoPageTitle))
                    _seoPageTitle = "Camilla Morton";

                return _seoPageTitle;
            }
            set { _seoPageTitle = value; }
        }

        /// <summary>
        /// Page SEO description
        /// </summary>
        public string SeoPageDescription
        {
            get { return _seoPageDescription; }
            set { _seoPageDescription = value; }
        }

        /// <summary>
        /// Page SEO keywords
        /// </summary>
        public string SeoPageKeywords
        {
            get { return _seoPageKeywords; }
            set { _seoPageKeywords = value; }
        }

        #endregion

        protected void Page_Init(object sender, EventArgs e)
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PageDescription.Content = SeoPageDescription;
            PageKeywords.Content = SeoPageKeywords;
        }
    }
}
