using automation_core.PageObjects.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core.Controller.Web
{
    public class HomeController : TestBase
    {
        public static void ClicarAbaProjetos()
        {
            Logger = $"Clicando na Aba Projetos";
            HomePage.AbaProjetos.Click();
        }
    }
}
