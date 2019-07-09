using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        [BeforeScenario]
        public void Initialize()
        {
            _driver = new ChromeDriver((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
