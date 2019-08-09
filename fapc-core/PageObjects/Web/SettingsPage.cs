using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core.PageObjects.Web
{
    public class SettingsPage
    {
        public static By AbaTarefas = By.CssSelector("a.issues");
        public static By AbaNovaTarefa = By.CssSelector("a.new-issue");
    }
}
