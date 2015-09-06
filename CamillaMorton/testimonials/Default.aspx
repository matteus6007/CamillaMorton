<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Base.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CamillaMorton.testimonials.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="/resources/css/content.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Books">
        <div class="cf">
            <div class="book"><img src="/resources/images/how-to-walk-in-high-heels_sml.jpg" alt="How to Walk in High Heels" title="How to Walk in High Heels" onclick="loadHtmlPopup('/testimonials/how-to-walk-in-high-heels.htm')" /></div>
            <div class="book"><img src="/resources/images/a-girl-for-all-seasons_sml.jpg" alt="A Girl for all Seasons" title="A Girl for all Seasons" onclick="loadHtmlPopup('/testimonials/a-girl-for-all-seasons.htm')" /></div>
            <div class="book"><img src="/resources/images/a-year-in-high-heels_sml.jpg" alt="A Year in High Heels" title="A Year in High Heels" onclick="loadHtmlPopup('/testimonials/a-year-in-high-heels.htm')" /></div>
            <div class="book"><img src="/resources/images/fashion-fairytale-sleeping-beauty_sml.jpg" alt="Christian Lacroix And the Tale of Sleeping Beauty" title="Christian Lacroix And the Tale of Sleeping Beauty" onclick="loadHtmlPopup('/testimonials/fashion-fairytale-sleeping-beauty.htm')" /></div>            
            <div class="book"><img src="/resources/images/elves-and-the-shoemaker_sml.jpg" alt="Manolo Blahník's and the Tale of the Elves and the Shoemaker" title="Manolo Blahník's and the Tale of the Elves and the Shoemaker" onclick="loadHtmlPopup('/testimonials/elves-and-the-shoemaker.htm')" /></div>
        </div>
    </div>
</asp:Content>
