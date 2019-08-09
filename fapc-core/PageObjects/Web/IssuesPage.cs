using OpenQA.Selenium;

namespace automation_core.PageObjects.Web
{
    public class IssuesPage
    {
        public static By AdionarFiltro = By.CssSelector("#add_filter_select");
        public static By AutorOption = By.CssSelector("#add_filter_select > option:nth-child(6)");
        public static By BotaoAplicar = By.CssSelector("a.icon:nth-child(1)");
        public static By BotaoPage = By.CssSelector("a.page:nth-child(2)");
        public static By InputTitulo = By.CssSelector("#issue_subject");
        public static By BotaoCriarContinuar = By.CssSelector("#issue-form > input:nth-child(5)");
        public static By GridTipo()
        {
            return By.CssSelector("td.tracker");
        }
        public static By GridSituacao()
        {
            return By.CssSelector("td.status");
        }
        public static By GridPrioridade()
        {
            return By.CssSelector("td.priority");
        }
        public static By GridTitulo()
        {
            return By.CssSelector("(//td[@class='subject']//a)[4]");
        }
    }
}
