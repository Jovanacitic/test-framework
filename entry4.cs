using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint 
{

    static void Main()
    {
        string url = "https://phptravels.com/demo/";
        string cssPath = "#Main > section.grey-box > div > div > div:nth-child(2) > div > div > div.col-md-3 > img";
        string xPath = "//*[@id=\"Main\"]/section[2]/div/div/div[2]/div/div/div[1]/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            cssOathElement = driver.FindElement(Byte.XPath(xPath));
            if cssPathElement.Displayed
            {
                GreenMessage("Element is visible");
            }
        }
        catch(NoSUchElementException)
        {
            RedMessage("Css Path element not found!");
        }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}