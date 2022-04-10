using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class WebDriverExtensions
{
  public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
  {
    if (timeoutInSeconds > 0)
    {
      var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
      return wait.Until(drv => drv.FindElement(by));
    }
    return driver.FindElement(by);
  }

}
namespace FishAuction
{
  class Controller
  {
    IWebDriver _driver;
    WebDriverWait wait;
    Actions builder;
    public Controller()
    {
      _driver = new ChromeDriver();
      wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
      builder = new Actions(_driver);
    }
    /**
* I dont want to copy paste the same code over and over again so im wrapping it in a helper
*/
    private void inputText(string xPath, string text)
    { 
        //https://www.selenium.dev/documentation/webdriver/waits/
        wait.Until(e => e.FindElement(By.XPath(xPath), 2000)).SendKeys(text);
      
    }
    public void findFish(string fishName)
    {
      _driver.Navigate().GoToUrl("https://www.google.com/");
      inputText("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input", fishName + " site:www.seriouslyfish.com");
      click("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]");
      IList<IWebElement> textfields = _driver.FindElements(By.TagName("a"));
      IList<string> s = new List<string>();
      for (int i = 0; i < textfields.Count; i++)
      {
        if (textfields[i].Text.Contains("https://www.seriouslyfish.com"))
        {
          textfields[i].Click();
          break;
        }
      }
      
    }

    /**
 * I dont want to copy paste the same code over and over again so im wrapping it in a helpee
 */
    private void click(string xPath)
    {
      //https://www.selenium.dev/documentation/webdriver/waits/
      wait.Until(e => e.FindElement(By.XPath(xPath))).Click();
    }

    private void clickByClass(string className)
    {
      //https://www.selenium.dev/documentation/webdriver/waits/
      wait.Until(e => e.FindElement(By.ClassName(className))).Click();
  }
}
}
