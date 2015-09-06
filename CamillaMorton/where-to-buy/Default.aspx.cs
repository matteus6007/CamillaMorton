using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CamillaMorton.MasterPages;
using CodeBase;

public partial class where_to_buy_Default : System.Web.UI.Page
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
        parent.SectionTitle = "Where to buy&#8230;";

        //set metadata
        parent.SeoPageDescription = "Where to buy Camilla Morton's books";
        parent.SeoPageKeywords = "Camilla Morton,Camilla,Morton,How to Walk in High Heels,Girl for all seasons,A year in high heels,high heels,fashion,style,buy books";
    }
}
