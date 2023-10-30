using Allure.Net.Commons;
using Allure.Net.Commons.Configuration;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace TempTest;
[AllureNUnit]
[TestFixture]
public class Class1
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        
        var path = Path.Combine(AppContext.BaseDirectory,@"TestPath");
        var fileConfig = new DirectoryInfo(path).GetFiles().FirstOrDefault();
        Assert.IsNotNull(fileConfig);
        Assert.AreEqual(fileConfig.Name, AllureConstants.CONFIG_FILENAME);
        Environment.SetEnvironmentVariable(AllureConstants.ALLURE_CONFIG_ENV_VARIABLE, path,EnvironmentVariableTarget.Process);
        var actual = AllureLifecycle.Instance.AllureConfiguration.Directory;
        Assert.Multiple(() =>
        {
            Assert.AreEqual("newDirectory", actual);
            Assert.AreNotEqual("default", actual);
        });

    }
    [SetUp]
    public void SetUp()
    {

    }
    [Test]
    public void Test()
    {
        Assert.True(true);
    }
}