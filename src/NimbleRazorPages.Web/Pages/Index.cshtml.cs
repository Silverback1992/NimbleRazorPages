using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NimbleRazorPages.Web.Pages;

public class IndexModel : PageModel
{
    private readonly LinkGenerator _linkGenerator;

    public IndexModel(LinkGenerator linkGenerator)
    {
        _linkGenerator = linkGenerator;
    }

    public void OnGet()
    {
        string pageName = "Privacy";

        string? privacyLink = Url.Page(pageName);
        string? privacyLink2 = _linkGenerator.GetPathByPage(HttpContext, pageName);
        string? privacyLink3 = _linkGenerator.GetUriByPage(HttpContext, pageName);
    }
}
