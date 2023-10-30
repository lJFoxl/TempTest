using Allure.Net.Commons;
using NUnit.Allure.Core;
using NUnit.Framework;
namespace TempTest;
[AllureNUnit]
[TestFixture]
[Parallelizable(ParallelScope.All)]
public class SingleProject : SingleProjectTest
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {


    }
    [SetUp]
    public void SetUp()
    {

    }
    [Test]
    public void SingleTest()
    {
        TestContext.WriteLine($"OneTimeSetUp был вызван в SetUpFixture:{count}");
        Assert.AreEqual(1,count, "OneTimeSetUp был вызван более 1 раза");
    }
}
[SetUpFixture]
public class SingleProjectTest
{
    public static int count { get; set; } = 0;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        count++;
        //var path = Path.Combine(AppContext.BaseDirectory, @"TestPath");
        //var fileConfig = new DirectoryInfo(path).GetFiles().FirstOrDefault();
        //Assert.IsNotNull(fileConfig);
        //Assert.AreEqual(fileConfig.Name, AllureConstants.CONFIG_FILENAME);
        //path = Path.Combine(path, AllureConstants.CONFIG_FILENAME);
        //Environment.SetEnvironmentVariable(AllureConstants.ALLURE_CONFIG_ENV_VARIABLE, path, EnvironmentVariableTarget.Process);
    }
}