#pragma checksum "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9292a8db15641b79dc10da6e2aed751cb82ba6"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectShowcaseWebsite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
using ProjectShowcaseWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
using ProjectShowcaseWebsite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProjectList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
     foreach (var project in ProjectService.GetProjects())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                                             project.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 12 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                    project.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-footer");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "small");
            __builder.AddAttribute(23, "class", "text-muted");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                  (e => SelectProject(project.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "data-toggle", "modal");
            __builder.AddAttribute(28, "data-target", "#projectModal");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddMarkupContent(30, "\r\n                    About this project\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 23 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"


    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal fade");
            __builder.AddAttribute(38, "id", "projectModal");
            __builder.AddAttribute(39, "tabindex", "-1");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.AddAttribute(41, "aria-labelledby", "projectTitle");
            __builder.AddAttribute(42, "aria-hidden", "true");
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(46, "role", "document");
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 30 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
         if (selectedProject != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-content");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal-header");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "h5");
            __builder.AddAttribute(56, "class", "modal-title");
            __builder.AddAttribute(57, "id", "projectTitle");
            __builder.AddContent(58, 
#nullable restore
#line 34 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                                           selectedProject.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.AddMarkupContent(60, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-body");
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "card");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card-img");
            __builder.AddAttribute(70, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 41 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                                                         selectedProject.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "card-body");
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "p");
            __builder.AddAttribute(77, "class", "card-text");
            __builder.AddContent(78, 
#nullable restore
#line 44 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                              selectedProject.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 45 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                         if (selectedProject.URL != "")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                            ");
            __builder.OpenElement(81, "span");
            __builder.AddMarkupContent(82, "\r\n                                ");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "href", 
#nullable restore
#line 48 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                          selectedProject.URL

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(85, "Check this project out for yourself!");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 50 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "modal-footer");
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 55 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                 if (selectedProject.GitURL != "")
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                    ");
            __builder.OpenElement(96, "span");
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "href", 
#nullable restore
#line 58 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                                  selectedProject.GitURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(100, "Link to the Git Repository for this project");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 60 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 63 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\Dev\ProjectShowcase\ProjectShowcaseWebsite\Components\ProjectList.razor"
 
    Project selectedProject;
    string selectedProjectId;

    void SelectProject(string projectId)
    {
        selectedProjectId = projectId;
        selectedProject = ProjectService.GetProjects().First(x => x.Id == projectId);
    }

    string gitURL;
    string mainURL;

    void GetProjectGitLink()
    {
        if (selectedProject.GitURL == null)
        {
            System.Console.WriteLine($"The GitHub link for project {selectedProject.Id}: {selectedProject.ProjectName} is not available yet.");
        }
        else
        {
            gitURL = selectedProject.GitURL;
            System.Console.WriteLine($"The GitHub link for project {selectedProject.Id}: {selectedProject.ProjectName} is {gitURL}");
        }
    }

    string GetProjectMainPage()
    {
        if (selectedProject.URL == null)
        {
            System.Console.WriteLine($"That page for proejct {selectedProject.Id}: {selectedProject.ProjectName} is under construction");
        }
        else
        {
            mainURL = selectedProject.URL;
        }

        return mainURL;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProjectService ProjectService { get; set; }
    }
}
#pragma warning restore 1591
