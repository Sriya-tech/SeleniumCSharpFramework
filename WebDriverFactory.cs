public static class WebDriverFactory
{
    public static IWebDriver Create()
    {
        return new ChromeDriver();
    }
}