<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Base.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="camilla_mortons_books_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="Stylesheet" type="text/css" href="/resources/css/content.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="Books">
        <div class="cf">
            <div class="book"><img src="/resources/images/how-to-walk-in-high-heels_sml.jpg" alt="How to Walk in High Heels" title="How to Walk in High Heels" onclick="loadHtmlPopup('/camilla-mortons-books/how-to-walk-in-high-heels.htm')" /></div>
            <div class="book"><img src="/resources/images/a-girl-for-all-seasons_sml.jpg" alt="A Girl for all Seasons" title="A Girl for all Seasons" onclick="loadHtmlPopup('/camilla-mortons-books/a-girl-for-all-seasons.htm')" /></div>
            <div class="book"><img src="/resources/images/a-year-in-high-heels_sml.jpg" alt="A Year in High Heels" title="A Year in High Heels" onclick="loadHtmlPopup('/camilla-mortons-books/a-year-in-high-heels.htm')" /></div>
            <div class="book"><img src="/resources/images/fashion-fairytale-sleeping-beauty_sml.jpg" alt="Christian Lacroix And the Tale of Sleeping Beauty" title="Christian Lacroix And the Tale of Sleeping Beauty" onclick="loadHtmlPopup('/camilla-mortons-books/fashion-fairytale-sleeping-beauty.htm')" /></div>            
            <div class="book"><img src="/resources/images/elves-and-the-shoemaker_sml.jpg" alt="Manolo Blahník's and the Tale of the Elves and the Shoemaker" title="Manolo Blahník's and the Tale of the Elves and the Shoemaker" onclick="loadHtmlPopup('/camilla-mortons-books/elves-and-the-shoemaker.htm')" /></div>
            <div class="book"><img src="/resources/images/the-empress-new-clothes_sml.jpg" alt="Diane von Furstenberg And The Tale of the Empress's New Clothes" title="Diane von Furstenberg And The Tale of the Empress's New Clothes" onclick="loadHtmlPopup('/camilla-mortons-books/the-empress-new-clothes.htm')" /></div>
            <div class="book"><img src="/resources/images/make-life-beautiful_sml.jpg" alt="Make Life Beautiful - Foreword by Diane von Furstenberg" title="Make Life Beautiful - Foreword by Diane von Furstenberg" onclick="loadHtmlPopup('/camilla-mortons-books/make-life-beautiful.htm')" /></div>
        </div>              
    </div>
</asp:Content>

