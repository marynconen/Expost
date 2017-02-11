namespace Expost.GitHubConnectivity {

    using System.Collections.Generic;

    internal class GitHubConnection {

        public IEnumerable<Commit> GetCommits() {
            yield return new Commit("");
        }

    }
}