public class BaseTest
{
    protected IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = WebDriverFactory.Create();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://demoqa.com/login");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}