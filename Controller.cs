using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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
    public int fishImageNumber;
    public string info;
    IWebDriver _driver;
    WebDriverWait wait;
    Actions builder;
    public Controller()
    {
      _driver = new ChromeDriver();
      wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
      builder = new Actions(_driver);
      fishImageNumber = 0;
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
      //Here we itterate through all the links google has given us, and click the first instance of seriouslyfish. Other ways like class and xpath do not work. 
      try
      {
        for (int i = 0; i < textfields.Count; i++)
        {
          if (textfields[i].Text.Contains("https://www.seriouslyfish.com"))
          {
            textfields[i].Click();
            break;
          }
        }
      }
      catch (Exception)
      { 
      
      }

      // "//*[@id="sidebar"]/div/div[1]/div[2]/a/img"
      // //*[@id="sidebar"]/div/div[1]/div[2]/a/img
      // wait.Until(e => e.FindElement(By.XPath(xPath)))
      try
      {
        string source = wait.Until(e => e.FindElement(By.XPath("//*[@id='sidebar']/div/div[1]/div[2]/a/img"))).GetAttribute("src");
        if (source.Contains(".jpg?"))
        {
          source = source.Split('?')[0];//split on the jpg file.
        }
        SaveImage(source, "fish", ImageFormat.Png);
      }
      catch (Exception)
      {
        // Something is wrong with Format -- Maybe required Format is not 
        // applicable here
      }
      info =  wait.Until(e => e.FindElement(By.ClassName("entry"))).Text.Trim();
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

    public void SaveImage(string imageUrl, string filename, ImageFormat format)
    {
    //  "C:\Users\krais\Downloads\GSLASBAPBylaws (1).docx"
      WebClient webClient = new WebClient();
      webClient.DownloadFile(imageUrl, @"C:\\Users\\krais\\Downloads\\fishImage" + fishImageNumber + ".jpg");
      webClient.Dispose();
      fishImageNumber++;
    }

    private string getText(string xPath)
    {
      //https://www.selenium.dev/documentation/webdriver/waits/
      return wait.Until(e => e.FindElement(By.XPath(xPath))).Text.Trim();
    }
  }
}
