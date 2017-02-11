namespace Expost.ProjectManagement {

    using System.Collections.Generic;

    internal class ProjectsRepository {

        private readonly HashSet<Project> _projects = new HashSet<Project>();

        public IEnumerable<Project> All() {
            return _projects;
        }

        public void Add(Project project) {
            _projects.Add(project);
        }

    }

}