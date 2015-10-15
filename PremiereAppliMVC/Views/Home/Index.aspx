<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Page de démarrage
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server"> <h2><%= Html.Encode(ViewData["Message"]) %></h2>

    <p>
        Simple démonstration de la création d'une application ASP .NET MVC.
    </p>
</asp:Content>