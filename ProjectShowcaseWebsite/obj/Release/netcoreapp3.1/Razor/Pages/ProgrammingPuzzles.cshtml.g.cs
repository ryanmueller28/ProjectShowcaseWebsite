#pragma checksum "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Pages\ProgrammingPuzzles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79dd803b8492640bbf080cc8b144a89d32370e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectShowcaseWebsite.Pages.Pages_ProgrammingPuzzles), @"mvc.1.0.razor-page", @"/Pages/ProgrammingPuzzles.cshtml")]
namespace ProjectShowcaseWebsite.Pages
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
#line 1 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Pages\_ViewImports.cshtml"
using ProjectShowcaseWebsite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79dd803b8492640bbf080cc8b144a89d32370e1b", @"/Pages/ProgrammingPuzzles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5505f830d56c1af1faf83f7586b884c933c8627e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProgrammingPuzzles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Pages\ProgrammingPuzzles.cshtml"
  
    ViewData["Title"] = "Bei-Bei's Programming Puzzles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">About Bei-Bei\'s Programming Puzzles</h1>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<section id=""main"">
    <p>
        <i>Bei-Bei's Programming Puzzles</i> is a game made to teach Python Programming.
        The game is built in a custom engine using <a href=""https://www.sfml-dev.org/"">Simple Fast Multimedia Library (SFML)</a> for the rendering of the game
        and the <a href=""https://docs.python.org/3/c-api/index.html"">Python C API</a> as an embedded Python interpreter, with
        <a href=""https://github.com/nlohmann/json"">Niels Lohmann's JSON for Modern C++</a> to provide lesson and level data.       
        This project was my senior capstone project, I wrote a paper on this project titled
        <a href=""https://drive.google.com/file/d/1qLhCd88UYtjLU0Wi7PpVt_ogtqYuYwOV/view?usp=sharing"">Exploring Embedded Systems Through Educational Game Design.</a>
    </p>   
</section>

<section id=""gitlink"">
    <h5>
        <a href=""https://github.com/ryanmueller28/BeiBei-ProgrammingPuzzles"">The GitHub repository and source code</a>
    </h5>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectShowcaseWebsite.Pages.ProgrammingPuzzlesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectShowcaseWebsite.Pages.ProgrammingPuzzlesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectShowcaseWebsite.Pages.ProgrammingPuzzlesModel>)PageContext?.ViewData;
        public ProjectShowcaseWebsite.Pages.ProgrammingPuzzlesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591