using System.Collections.Generic;
using System.Text;

namespace AhmedOumezzine.FlashMessage;


public static class MessageHelpers
{
    

    public static string BuildFormErrorString(List<string> modelStateErrors)
    {
        if (modelStateErrors is null || modelStateErrors.Count == 0)
            return string.Empty;

        StringBuilder sbString = new();

        sbString.Append("<ul>");

        foreach (var error in modelStateErrors)
            sbString.Append($"<li>{error}</li>");        

        sbString.Append("</ul>");

        string htmlString = sbString.ToString();

        if (htmlString.Contains("<li>"))
            return htmlString;
        else
            return string.Empty;
    }
}
