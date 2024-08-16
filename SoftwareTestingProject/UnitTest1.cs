using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SoftwareTestingProject;

namespace SoftwareTestingProject
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {


        BaseTest basetest = new BaseTest();



        [TestMethod, Description("Test Login")]
        [Owner("Aiman")]
        [DataRow("testuser@mailinator.com", "letmein")]
        public void loginValidEmailValidPassword(string email, string pass) { 

       

            basetest.OpenBrowser();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[4]/dialog/div/div[2]/div/button[1]"));
          Thread.Sleep(2000);
             driver.FindElement(By.XPath("//body/div[@id='__nuxt']/div[@id='__layout']/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-main']/div[@class='v-main__wrap']/div[@class='overflow-x-hidden']/div/div/div[@class='relative']/div[@class='component--header-main container bg-light']/header[@class='pb-3 pt-3']/div[@class='tw-flex relative justify-between']/div[@class='header--actions-wrap']/div[@class='tw-flex items-center gap-2']/div[2]/button[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/header/div/div[3]/div/div[2]/div/div[2]/div/div[3]/form/div[5]/button")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
        [TestMethod, Description("Test Login")]
        [Owner("Aiman")]
        [DataRow("test12@mailinator.com", "letmein123")]
        public void loginInValidEmailInValidPassword(string email, string pass)
        {
            basetest.OpenBrowser();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//body/div[@id='__nuxt']/div[@id='__layout']/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-main']/div[@class='v-main__wrap']/div[@class='overflow-x-hidden']/div/div/div[@class='relative']/div[@class='component--header-main container bg-light']/header[@class='pb-3 pt-3']/div[@class='tw-flex relative justify-between']/div[@class='header--actions-wrap']/div[@class='tw-flex items-center gap-2']/div[2]/button[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/header/div/div[3]/div/div[2]/div/div[2]/div/div[3]/form/div[5]/button")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
        [TestMethod, Description("Test Login")]
        [Owner("Aiman")]
        [DataRow("testuser@mailinator.com", "letmein123")]
        public void loginValidEmailInValidPassword(string email, string pass)
        {
            basetest.OpenBrowser();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//body/div[@id='__nuxt']/div[@id='__layout']/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-main']/div[@class='v-main__wrap']/div[@class='overflow-x-hidden']/div/div/div[@class='relative']/div[@class='component--header-main container bg-light']/header[@class='pb-3 pt-3']/div[@class='tw-flex relative justify-between']/div[@class='header--actions-wrap']/div[@class='tw-flex items-center gap-2']/div[2]/button[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/header/div/div[3]/div/div[2]/div/div[2]/div/div[3]/form/div[5]/button")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod, Description("Hover")]

        public void hoverwebelements()
        {

            basetest.OpenBrowser();
            Thread.Sleep(3000);
            //Instantiate Action Class  
            Actions actions = new Actions(driver);
            //Retrieve WebElement 'Unstiched' to perform mouse hover 
            WebElement a = (WebElement)driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/div[1]/div[1]/nav/ul/li[1]/a"));
            //Mouse hover on 'Unstiched'
            actions.MoveToElement(a).Perform();
            Thread.Sleep(2000);
            WebElement b = (WebElement)driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/div[1]/div[1]/nav/ul/li[2]/a"));
            //Mouse hover on 'Designer Luxury'
            actions.MoveToElement(b).Perform();
            driver.Close();
        }


        [TestMethod, Description("Search&AddToCart")]


        public void SearchAndAddToCart()
        {
            basetest.OpenBrowser();
            Thread.Sleep(3000);
            //Click on Search
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/div[1]/div[1]/div/div/div")).Click();
            Thread.Sleep(2000);
            //Write on Search
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/div/div[1]/div[1]/div/div[1]/div[2]/div/div/div/div[1]/div/div/div[2]/div/div/div/div/input")).SendKeys("Footwear");
            Thread.Sleep(3000);
            //Selecting an item
            driver.Url = ("https://stores.laam.pk/products/pointed-court-shoes-yellow");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[@class='font-inter text-sm font-medium'][contains(text(),'39')]")).Click();
            //Adding item to cart
            driver.FindElement(By.XPath("/html/body/div/div/div/div/main/div/main/section[2]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div[2]/div/div/div/div[2]/div/button")).Click();
            Thread.Sleep(3000);
            //Click on Cart button
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/main/section[1]/div[1]/div/div[1]/header/div/div[3]/div/div[3]/button")).Click();

            Thread.Sleep(2000);

            driver.Close();
        }

    }
}
