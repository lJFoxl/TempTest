using System.Reflection;
using Allure.Common;
using Allure.Net.Commons;
using Allure.Net.Commons.Configuration;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace TempTest;

[AllureNUnit]
[TestFixture]
[Parallelizable(ParallelScope.All)]
public class Class1:Test
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
       
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
