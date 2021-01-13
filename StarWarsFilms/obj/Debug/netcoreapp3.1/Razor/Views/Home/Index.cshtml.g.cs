#pragma checksum "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eeb52ee0d7e84dc4544f6503b49d3ec5cb8ca3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eeb52ee0d7e84dc4544f6503b49d3ec5cb8ca3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7092ba6701723cb7edf41d1809d0795f860b30f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilmViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
   ViewBag.Title = "Home"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <table class=""table table-striped table-hover"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Title</th>
                <th scope=""col"">Episode</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 13 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
                 foreach (var film in Model?.OrderBy(o => o.EpisodeId))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 18 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
                       Write(Html.ActionLink(film.Title, "Details", new { id = film.EpisodeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 19 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
                       Write(film.EpisodeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Failed to load data.</p>\r\n");
#nullable restore
#line 26 "C:\Users\marek\source\repos\StarWarsFilms\StarWarsFilms\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilmViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
