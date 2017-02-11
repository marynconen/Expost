namespace Expost.ProjectManagement {

    internal class Project {

        public string Key { get; }
        public string Name { get; }

        public Project(string key, string name) {
            Key = key;
            Name = name;
        }

    }

}