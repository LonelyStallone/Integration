using Integration.Elements;
using Integration.Impl;

namespace Integration.Site.Elements;

internal class TextBoxElement : WebElementBase, ITextBoxElement, IClonableWebElement<ITextBoxElement>
{
    public TextBoxElement(IWebBrowser webBrowser) : base(webBrowser, "")
    {

    }

    private TextBoxElement(IWebBrowser webBrowser, string xpath) : base(webBrowser, xpath)
    {

    }

    public ITextBoxElement Create(string xpath)
    {
        return new TextBoxElement(_webBrowser, xpath);
    }

    public void SetText(string value)
    {
        Console.WriteLine($"Call {nameof(SetText)} with params {value}");
    }
}
