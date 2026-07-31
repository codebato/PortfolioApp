namespace PortfolioApp.Models
{
    public class SkillItem
    {
        public string Name { get; set; } = string.Empty;
        public int Percentage { get; set; }
    }

    public class ProjectItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string ProjectUrl { get; set; } = "#";
        public List<string> Tags { get; set; } = new();
    }

    public class SocialLink
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = "#";
        public string IconClass { get; set; } = string.Empty; // Bootstrap Icons class
    }

    public class PortfolioViewModel
    {
        public string Name { get; set;} = "Batıhan Eyyubi";
        public string Title { get; set; } = "BackEnd Developer";
        public string ProfileImageUrl { get; set; } = "/img/profile.jpg";

        public string Email { get; set; } = "Batocode@gmail.com";
        
        public string Location { get; set; } = "İzmir, Türkiye";

        public string AboutText { get; set; } =
            "Backend Developer building reliable and scalable applications with C#, ASP.NET Core, and SQL Server.";
            

        public List<SocialLink> SocialLinks { get; set; } = new()
        {
            new SocialLink { Name = "GitHub",   Url = "https://github.com/codebato", IconClass = "bi-github" },
            new SocialLink { Name = "LinkedIn", Url = "#", IconClass = "bi-linkedin" },
            new SocialLink { Name = "YouTube",  Url = "https://www.youtube.com/@WorkWithBato", IconClass = "bi-youtube" },
            
        };

        public List<SkillItem> SkillsColumn1 { get; set; } = new()
        {
            new SkillItem { Name = "C#",             Percentage = 90 },
            new SkillItem { Name = "ASP.NET Core",   Percentage = 85 },
            new SkillItem { Name = "Entity Framework Core", Percentage = 80 },
            new SkillItem { Name = "SQL Server",     Percentage = 85 },
        };

        public List<SkillItem> SkillsColumn2 { get; set; } = new()
        {
            new SkillItem { Name = "React",       Percentage = 75 },
            new SkillItem { Name = "TypeScript",  Percentage = 70 },
            new SkillItem { Name = "JWT / Auth",  Percentage = 75 },
            new SkillItem { Name = "Git / GitHub",Percentage = 85 },
        };

        public List<ProjectItem> Projects { get; set; } = new()
        {
           /* new ProjectItem
            {
                Title = "BlogApp",
                Description = "ASP.NET Core Web API + React/TypeScript ile geliştirilmiş, JWT kimlik doğrulamalı, rol bazlı admin paneli ve markdown editörü içeren blog platformu.",
                ImageUrl = "/img/project1.jpg",
                Tags = new() { "ASP.NET Core", "React", "TypeScript", "JWT" }
            },
              new ProjectItem
            {
                Title = "FujiRoad Web Panel",
                Description = "Silkroad Online private server için SQL Server tabanlı yönetim ve oyuncu paneli.",
                ImageUrl = "/img/project2.jpg",
                Tags = new() { "SQL Server", "C#", ".NET" }
            },
            new ProjectItem
            {
                Title = "GameStore",
                Description = "Minimal API'ler, EF Core ve React frontend proxy yapılandırması içeren full-stack oyun mağazası uygulaması.",
                ImageUrl = "/img/project3.jpg",
                Tags = new() { "ASP.NET Core", "EF Core", "React" }
            },*/
        };
    }
}
