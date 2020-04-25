using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint 
{
    static void Main()
    {
        iWebFriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://phptravels.com/demo/");
        IWebElement element = driver.FindElement(By.Name("Name"));

        if (element.Displayed)
        {
            GreenMessage("Success");
        }
        else
        {
            RedMessage("Something went wrong!");
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