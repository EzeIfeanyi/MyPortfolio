namespace MVCProjectPractice.Data
{
    public class DataService
    {
        public List<Project> GetProjects()
        {
            return new List<Project> 
            {
                new Project
                {
                    Name = "E-Commerce App",
                    Description = "An implementation of an online store, using sessions to record products picked by the user. It is built ASP.NET Core MVC, SQLServer and EntityFramework Core.",
                    ImageUrl = "/assets/e-commerce.png",
                    ProjectUrl = "https://github.com/EzeIfeanyi/ShopperSampleApp"
                },
                new Project
                {
                    Name = "Flight Booking",
                    Description = "Using AngularJS as the frontend client, users can search for available flights, consuming ASP.NET Core REST API.",
                    ImageUrl = "/assets/flight.png",
                    ProjectUrl = "https://github.com/EzeIfeanyi/FlightSearch"
                },
                new Project
                {
                    Name = "Todo App",
                    Description = "A single page application (SPA) using AngularJS, ASP.NET Core API, Dapper and SQLServer. It implements CRUD operations to get and update the todos in the database.",
                    ImageUrl = "/assets/todoApp.png",
                    ProjectUrl = "https://github.com/EzeIfeanyi/todoAppNG"
                },
                new Project
                {
                    Name = "Calculator App",
                    Description = "This is a simple Desktop calculator implemented with .NET MAUI and C#",
                    ImageUrl = "/assets/calculator.png",
                    ProjectUrl = "https://github.com/EzeIfeanyi/Simple_Calculator"
                }
            };
        }
    }
}
