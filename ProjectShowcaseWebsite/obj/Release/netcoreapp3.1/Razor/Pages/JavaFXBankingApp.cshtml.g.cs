#pragma checksum "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Pages\JavaFXBankingApp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f60a907613079db63c73db25a4e9ab6c811d5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectShowcaseWebsite.Pages.Pages_JavaFXBankingApp), @"mvc.1.0.razor-page", @"/Pages/JavaFXBankingApp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f60a907613079db63c73db25a4e9ab6c811d5d", @"/Pages/JavaFXBankingApp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5505f830d56c1af1faf83f7586b884c933c8627e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_JavaFXBankingApp : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Pages\JavaFXBankingApp.cshtml"
  
    ViewData["Title"] = "JavaFXBankingApp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">About this project</h1>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<section id=""main"">
    <p>
        This is a work in progress banking style application using JavaFX with JBDC SQL management.
    </p>
    <p>
        Current UI Features: Menu Bar, a Screen to Add Users, and Light and Dark Modes.
        SQL Management class is under construction currently.
    </p>
    <p>
        The project is in the early stages of development currently. Check back later to see the progress
        of this project!
    </p>

</section>

<section id=""gitlink"">
    <h5>
        <a href=""https://github.com/ryanmueller28/JavaFXBankingApp"">The GitHub repository and source code</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectShowcaseWebsite.Pages.UnrealEngineSciFiRPGModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectShowcaseWebsite.Pages.UnrealEngineSciFiRPGModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectShowcaseWebsite.Pages.UnrealEngineSciFiRPGModel>)PageContext?.ViewData;
        public ProjectShowcaseWebsite.Pages.UnrealEngineSciFiRPGModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591