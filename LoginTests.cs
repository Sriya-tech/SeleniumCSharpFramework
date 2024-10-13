[TestFixture]
public class LoginTests : BaseTest
{
    [Test]
    public void ValidLogin()
    {
        var loginPage = new LoginPage(driver);
        loginPage.EnterUsername("validUser");
        loginPage.EnterPassword("validPassword");
        loginPage.ClickLogin();

        // Assert successful login
        Assert.That(driver.Url, Is.EqualTo("https://demoqa.com/profile"));
    }

    [Test]
    public void InvalidLogin()
    {
        var loginPage = new LoginPage(driver);
        loginPage.EnterUsername("invalidUser");
        loginPage.EnterPassword("invalidPassword");
        loginPage.ClickLogin();

        // Assert error message
        var errorMessage = driver.FindElement(By.Id("name")).Text;
        Assert.That(errorMessage, Is.EqualTo("Invalid username or password!"));
    }

    [Test]
    public void Logout()
    {
        // Perform login steps
        var loginPage = new LoginPage(driver);
        loginPage.EnterUsername("validUser");
        loginPage.EnterPassword("validPassword");
        loginPage.ClickLogin();

        // Perform logout
        driver.FindElement(By.Id("submit")).Click();
        Assert.That(driver.Url, Is.EqualTo("https://demoqa.com/login"));
    }
}