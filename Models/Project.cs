public class Project
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public List<string> TechStack { get; set; }
    public List<ProjectLink> Links { get; set; }
    public string YouTubeUrl { get; set; }
    public string ExtraImageUrl { get; set; }
}

public class ProjectLink
{
    public string Label { get; set; }
    public string Url { get; set; }
}