<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>


<table class="previewTable">
    <tr>
        <td colspan="3">
            <div class="previewHeadingText">Chapter 8: The Freeway Journey</div>
        </td>
    </tr>

    <tr>
        <td>&nbsp</td>
    </tr>


    <tr>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/ch8/p376.jpg")  %>">
        </td>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/ch8/p377.jpg")  %>">
        </td>
        <td>This short chapter summarizes the main themes of the book and ties everything together.
        </td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>
    <tr>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/ch8/p378.jpg")  %>">
        </td>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/ch8/p379.jpg")  %>">
        </td>
        <td></td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>


    <tr>
        <td>&nbsp</td>
    </tr>
    <tr>
        <td align="center">

            <a href="notes">Continue to Notes</a>
        </td>
        <td align="center">
            <a href="<%= Request.ApplicationPath %>">Home</a>
        </td>
        <td></td>
    </tr>
</table>

<p>&nbsp;</p>