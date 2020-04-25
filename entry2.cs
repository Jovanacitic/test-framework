using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint 
{

    static void Main()
    {
        string url = "https://phptravels.com/order/";
        string Id = ".hero .btn";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(Id));

        if (element.Displayed)
        {
            GreenMessage("Visible!");
        }
        else
        {
            RedMessage("Not visible");
        }
        driver.Quit();
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