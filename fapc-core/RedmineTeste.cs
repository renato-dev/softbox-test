using automation_core.Controller.Web;
using automation_core.PageObjects.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core
{
    [TestClass]
    public class RedmineTeste : TestBase
    {
        [TestMethod]
        public void AutomationTest()
        {
            StartController.RealizarCadastro();
            HomeController.ClicarAbaProjetos();
            ProjectsController.ClicarNovoProjeto();
            ProjectsController.CriaProjeto();
            SettingsController.ClicarAbaNovaTarefa();
            IssuesController.CriaTarefa30();
            SettingsController.ClicarAbaTarefas();
            IssuesController.ClicarPage();
            Checkpoint(IssuesController.ValidaTipo(JsonValores.Tipo),"Tipo Bug Validado");
            Checkpoint(IssuesController.ValidaSituacao(JsonValores.Situacao), " Situação New Validado");
            Checkpoint(IssuesController.ValidaPrioridade(JsonValores.Prioridade), " Prioridade Normal Validada");
            Checkpoint(IssuesController.ValidaTitulo(JsonValores.Tarefa29), "Titulo Validado");

        }
    }
}
