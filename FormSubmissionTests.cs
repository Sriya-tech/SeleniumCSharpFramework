[Test]
public void RegistrationFormValidation()
{
    // Navigate to registration page and perform form submission
    driver.Navigate().GoToUrl("https://demoqa.com/register");
    var registrationPage = new RegistrationPage(driver);
    registrationPage.EnterUsername("newUser");
    registrationPage.EnterPassword("password123");
    registrationPage.Submit();

    // Validate success message or error
    var successMessage = driver.FindElement(By.CssSelector(".success-message")).Text;
    Assert.That(successMessage, Is.EqualTo("Registration successful!"));
}