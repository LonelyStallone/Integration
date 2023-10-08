using Integration.Elements;
using Integration.Impl;

namespace Integration.Site.Elements;

internal class CheckBoxElement : WebElementBase, ICheckBoxElment, IClonableWebElement<ICheckBoxElment>
{
    public CheckBoxElement(IWebBrowser webBrowser) : base(webBrowser, "")
    {

    }

    private CheckBoxElement(IWebBrowser webBrowser, string xpath) : base(webBrowser, xpath)
    {

    }

    public ICheckBoxElment Create(string xpath)
    {
        return new CheckBoxElement(_webBrowser, xpath);
    }

    public bool IsChecked()
    {
        Console.WriteLine($"Call {nameof(IsChecked)}");
        return true;
    }

    public void SetState(bool state)
    {
        Console.WriteLine($"Call {nameof(SetState)} with params {state}");
    }
}
