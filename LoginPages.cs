public class LoginPage
{
    private IWebDriver _driver;
    private IWebElement UsernameField => _driver.FindElement(By.Id("userName"));
    private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
    private IWebElement LoginButton => _driver.FindElement(By.Id("login")); 

    public LoginPage(IWebDriver driver) { _driver = driver; }

    public void EnterUsername(string username) => UsernameField.SendKeys(username);
    public void EnterPassword(string password) => PasswordField.SendKeys(password);
    public void ClickLogin() => LoginButton.Click();
}