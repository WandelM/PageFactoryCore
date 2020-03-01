using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageFactoryCore
{
    /// <summary>
    /// IPage interface, has to be used for every Page Object Model
    /// </summary>
    public interface IPage
    {
        /// <summary>
        /// Instance of IWebDriver
        /// </summary>
        public IWebDriver Driver { get; set; }
    }
}
