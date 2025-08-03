using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class ProjectsModel : PageModel
{
    private static List<Project> _cachedProjects;
    public List<Project> Projects { get; set; }
    public Project SelectedProject { get; set; }

    public void OnGet(string selected)
    {
        if (_cachedProjects == null)
        {
            var json = System.IO.File.ReadAllText("wwwroot/data/projects.json");
            _cachedProjects = JsonSerializer.Deserialize<List<Project>>(json);
        }
        Projects = _cachedProjects;
        SelectedProject = Projects.FirstOrDefault(p => p.Name == selected) ?? Projects[0];
    }
}