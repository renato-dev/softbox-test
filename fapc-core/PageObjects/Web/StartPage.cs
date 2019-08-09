using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace automation_core.PageObjects.Web
{
    public class StartPage
    {
        public static By BotaoCadastrar = By.CssSelector(".register");
        public static By InputUsuario = By.CssSelector("#user_login");
        public static By InputSenha = By.CssSelector("#user_password");
        public static By InputConfirmaSenha = By.CssSelector("#user_password_confirmation");
        public static By InputNome = By.CssSelector("#user_firstname");
        public static By InputSobrenome = By.CssSelector("#user_lastname");
        public static By InputEmail = By.CssSelector("#user_mail");
        public static By BotaoEnviar = By.CssSelector("input[type=submit]");
                public static By BotaoLogin = By.CssSelector("input[type=submit]");
    }
}