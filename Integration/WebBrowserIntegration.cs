using Integration.Elements;
using Integration.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace Integration;

public static class WebBrowserIntegration
{
    public static IServiceCollection AddWebBrowser(this IServiceCollection serviceContainer)
    {
        return serviceContainer
            .AddSingleton<IClonableWebElement<IWebElement>, WebElement>()
            .AddSingleton<IWebElementFactory, WebElementFactory>()
            .AddSingleton<IWebBrowser, WebBrowser>();
    }
}
