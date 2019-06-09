using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Register_Corporate()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/"); // URL

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[1]/a")).Click(); // register
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("name")).SendKeys("Sofware Engineer"); // name 
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("mail")).SendKeys("association4@softeng.com"); // mail
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password")).SendKeys("softeng_123"); // password
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='signupForm']/div[2]/div[4]/label[2]/span[1]")).Click(); // corporate account
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='signupForm']/div[3]/a")).Click(); // register successful
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("nick")).SendKeys("Soft_Eng_Association4"); // company information
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("phoneUser")).SendKeys("5555555555");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("companyName")).SendKeys("Software Engineer Association");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("phoneCompany")).SendKeys("2222222222");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("companyDate")).SendKeys("2018-12-19");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("companyMail")).SendKeys("info@softeng.com");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("companyWeb")).SendKeys("softengassociation.com");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("companyAbout")).SendKeys("Software Engineers World");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='welcomeCForm']/div[2]/a")).Click(); // company information entered (successful)

            Assert.Pass("Register Passing Test");
        }

        [Test]
        public void LoginAndLogout_Corporate()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click(); // login
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("emailorname")).SendKeys("association2@softeng.com"); // email
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password")).SendKeys("softeng_123"); // password
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='loginForm']/div[3]/a")).Click(); // login successful
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='navigation-index']/ul/li[6]/a")).Click(); // 
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("doLogOut")).Click(); // logout

            Assert.Pass("Login and Logout Passing Test");
        }

        [Test]
        public void ChangePassword()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click(); // login
            System.Threading.Thread.Sleep(500);
            driver.FindElement(By.Name("emailorname")).SendKeys("association3@softeng.com");
            driver.FindElement(By.Name("password")).SendKeys("softeng_123");
            driver.FindElement(By.XPath(".//*[@id='loginForm']/div[3]/a")).Click();
            System.Threading.Thread.Sleep(2000); // login successful

            driver.FindElement(By.XPath(".//*[@id='navigation-index']/ul/li[6]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='navigation-index']/ul/li[6]/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/div/div/div[1]/div[3]/a/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[4]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password_current")).SendKeys("softeng_123"); // current password
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password_new")).SendKeys("softeng_1244"); // new password
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password_new_confirm")).SendKeys("softeng_1244"); // confirm new password
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password_form")).Click(); // change password successful
            System.Threading.Thread.Sleep(2000);

            Assert.Pass("Change Password Passing Test");
        }
    }
}
