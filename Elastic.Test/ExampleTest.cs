using Elastic.Elasticsearch.Xunit;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;

namespace Elastic.Test {
    public class ExampleTest {

        public ExampleTest(TestCluster cluster) {
            this.Client = cluster.GetOrAddClient(c => {
                var nodes = cluster.NodesUris();
                var connectionPool = new StaticConnectionPool(nodes);
                var settings = new ConnectionSettings(connectionPool).EnableDebugMode();
                return new ElasticClient(settings);
            });
        }

        private ElasticClient Client { get; }

        [I]
        public void SomeTest() {
            var rootNodeInfo = this.Client.RootNodeInfo();

            rootNodeInfo.Name.Should().NotBeNullOrEmpty();
        }
    }
}
