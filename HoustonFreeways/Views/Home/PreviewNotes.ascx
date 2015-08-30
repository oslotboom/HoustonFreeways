<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>


<table class="previewTable">
    <tr>
        <td colspan="3">
            <div class="previewHeadingText">Index and Notes</div>
        </td>
    </tr>

    <tr>
        <td>&nbsp</td>
    </tr>


    <tr>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/notes/p380.jpg")  %>">
        </td>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/notes/p381.jpg")  %>">
        </td>
        <td></td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>

    <tr>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/notes/p382.jpg")  %>">
        </td>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/notes/p383.jpg")  %>">
        </td>
        <td></td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>
    <tr>

        <td colspan="3">Text pages not shown
        </td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>

    <tr>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/notes/p398.jpg")  %>">
        </td>
        <td>
            <img src="<%=Url.Content("~/images/desktop/preview/notes/p397.jpg")  %>">
        </td>
        <td></td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>

    <tr>

        <td colspan="3">Text pages not shown
        </td>
    </tr>
    <tr>
        <td>&nbsp</td>
    </tr>
    <tr>
        <td align="center"></td>
        <td align="center">
            <a href="<%= Request.ApplicationPath %>">Home</a>
        </td>
        <td></td>
    </tr>
</table>

<p>&nbsp;</p>
