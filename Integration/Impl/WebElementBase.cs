using Integration.Elements;

namespace Integration.Impl;

public class WebElementBase : IWebElement
{
    protected IWebBrowser _webBrowser { get; set; }

    public WebElementBase(IWebBrowser webBrowser, string xpath)
    {
        _webBrowser = webBrowser;
    }
}
