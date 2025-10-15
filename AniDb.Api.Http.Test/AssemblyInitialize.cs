using System.Reflection;
using Microsoft.Extensions.Configuration;

[assembly: Parallelize(Scope = ExecutionScope.ClassLevel)] // optional
namespace AniDb.Api.Http.Test
{
    [TestClass]
    public static class AssemblyInitialize
    {
        [AssemblyInitialize]
        public static void Setup(TestContext context)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets(Assembly.GetExecutingAssembly()) // loads secrets.json
                .Build();

            // Make secrets available to tests
            TestSecrets.Username = config["TestRunParameters:Username"];
            TestSecrets.Password = config["TestRunParameters:Password"];
        }
    }
}