using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Name = "Prelim A1",
                    Description = "A project created for the IT Elective 2 Prelim A1 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_A1_REOSA_PATRICIA",
                    ImageUrl = "/images/project1.png"
                },

                new Project
                {
                    Id = 2,
                    Name = "Prelim A2",
                    Description = "A project created for the IT Elective 2 Prelim A2 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_A2_REOSA_PATRICIA",
                    ImageUrl = "/images/project2.png"
                },

                new Project
                {
                    Id = 3,
                    Name = "Prelim A3",
                    Description = "A project created for the IT Elective 2 Prelim A3 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_A3_REOSA_PATRICIA",
                    ImageUrl = "/images/project3.png"
                },

                new Project
                {
                    Id = 4,
                    Name = "Prelim Q1",
                    Description = "A project created for the IT Elective 2 Prelim Q1 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/BSIT_31E3_PRELIM_Q1_REOSA_PATRICIA",
                    ImageUrl = "/images/project4.png"
                },

                new Project
                {
                    Id = 5,
                    Name = "Prelim H1",
                    Description = "A project created for the IT Elective 2 Prelim H1 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_H1_REOSA_PATRICIA",
                    ImageUrl = "/images/project5.png"
                },

                new Project
                {
                    Id = 6,
                    Name = "Prelim H2",
                    Description = "A project created for the IT Elective 2 Prelim H2 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_H2_REOSA_PATRICIA",
                    ImageUrl = "/images/project6.png"
                },

                new Project
                {
                    Id = 7,
                    Name = "Prelim Exam",
                    Description = "The Prelim Examination project for IT Elective 2.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_PRELIM_EXAM_REOSA_PATRICIA",
                    ImageUrl = "/images/project7.png"
                },

                new Project
                {
                    Id = 8,
                    Name = "Midterm A1",
                    Description = "A project created for the IT Elective 2 Midterm A1 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_Midterm_A1_Reosa_Patricia",
                    ImageUrl = "/images/project8.png"
                },

                new Project
                {
                    Id = 9,
                    Name = "Midterm Q1",
                    Description = "A project created for the IT Elective 2 Midterm Q1 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_Q1",
                    ImageUrl = "/images/project9.png"
                },

                new Project
                {
                    Id = 10,
                    Name = "Midterm Q2",
                    Description = "A project created for the IT Elective 2 Midterm Q2 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_Q2_Reosa_Patricia",
                    ImageUrl = "/images/project10.png"
                },

                new Project
                {
                    Id = 11,
                    Name = "Midterm Q3",
                    Description = "A project created for the IT Elective 2 Midterm Q3 activity.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_Q3_Reosa_Patricia",
                    ImageUrl = "/images/project11.png"
                },

                new Project
                {
                    Id = 12,
                    Name = "Poketext",
                    Description = "A project created as part of the IT Elective 2 activities.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/daimeryayap26-ship-it/Poketext",
                    ImageUrl = "/images/project12.png"
                },

                new Project
                {
                    Id = 13,
                    Name = "Midterm Exam Set 8",
                    Description = "The Midterm Examination Set 8 project for IT Elective 2.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_EXAM_Set8_Reosa_Patrici",
                    ImageUrl = "/images/project13.png"
                },

                new Project
                {
                    Id = 14,
                    Name = "IT Elective 2 - Prefinal Exam",
                    Description = "The Pre-Final Examination project for IT Elective 2.",
                    Technologies = "C#",
                    GithubUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_BSIT-31E3_PREFINAL_EXAM_Reosa_Patricia",
                    ImageUrl = "/images/project14.png"
                },

                new Project
                {
                    Id = 15,
                    Name = "IT Elective 2 - H1 Student Shipped Work",
                    Description = "Student Shipped Work submitted as part of the IT Elective 2 Pre-Finals activities.",
                    Technologies = "Microsoft Excel",
                    GithubUrl = "https://itmlyceumalabang-my.sharepoint.com/:x:/g/personal/c1816-24_itmlyceumalabang_onmicrosoft_com/IQA3xmnXedf2SZqG1r3rBEn4AZjORvooH7AujrcUjAFGLAI?e=acdV3p",
                    ImageUrl = "/images/project15.png"
                },

                new Project
                {
                    Id = 16,
                    Name = "IT Elective - Pre-Finals Project",
                    Description = "A project created for the IT Elective Pre-Finals.",
                    Technologies = "C#, ASP.NET Core MVC",
                    GithubUrl = "https://github.com/BorromeoRonalyn/IT_ELECTIVE_PRE-FINALS_PROJECT",
                    ImageUrl = "/images/project16.png"
                }
            };
        }

        public IActionResult Index()
        {
            var projects = GetProjects();

            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var projects = GetProjects();

            var project = projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
    }
}