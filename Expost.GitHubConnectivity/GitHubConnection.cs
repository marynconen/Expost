namespace Expost.GitHubConnectivity {

    using System;
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using RestSharp;

    internal class GitHubConnection {

        public IEnumerable<Commit> GetCommits() {

            var restClient = new RestClient("https://api.github.com/repos/marynconen/expost/commits");
            var get = restClient.Get(new RestRequest(Method.GET));
            if(get.StatusCode != HttpStatusCode.OK) throw new Exception("Could not retrieve commits");
            var jArray = JsonConvert.DeserializeObject<JArray>(get.Content);
            foreach(var jToken in jArray) {
                yield return new Commit(jToken["commit"]["message"].Value<string>());
            }
        }

    }
}