using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core.PageObjects.Web
{
    public class ProjectsPage
    {
        public static By BotaoNovoProjeto = By.CssSelector("a.icon");
        public static By InputNome = By.CssSelector("#project_name");
        public static By InputDescricao = By.CssSelector("#project_description");
    }
}
