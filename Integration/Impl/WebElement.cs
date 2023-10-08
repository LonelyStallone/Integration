using Integration.Elements;

namespace Integration.Impl;

internal class WebElement : WebElementBase, IClonableWebElement<IWebElement>
{
    public WebElement(IWebBrowser webBrowser) : base(webBrowser, "")
    {
    }

    private WebElement(IWebBrowser webBrowser, string xpath) : base(webBrowser, xpath)
    {
    }

    public IWebElement Create(string xpath)
    {
        return new WebElement(_webBrowser, xpath);
    }
}
