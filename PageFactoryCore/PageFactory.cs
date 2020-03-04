using OpenQA.Selenium;
using System.Reflection;

namespace PageFactoryCore
{
    /// <summary>
    /// Factory for pages
    /// </summary>
    public class PageFactory
    {
        /// <summary>
        /// Instance of IWebDriver
        /// </summary>
        public IWebDriver Driver { get; private set; }

        /// <summary>
        /// Primary constructor
        /// </summary>
        /// <param name="driver">Driver instance</param>
        public PageFactory(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Returns new instance of Page Object Model
        /// </summary>
        /// <typeparam name="T">T has to be IPage type</typeparam>
        /// <returns>New page object model</returns>
        public T GetPage<T>() where T : IPage, new()
        {
            T pageObject = new T();

            var driverProp = typeof(T).GetProperty(nameof(Driver));

            driverProp.SetValue(pageObject, this.Driver);

            return pageObject;
        }
    }
}
