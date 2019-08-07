using automation_core.PageObjects.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core.Controller.Web
{
    public class ProjectsController : TestBase
    {
        public static void ClicarNovoProjeto()
        {
            Logger = $"Clicando em Novo Projeto";
            ProjectsPage.BotaoNovoProjeto.Click();
        }
    }
}
