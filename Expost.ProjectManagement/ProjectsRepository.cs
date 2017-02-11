namespace Expost.ProjectManagement {

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ProjectsRepository {

        private readonly HashSet<Project> _projects = new HashSet<Project>();

        public IEnumerable<Project> All() {
            return _projects;
        }

        public void Add(string projectName) {
            if(_projects.Any(x => string.Equals(x.Name, projectName, StringComparison.OrdinalIgnoreCase))) {
                return;
            }

            var key = Keyify(projectName);

            _projects.Add(new Project(key, projectName));
        }

        private string Keyify(string projectName) {
            for(var attempt = 0; attempt < 13; attempt++) {
                var key = projectName.Substring(0, Math.Min(projectName.Length, 4)).ToUpperInvariant();
                if(!KeyExists(key)) {
                    return key;
                }

                if(projectName.Length == 2 || attempt == 10) {
                    projectName = new Guid().ToString();
                    continue;
                }
                
                projectName = projectName.Remove(1, 1);
            }
            throw new Exception("Could not create key");
        }

        private bool KeyExists(string key) {
            return _projects.Any(x => x.Key == key);
        }

    }

}