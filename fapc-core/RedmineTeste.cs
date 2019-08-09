using automation_core.Controller.Web;
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
            ProjectsController.NomeDoProjeto(JsonValores.NomeProjeto);
            ProjectsController.NomeDoProjeto(JsonValores.NomeProjeto);
              

            




        }
    }
}
