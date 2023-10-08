using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Integration.Site;
using System;
using Integration;
using Integration.Elements;

namespace IntegrationTests.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateCheckBoxElement_NotNull()
        {

            IServiceCollection services = new ServiceCollection();

            services.AddSiteWebBrowser();

            var serviceProvider = services.BuildServiceProvider();

            var browser = serviceProvider.GetRequiredService<IWebBrowser>();

            var checkBox = browser.GetWebElement<ICheckBoxElment>("xpath");

            Assert.IsNotNull(checkBox);
            Assert.IsTrue(checkBox is ICheckBoxElment);
            Assert.IsTrue(checkBox.IsChecked());

            checkBox.ToString();
        }
    }
}