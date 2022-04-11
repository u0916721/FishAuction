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
using System.Threading;
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
    public FishModel currentFish;
    IWebDriver _driver;
    IWebDriver _imageDriver;
    WebDriverWait wait;
    WebDriverWait waitImage;
    Actions builder;
    private string fishName;
    public Controller()
    {
      _imageDriver = new ChromeDriver();
      _driver = new ChromeDriver();
      wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
      waitImage = new WebDriverWait(_imageDriver, TimeSpan.FromSeconds(5));
      builder = new Actions(_driver);
      fishImageNumber = 0;
      currentFish = new FishModel();
    }
    /**
* I dont want to copy paste the same code over and over again so im wrapping it in a helper
*/
    private void inputText(string xPath, string text)
    {
      //https://www.selenium.dev/documentation/webdriver/waits/
      wait.Until(e => e.FindElement(By.XPath(xPath), 2000)).SendKeys(text);

    }
    /*
     * Searches on google images in the other browser.
     * 
     */
    public void getImage()
    {
      try
      {
        _imageDriver.Navigate().GoToUrl("https://images.google.com/");
        waitImage.Until(e => e.FindElement(By.XPath("//*[@id='sbtc']/div/div[2]/input"), 2000)).SendKeys(fishName);
        waitImage.Until(e => e.FindElement(By.XPath("//*[@id='sbtc']/button"))).Click();
      }
      catch(Exception)
      {
        //This is to prevent program crashing , selenide is jank sometimes. 
      }
    }
    public void findFish(string fishName)
    {
      this.fishName = fishName;
      Thread thread = new Thread(getImage);
      thread.Start();
      _driver.Navigate().GoToUrl("https://www.google.com");
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
     // try
      //{
       // string source = wait.Until(e => e.FindElement(By.XPath("//*[@id='sidebar']/div/div[1]/div[2]/a/img"))).GetAttribute("src"); //Need more fixes for diffrents kinds of links!
       // if (source.Contains(".jpg?"))
       // {
         // source = source.Split('?')[0];//split on the jpg file.
        //}
        //SaveImage(source, "fish", ImageFormat.Png);
     // }
      //catch (Exception)
      //{
        // Something is wrong with Format -- Maybe required Format is not 
        // applicable here
      //}
      info =  wait.Until(e => e.FindElement(By.ClassName("entry"))).Text.Trim();
      currentFish.setValues(info);
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
