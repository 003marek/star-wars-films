#pragma checksum "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62d029da021d043df1cd9c349b206a4ef571893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\_ViewImports.cshtml"
using StarWarsFilms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\_ViewImports.cshtml"
using StarWarsFilms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62d029da021d043df1cd9c349b206a4ef571893", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7092ba6701723cb7edf41d1809d0795f860b30f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
   ViewBag.Title = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    label {\r\n        font-weight: 500\r\n    }\r\n</style>\r\n\r\n<div class=\"text-left\">\r\n    <h2>Details:</h2>\r\n    <div class=\"offer-details\">\r\n        <div>\r\n            <label>Title:</label>\r\n            <span>");
#nullable restore
#line 15 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
             Write(Model?.Film?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label>Episode:</label>\r\n            <span>");
#nullable restore
#line 19 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
             Write(Model?.Film?.EpisodeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label>Director:</label>\r\n            <span>");
#nullable restore
#line 23 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
             Write(Model?.Film?.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label>Producer:</label>\r\n            <span>");
#nullable restore
#line 27 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
             Write(Model?.Film?.Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label>Episode crawl:</label>\r\n            <span>");
#nullable restore
#line 31 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
             Write(Model?.Film?.EpisodeCrawl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label>Release date:</label>\r\n            <span>");
#nullable restore
#line 35 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
             Write(Model?.Film?.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 38 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
       Write(Html.ActionLink("Rate", "Rate", new { id = Model.Film?.EpisodeId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <h2>Ratings:</h2>\r\n");
#nullable restore
#line 42 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
         foreach (var rating in Model?.Ratings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 44 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
          Write(rating.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 44 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
                             Write(rating.FilmRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <br />\r\n    ");
#nullable restore
#line 48 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Details.cshtml"
Write(Html.ActionLink("Back", "Index", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
