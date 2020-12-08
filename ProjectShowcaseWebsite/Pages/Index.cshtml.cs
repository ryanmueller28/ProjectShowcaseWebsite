using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectShowcaseWebsite.Models;
using ProjectShowcaseWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShowcaseWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProjectService ProjectService;

        public IEnumerable<Project> Projects{ get; private set; }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProjectService projectService)
        {
            _logger = logger;
            ProjectService = projectService;
        }

        public void OnGet()
        {
            Projects = ProjectService.GetProjects();
        }
    }
}
