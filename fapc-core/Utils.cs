using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Collections.Generic;
using System.Threading;

namespace automation_core
{
    public static class Utils
    {
        public static void LongPress(this By by, int timeout = TestBase.DefaultTimeout, bool failIfNotExists = true)
        {
            var element = by.Wait(timeout, failIfNotExists);

            if (element != null)
            {
                new TouchAction((IPerformsTouchActions)TestBase.Driver).LongPress(element).Perform();
            }
        }

        public static void SenKeysNext(this AndroidDriver<AndroidElement> androidDriver)
        {
            androidDriver.ExecuteScript("mobile: performEditorAction", new Dictionary<string, string> { { "action", "next" } });
        }

        public static IWebElement Wait(this By by, int timeout = TestBase.DefaultTimeout, bool failIfNotExists = true)
        {
            Thread.Sleep(2000);

            for (int i = 0; i < timeout; i++)
            {
                if(TestBase.Driver.FindElements(By.XPath("//div[@class='blockUI blockOverlay']")).Count == 0)
                {
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }


            for (int i = 0; i < timeout; i++)
            {
                try
                {
                    if (TestBase.Driver.FindElement(by).Displayed && TestBase.Driver.FindElement(by).Enabled)
                    {
                        TestBase.Checkpoint(true, $"Elemento encontrado pelo localizador {by}");

                        return TestBase.Driver.FindElement(by);
                    }
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }

            if (failIfNotExists)
            {
                TestBase.Checkpoint(false, $"Elemento não encontrado pelo localizador {by}");
            }

            return null;
        }

        public static void Click(this By by, int timeout = TestBase.DefaultTimeout, bool failIfNotExists = true)
        {
            var element = by.Wait(timeout, failIfNotExists);

            if (element != null)
            {
                if (element.Displayed && element.Enabled)
                {
                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        element = by.Wait(timeout, failIfNotExists);
                        element.Click();
                    }
                }
            }
        }

        public static void SendKeys(this By by, string text, int timeout = TestBase.DefaultTimeout, bool failIfNotExists = true)
        {
            var element = by.Wait(timeout, failIfNotExists);

            if (element != null)
            {
                if (element.Enabled && element.Displayed)
                {
                    try
                    {
                        element.SendKeys(text);
                    }
                    catch
                    {
                        element = by.Wait(timeout, failIfNotExists);
                        element.SendKeys(text);
                    }
                }
            }
        }

        public static string Text(this By by, int timeout = TestBase.DefaultTimeout, bool failIfNotExists = true)
        {
            var element = by.Wait(timeout, failIfNotExists);

            if (element != null)
            {
                return element.Text;
            }

            return "";
        }
    }
}