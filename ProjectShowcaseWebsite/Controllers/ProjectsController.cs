using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectShowcaseWebsite.Models;
using ProjectShowcaseWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShowcaseWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        public ProjectsController(JsonFileProjectService projectService)
        {
            this.ProjectService = projectService;
        }

        public JsonFileProjectService ProjectService { get; }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return ProjectService.GetProjects();
        }
    }
}
