﻿namespace Expost.Requirements {

    using System.Linq;
    using GitHubConnectivity;
    using NUnit.Framework;

    [TestFixture]
    public class PullingCommitInformationFromGitHub {

        [Test]
        public void SomeCommitsShouldBeReturned() {
            var gitHubConnection = new GitHubConnection();
            var commits = gitHubConnection.GetCommits();
            Assert.That(() => commits.Count(), Is.GreaterThan(0));
        }

        [Test]
        public void CommitShouldContainMessage() {
            var gitHubConnection = new GitHubConnection();
            var commit = gitHubConnection.GetCommits().First();
            Assert.That(string.IsNullOrWhiteSpace(commit.Message), Is.False);
        }
        
    }

}
