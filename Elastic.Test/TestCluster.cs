using Elastic.Elasticsearch.Xunit;

[assembly: Xunit.TestFrameworkAttribute("Elastic.Elasticsearch.Xunit.Sdk.ElasticTestFramework", "Elastic.Elasticsearch.Xunit")]

namespace Elastic.Test {
    public class TestCluster : XunitClusterBase {
        public TestCluster() : base(new XunitClusterConfiguration("7.8.0")) { }
    }
}
