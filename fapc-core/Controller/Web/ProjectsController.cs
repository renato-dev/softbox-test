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
        /*public static void PreenchendoDescricao(string text)
        {
            Logger = $"Preenchendo descricao da tarefa";
            ProjectsPage.InputDescricao.SendKeys(text);
        }*/
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
        
        public static void ClickCriarContinuar(int i)
        {
            Logger = $"Clicando em Criar e Continuar";
            ProjectsPage.ClickCriarContinuar.Click(i);
        }
        public static void BotaoCriar()
        {
            Logger = $"Clicando no botao criar";
            ProjectsPage.ClicaCriar.Click();
        }
        public static void CriaProjeto()
        {
            ProjectsController.NomeDoProjeto(Ambiente.NomeProjeto);
            ProjectsController.SelecionandoTipoDeTarefaBug();
            ProjectsController.BotaoCriar();
        }

        
        public static void ClicarTarefas()
        {
            Logger = $"Clicando em Ver todas as tarefas";
            ProjectsPage.ClicarTarefas.Click();
        }
    
        
    }
}
