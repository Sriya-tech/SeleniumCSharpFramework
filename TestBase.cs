using System;

namespace BaseAutomationFramework.Base
{
    public abstract class TestBase
    {
        [OneTimeSetUp]
        public virtual void BeforeAll()
        {
            Base.SetConfig();
            Base.CreateTestResultsDirectory();
            Reporter.initializeReporter();
        }
    }
}