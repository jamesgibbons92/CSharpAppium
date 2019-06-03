using NUnit.Framework;
using System;
using System.Security.Permissions;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private static AndroidDriver<AndroidElement> _driver;
        private static string appiumServer = "http://localhost:4723/wd/hub";
        [SetUp]
        public void Setup()
        {
            var appiumOptions = new DesiredCapabilities();
            appiumOptions.SetCapability("deviceName", "Pixel 2");
            appiumOptions.SetCapability("platformName", "Android");
            appiumOptions.SetCapability("platformVersion", "7.0");
            appiumOptions.SetCapability("appPackage", "co.greatstate.hondatelematicsapp");
            appiumOptions.SetCapability("automationName", "UiAutomator2");
            appiumOptions.SetCapability("appActivity", ".MainActivity");
            appiumOptions.SetCapability("newCommandTimeout", 120000);

            _driver = new AndroidDriver<AndroidElement>(new Uri(appiumServer), appiumOptions);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //_driver?.LaunchApp();

        }

        [Test]
        public void Test1()
        {
            var xp2 = "//*[@text='Log in']";
            var xp = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.widget.TextView";
            //AndroidElement confirmAndContinue = _driver.FindElementByXPath("//*[@resource-id='com.example.android.apis:id/button']");
            AndroidElement button = _driver.FindElementByXPath(xp);
            button.Click();
            AndroidElement button2 = _driver.FindElementByXPath(xp2);
            button2.Click();
            AndroidElement el3 = _driver.FindElementByAccessibilityId("Yes");
            el3.Click();
            AndroidElement el4 = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.ImageView");
            el4.Click();


            var journey = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[16]/android.view.ViewGroup[2]/android.widget.TextView";
            AndroidElement el5 = _driver.FindElementByXPath(journey);
            el5.Click();
            System.Threading.Thread.Sleep(20000);
            Assert.Pass();
        }

        [TearDown]
        public void Teardown()
        {
            _driver?.CloseApp();
        }
    }
}