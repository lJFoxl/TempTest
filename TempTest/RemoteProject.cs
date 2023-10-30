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
public class RemoteProject: Test
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
    public void RemoteTest()
    {
        Assert.True(true);
    }
}
