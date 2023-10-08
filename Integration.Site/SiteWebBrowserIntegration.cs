using Integration.Elements;
using Microsoft.Extensions.DependencyInjection;
using Integration.Site.Elements;

namespace Integration.Site;

public static class SiteWebBrowserIntegration
{
    public static IServiceCollection AddSiteWebBrowser(this IServiceCollection serviceContainer)
    {
        return serviceContainer
            .AddWebBrowser()
            .AddSingleton<IClonableWebElement<ICheckBoxElment>, CheckBoxElement>()
            .AddSingleton<IClonableWebElement<ITextBoxElement>, TextBoxElement>();
    }
}
