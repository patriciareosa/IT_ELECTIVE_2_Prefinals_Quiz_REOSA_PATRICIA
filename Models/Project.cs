namespace MyPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public string Technologies { get; set; } = "";

        public string GithubUrl { get; set; } = "";

        public string ImageUrl { get; set; } = "";
    }
}