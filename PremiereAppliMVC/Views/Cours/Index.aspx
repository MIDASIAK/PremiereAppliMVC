<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<PremiereAppliMVC.Models.Formations.Cours>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	GestionCours
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Gestion des Cours</h2>

    <table>
        <tr>
            <%--<th></th>--%>
            <th>
                Identifiant
            </th>
            <th>
                Libelle
            </th>
            <th>
                NombreJours
            </th>
            <th>
                ELearning
            </th>
        </tr>

        <% foreach (var item in Model) { %>
            <tr>
                <%--<td>
                    <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                    <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                    <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
                </td>--%>
                <td>
                    <%= Html.Encode(item.Identifiant) %>
                </td>
                <td>
                    <%= Html.Encode(item.Libelle) %>
                </td>
                <td>
                    <%= Html.Encode(item.NombreJours) %>
                </td>
                <td>
                    <%= Html.Encode(item.ELearning) %>
                </td>
                <td> <%= Html.ActionLink("Stagiaires", "Index", "Stagiaire", new { aIdentifiantCours = item.Identifiant }, null)%>
                </td>
            </tr>
        <% } %>
    </table>
    <%--<p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>--%>
</asp:Content>

