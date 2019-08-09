

using automation_core.PageObjects.Web;

namespace automation_core.Controller.Web
{
    public class IssuesController : TestBase
    {
        public static void ClicarFiltro()
        {
            Logger = $"Clicando no adicionar filtro";
            IssuesPage.AdionarFiltro.Click();
        }
        public static void OpcaoAutor()
        {
            Logger = $"Selecionando Opcao Autor";
            IssuesPage.AutorOption.Click();

        }
        public static void ClicarBotaoCriarContinuaFinal()
        {
            Logger = $"Clicando botao criar e continuar";
            IssuesPage.BotaoCriarContinuar.Click();

        }
        public static void ClicarBotaoAplicar()
        {
            Logger = $"Clicando no botao aplicar";
            IssuesPage.BotaoAplicar.Click();
        }
        public static void ClicarPage()
        {
            Logger = $"Clicando na page 2";
            IssuesPage.BotaoPage.Click();

        }
        public static void NomeDaTarefa(string text)
        {
            Logger = $"Preenchendo nome da tarefa";
            IssuesPage.InputTitulo.SendKeys(text);

        }
        public static void ClicarBotaoCriaContinua(int i)
        {
            Logger = $"Clicando botao criar e continuar";
            IssuesPage.BotaoCriarContinuar.Click(i);

        }

        public static bool ValidaTipo(string text)
        {
            Logger = $"Validando Tipo da tarefa";
            return IssuesPage.GridTipo().Wait().Text.Contains(text);
        }
        public static bool ValidaSituacao(string text)
        {
            Logger = $"Validando Situacao da tarefa";
            return IssuesPage.GridSituacao().Wait().Text.Contains(JsonValores.Situacao);
        }
        public static bool ValidaPrioridade(string text)
        {
            Logger = $"Validando Prioridade da tarefa";
            return IssuesPage.GridPrioridade().Wait().Text.Contains(JsonValores.Prioridade);
        }
        public static bool ValidaTitulo(string text)
        {
            Logger = $"Validando Titulo da tarefa";
            return IssuesPage.GridTitulo().Wait().Text.Contains(JsonValores.Tarefa29);
        }
                   

        public static void CriaTarefa30()
        {
            IssuesController.NomeDaTarefa(JsonValores.Tarefa30);
            IssuesController.ClicarBotaoCriarContinuaFinal();
            IssuesController.NomeDaTarefa(JsonValores.Tarefa29);
            IssuesController.ClicarBotaoCriarContinuaFinal();
            

            for (int i = 1; i < 29; i++)
            {
                IssuesController.NomeDaTarefa(JsonValores.NomeTarefa);
                IssuesController.ClicarBotaoCriaContinua(i);
            }

        }
    }
}
