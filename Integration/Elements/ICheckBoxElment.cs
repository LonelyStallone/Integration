namespace Integration.Elements;

public interface ICheckBoxElment : IWebElement
{
    bool IsChecked();

    void SetState(bool state);
}
