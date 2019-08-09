using automation_core.PageObjects.Web;
using Newtonsoft.Json;
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
            SetNomeProjeto("JsonValores.json");
            ProjectsPage.BotaoNovoProjeto.Click();
        }
        public static void  PreenchendoNome (string text)
        {
            Logger = $"Preenchendo nome da tarefa";
            ProjectsPage.InputNome.SendKeys(text);
        }
        public static void PreenchendoDescricao(string text)
        {
            Logger = $"Preenchendo descricao da tarefa";
            ProjectsPage.InputDescricao.SendKeys(text);
        }
        public static void SelecionandoTipoDeTarefaBug ()
        {
            Logger = $"Marcando tipo Bug";
            ProjectsPage.CheckFeature.Click();
            ProjectsPage.CheckSupport.Click();
        }
        public static void NomeDoProjeto(string text)
        {
            Logger = $"Preenchendo nome projeto";
            ProjectsPage.InputNome.SendKeys(text);

        }
        
    }
}
