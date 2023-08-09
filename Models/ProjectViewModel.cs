using MVCProjectPractice.Data;

namespace MVCProjectPractice.Models
{
    public class ProjectViewModel
    {
        public IEnumerable<Project> Projects;

        public ProjectViewModel (DataService data)
        {
            Projects = data.GetProjects ();
        }
    }
}
