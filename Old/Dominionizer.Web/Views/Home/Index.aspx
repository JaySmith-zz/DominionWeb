<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Dominionizer.Web.Models.IndexViewModel>" %>
<%@ Import Namespace="Dominionizer.Web.Core" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Dominionizer: The Dominion Deck Generator
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" width="400" border="0">
        <% if (!Model.IsValid())
           {%>
        <tr>
            <td style="color: Red; font-style: bold;">
                <%= Model.ValidationErrorMessage %>
            </td>
        </tr>
        <%
           }%>
        <tr>
            <td width="400">
                <% using (Html.BeginForm("Index", "Home", FormMethod.Post))
                   {%>
                <b>Sets</b>
                <%= Html.ValidationSummary(true) %>
                <div class="editor-label">
                    <%= Html.CheckBoxFor(model => model.Parameters.Base)%>
                    <%= Html.LabelFor(model => model.Parameters.Base)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.Base)%>
                </div>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.Alchemy)%>
                    <%= Html.LabelFor(model => model.Parameters.Alchemy)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.Alchemy)%>
                </div>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.Intrigue)%>
                    <%= Html.LabelFor(model => model.Parameters.Intrigue)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.Intrigue)%>
                </div>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.Prosperity)%>
                    <%= Html.LabelFor(model => model.Parameters.Prosperity)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.Prosperity)%>
                </div>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.Seaside)%>
                    <%= Html.LabelFor(model => model.Parameters.Seaside)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.Seaside)%>
                </div>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.Promo)%>
                    <%= Html.LabelFor(model => model.Parameters.Promo)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.Promo)%>
                </div>
                <b>Options</b>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.RequireTwoToFiveCostCards)%>
                    <%= Html.LabelFor(model => model.Parameters.RequireTwoToFiveCostCards)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.RequireTwoToFiveCostCards)%>
                </div>
                <div class="editor-field">
                    <%= Html.CheckBoxFor(model => model.Parameters.RequireReactionToAttack)%>
                    <%= Html.LabelFor(model => model.Parameters.RequireReactionToAttack)%>
                    <%= Html.ValidationMessageFor(model => model.Parameters.RequireReactionToAttack)%>
                </div>
                <b>Sort Options</b>
                <div class="editor-field">
                    <%= Html.LabelFor(model => model.Parameters.SortBy)%>
                    <%= Html.RadioButtonFor(model => model.Parameters.SortBy, "Cost")%>
                    Cost
                    <%= Html.RadioButtonFor(model => model.Parameters.SortBy, "Name")%>
                    Name
                    <%= Html.RadioButtonFor(model => model.Parameters.SortBy, "Set")%>
                    Set
                </div>
                <p>
                    <input type="submit" value="Generate" />
                </p>
                <% } %>
            </td>
        </tr>
        <tr>
            <td width="400" valign="top">
                <% if (Model.Cards != null)
                   {%>
                <table border="0">
                    <%
                       foreach (var item in Model.Cards)
                       { %>
                            <tr id="<%= item.Id %>" class="cardTableTr">
                                <td valign="bottom">
                                    <%
                                    var typeImageName = "action.png";

                                    if (item.Type == CardType.Action) typeImageName = "action.png";
                                    else if (item.Type == CardType.Attack) typeImageName = "attack.png";
                                    else if (item.Type == CardType.Duration) typeImageName = "duration.png";
                                    else if (item.Type == CardType.Reaction) typeImageName = "reaction.png";
                                    else if (item.Type == CardType.Treasure) typeImageName = "coin.png";
                                    else if (item.Type == CardType.Victory) typeImageName = "shield.png";

                                    var typeImageUrlBase = "/Content/Images/" + typeImageName;
                               
                                    %>
                                    <img src="<%= typeImageUrlBase %>" width="15px" height="15px" alt="<%= item.Type %>" />
                                </td>
                                <td valign="middle" style="width: 150px">
                                    <%=item.Name%>
                                </td>
                                <td valign="middle">
                                    <%=item.Cost%>
                                    <img src="/Content/Images/coin.png" width="15px" height="15px" alt="<%= item.Cost %>" />
                                </td>
                                <td valign="middle">
                                    <%=item.PotionCost%>
                                    <img src="/Content/Images/alchemy.png" width="15px" height="15px" alt="<%= item.PotionCost %>" />
                                </td>
                                <td valign="middle" align="right">
                                    <%
                                    var setImageName = "dominion.png";

                                    if (item.Set == CardSet.Alchemy) setImageName = "alchemy.png";
                                    if (item.Set == CardSet.Intrigue) setImageName = "intrigue.png";
                                    if (item.Set == CardSet.Intrigue) setImageName = "intrigue.png";
                                    if (item.Set == CardSet.Prosperity) setImageName = "prosperity.png";
                                    if (item.Set == CardSet.Seaside) setImageName = "seaside.png";
                                    if (item.Set == CardSet.Base) setImageName = "dominion.png";

                                    var setImageUrlBase = "/Content/Images/" + setImageName;
                               
                                    %>
                                    <img src="<%= setImageUrlBase %>" width="15px" height="15px" alt="<%= item.Set %>" />
                                </td>
                            </tr>
                    <%
                        }%>
                </table>
                <%
                   } %>
            </td>
        </>
    </table>
    <div id="disqus_thread">
    </div>
    <script type="text/javascript">
        $(".cardTableTr")
            .click(function () {

                $(this).toggleClass("hightlight-row", this.clicked);
            });
    </script>

    <script type="text/javascript">
        /* * * CONFIGURATION VARIABLES: EDIT BEFORE PASTING INTO YOUR WEBPAGE * * */
        var disqus_shortname = 'dominiongamegen'; // required: replace example with your forum shortname

        // The following are highly recommended additional parameters. Remove the slashes in front to use.
        // var disqus_identifier = 'unique_dynamic_id_1234';
        // var disqus_url = 'http://example.com/permalink-to-page.html';

        /* * * DON'T EDIT BELOW THIS LINE * * */
        (function () {
            var dsq = document.createElement('script'); dsq.type = 'text/javascript'; dsq.async = true;
            dsq.src = 'http://' + disqus_shortname + '.disqus.com/embed.js';
            (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(dsq);
        })();
    </script>
    <noscript>
        Please enable JavaScript to view the <a href="http://disqus.com/?ref_noscript">comments
            powered by Disqus.</a></noscript>
    <a href="http://disqus.com" class="dsq-brlink">blog comments powered by <span class="logo-disqus">
        Disqus</span></a>
</asp:Content>
