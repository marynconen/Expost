namespace Expost.Requirements {

    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class PullingCommitInformationFromGitHub {

        [Test]
        public void ShowCommitsFromThisProject() {
            IEnumerable<string> commits = new List<string>();
            Assert.That(() => commits.Count(), Is.GreaterThan(0));
        }

    }
}
