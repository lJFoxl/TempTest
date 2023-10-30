using Allure.Net.Commons;
using NUnit.Framework;
using System.Reflection;

namespace Allure.Common;
[SetUpFixture]
public class Test
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        var path = Path.Combine(AppContext.BaseDirectory, @"TestPath");
        var fileConfig = new DirectoryInfo(path).GetFiles().FirstOrDefault();
        Assert.IsNotNull(fileConfig);
        Assert.AreEqual(fileConfig.Name, AllureConstants.CONFIG_FILENAME);
        path = Path.Combine(path, AllureConstants.CONFIG_FILENAME);
        Environment.SetEnvironmentVariable(AllureConstants.ALLURE_CONFIG_ENV_VARIABLE, path, EnvironmentVariableTarget.Process);
    }
}
