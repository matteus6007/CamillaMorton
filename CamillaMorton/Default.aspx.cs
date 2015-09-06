using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CamillaMorton.MasterPages;

public partial class _Default : System.Web.UI.Page
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
        parent.SectionTitle = "Home";

        //set metadata
        parent.SeoPageDescription = "Camilla Morton fashion tips";
        parent.SeoPageKeywords = "Camilla Morton,Camilla,Morton,How to Walk in High Heels,Girl for all seasons,A year in high heels,high heels,fashion,style,author,writer";
    }
}
