namespace Integration.Elements;

public interface IClonableWebElement<TWebElement>
    where TWebElement : IWebElement
{
    TWebElement Create(string xpath);
}
