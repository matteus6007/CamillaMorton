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
        private List<BreadcrumbItem> _breadcrumbTrail = new List<BreadcrumbItem>();

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

        /// <summary>
        /// Breadcrumb trail
        /// </summary>
        public List<BreadcrumbItem> BreadcrumbTrail
        {
            get { return _breadcrumbTrail; }
            set { _breadcrumbTrail = value; }
        }

        #endregion

        protected void Page_Init(object sender, EventArgs e)
        {
            BreadcrumbItems.ItemDataBound += new RepeaterItemEventHandler(BreadcrumbItems_ItemDataBound);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BreadcrumbItems.DataSource = BreadcrumbTrail;
            BreadcrumbItems.DataBind();

            PageDescription.Content = SeoPageDescription;
            PageKeywords.Content = SeoPageKeywords;
        }

        #region Events

        void BreadcrumbItems_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            BreadcrumbItem item = (BreadcrumbItem)e.Item.DataItem;
            HtmlGenericControl placeholder = (HtmlGenericControl)e.Item.FindControl("Item");

            //add item break
            placeholder.Controls.Add(new LiteralControl("&gt; "));

            //add link or text
            if (!string.IsNullOrEmpty(item.Url))
            {
                HyperLink link = new HyperLink();
                link.Text = item.Text;
                link.NavigateUrl = item.Url;
                link.ToolTip = item.SeoTitle;

                placeholder.Controls.Add(link);
            }
            else
            {
                HtmlGenericControl span = new HtmlGenericControl("span");
                span.InnerText = item.Text;

                placeholder.Controls.Add(span);
            }
        }

        #endregion
    }
}
