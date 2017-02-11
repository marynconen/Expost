namespace Expost.Requirements {

    using System.Linq;
    using NUnit.Framework;
    using ProjectManagement;

    [TestFixture]
    public class ManagingProjectActions {

        [Test]
        public void ProjectsShouldBeAvailable() {
            var projectsRepository = new ProjectsRepository();
            projectsRepository.Add("Expost");
            var projects = projectsRepository.All();
            Assert.That(() => projects.Count(), Is.GreaterThan(0));
        }

        [Test]
        public void ProjectsCanBeCreated() {
            var projectsRepository = new ProjectsRepository();
            projectsRepository.Add("Expost");
            Assert.That(() => projectsRepository.All().Count(), Is.EqualTo(1));
        }

        [Test]
        public void ProjectsConvertNamesToKey() {
            const string name = "EXPO";
            Assert.That(() => new Project(name, "Expost").Key, Is.EqualTo(name));
        }

        [Test]
        public void CannotCreateProjectTwiceRegardlessCasing() {
            var projectsRepository = new ProjectsRepository();
            projectsRepository.Add("Expost");
            projectsRepository.Add("eXpost");
            Assert.That(() => projectsRepository.All().Count(), Is.EqualTo(1));
        }

        [Test]
        public void CannotAddKeyTwice() {
            var projectsRepository = new ProjectsRepository();
            projectsRepository.Add("Expost1");
            projectsRepository.Add("Expost2");
            var distinctKeys = projectsRepository.All().Select(x => x.Key).Distinct();
            Assert.That(() => distinctKeys.Count(), Is.EqualTo(2));
        }

    }

}