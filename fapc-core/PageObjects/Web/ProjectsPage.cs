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
        public static By InputIdentificador = By.CssSelector("#project_identifier");
        public static By CheckFeature = By.CssSelector("#project_trackers > label:nth-child(3) > input:nth-child(1)");
        public static By CheckSupport = By.CssSelector("#project_trackers > label:nth-child(4) > input:nth-child(1)");
        public static By ClickCriarContinuar = By.CssSelector("#new_project > input:nth-child(8)");
        public static By ClicarTarefas = By.XPath("//a[@href='/issues']");
        public static By ClicaCriar = By.CssSelector("#new_project > input:nth-child(7)");
    }
}
