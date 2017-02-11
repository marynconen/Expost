namespace Expost.Requirements {

    using System.Linq;
    using NUnit.Framework;
    using ProjectManagement;

    [TestFixture]
    public class ManagingProjectActions {

        [Test]
        public void ProjectsShouldBeAvailable() {
            var projectsRepository = new ProjectsRepository();
            projectsRepository.Add(new Project());
            var projects = projectsRepository.All();
            Assert.That(() => projects.Count(), Is.GreaterThan(0));
        }

        [Test]
        public void ProjectsCanBeCreated() {
            var projectToAdd = new Project();
            var projectsRepository = new ProjectsRepository();
            projectsRepository.Add(projectToAdd);
            Assert.That(() => projectsRepository.All().Contains(projectToAdd), Is.True);
        }



    }

}