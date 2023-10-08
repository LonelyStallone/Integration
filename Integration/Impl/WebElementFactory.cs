using Integration.Elements;

namespace Integration.Impl;

internal class WebElementFactory : IWebElementFactory
{
    private readonly IServiceProvider _serviceProvider;

    public WebElementFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public TWebElement GetWebElement<TWebElement>(string xpath) where TWebElement : IWebElement
    {
        var type = typeof(IClonableWebElement<TWebElement>);
        var clonableElement = _serviceProvider.GetService(type);

        if (clonableElement is IClonableWebElement<TWebElement> elment)
        {
            return elment.Create(xpath);
        }

        throw new NotImplementedException(nameof(type));
    }

    public IWebElement GetWebElement(string xpath)
    {
        return GetWebElement<IWebElement>(xpath);
    }
}
