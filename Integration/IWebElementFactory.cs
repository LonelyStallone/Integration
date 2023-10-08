using Integration.Elements;

namespace Integration;

public interface IWebElementFactory
{
    TWebElement GetWebElement<TWebElement>(string xpath)
        where TWebElement : IWebElement;

    IWebElement GetWebElement(string xpath);
}
