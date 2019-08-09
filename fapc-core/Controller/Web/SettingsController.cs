using automation_core.PageObjects.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core.Controller.Web
{
   public class SettingsController : TestBase
    {
        public static void ClicarAbaNovaTarefa()
        {
            Logger = $"Clicando na aba nova tarefa";
            SettingsPage.AbaNovaTarefa.Click();
        }
        public static void ClicarAbaTarefas()
        {
            Logger = $"Clicando na aba Tarefas";
            SettingsPage.AbaTarefas.Click();
        }
    }
}
