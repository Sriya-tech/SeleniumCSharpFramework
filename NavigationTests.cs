[Test]
public void NavigateToBooksPage()
{
    driver.FindElement(By.LinkText("Book Store")).Click();
    Assert.That(driver.Url, Is.EqualTo("https://demoqa.com/books"));
}