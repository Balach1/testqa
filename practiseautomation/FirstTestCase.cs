using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace practiseautomation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IWebDriver driver = new FirefoxDriver();
			driver.Url = "http://www.demoqa.com";
		}
	}
}
