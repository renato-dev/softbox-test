using automation_core;
using automation_core.PageObjects.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace automation_core.Controller.Web
{
    public class StartController : TestBase
    {
        public static void ClickCadastrar()
        {
            Logger = $"Clicando Cadastrar";
            StartPage.BotaoCadastrar.Click();
        }
        public static void SetUsuario(string text)
        {
            Logger = $"Preenchendo Usuario{text}";
            StartPage.InputUsuario.SendKeys(text);
        }
        public static void SetSenha(string text)
        {
            Logger = $"Preenchendo senha{text}";
            StartPage.InputSenha.SendKeys(text);
        }
        public static void SetConfirmacaoSenha(string text)
        {
            Logger = $"Preenchendo confirmacao de senha{text}";
            StartPage.InputConfirmaSenha.SendKeys(text);
        }
        public static void SetNome(string text)
        {
            Logger = $"Preenchendo Nome{text}";
            StartPage.InputNome.SendKeys(text);
        }
        public static void SetSobrenome(string text)
        {
            Logger = $"Preenchendo Sobrenome{text}";
            StartPage.InputSobrenome.SendKeys(text);
        }
        public static void SetEmail(string text)
        {
            Logger = $"Preenchendo E-mail{text}";
            StartPage.InputEmail.SendKeys(text);
        }
        public static void ClickEnviar()
        {
            Logger = $"Clicando em enviar";
            StartPage.BotaoEnviar.Click();
        }
        public static void RealizarCadastro()
        {
            SetDriverType(DriverType.WEB, FrontEnd.CHROME);
            StartController.ClickCadastrar();
            StartController.SetUsuario(Ambiente.User);
            StartController.SetSenha(Ambiente.Password);
            StartController.SetConfirmacaoSenha(Ambiente.Password);
            StartController.SetNome(Ambiente.Nome);
            StartController.SetSobrenome(Ambiente.Sobrenome);
            StartController.SetEmail(Ambiente.Email);
            StartController.ClickEnviar();
        }
    }
}
