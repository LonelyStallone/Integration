using Integration.Elements;

namespace Integration.Impl;

internal class WebBrowser : IWebBrowser
{
    private IWebElementFactory _webElementFactory;

    public WebBrowser(IWebElementFactory webElementFactory)
    {
        _webElementFactory = webElementFactory;
    }

    public TWebElement GetWebElement<TWebElement>(string xpath)
        where TWebElement : IWebElement
    {
        return _webElementFactory.GetWebElement<TWebElement>(xpath);
    }

    public IWebElement GetWebElement(string xpath)
    {
        return _webElementFactory.GetWebElement(xpath);
    }
}
