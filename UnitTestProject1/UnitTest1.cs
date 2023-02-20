using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetVIN_CorrectlyResult() //проверка на корректность данных
        {
            string vin = "1GTGK24R0XR710695";
            string expected = "Северная Америка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVIN_ResultTypeTostring() //проверка на возвращаемый тип - string
        {
            string vin = "JH4DA3340HS032394";
            Assert.IsNotInstanceOfType(Class1.GetVINCountry(vin), typeof(string));
        }
        [TestMethod]
        public void GetVIN_TypeToBool() //проверка на не возвращаемый тип - bool
        {
            string vin = "1356154858";
            Assert.IsNotInstanceOfType(Class1.GetVINCountry(vin), typeof(bool));
        }
        [TestMethod]
        public void GetVIN_Country() //проверка на корректность при неверных данных
        {
            string vin = "1G3HN52K0W4818670";
            string expected = "Европа";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void GetVIN_ResultNoCorrectly() 
        {
            string vin = "1A8HW58268F133559";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsFalse(actual == "Океания");
        }
        [TestMethod]
        public void GetVIN_ReturnResultNoCorrectly()
        {
            string vin = "JNKCV54E46M706213";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsFalse(actual == "Европа");
        }
        [TestMethod]
        public void CheckVIN_Correctly() 
        {
            string vin = "JHMCM56557C404453";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void GetVINCountry_Correctly() //проверка на то, что метод выводит континент по vin
        {
            string expected = "Азия";
            string vin = "JHMCM56557C404453";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]        
        public void GetVIN_CorrectlyType() //Проверка, что метод, выводящий континент по vin, выводит результат с правильным типом данных
        {
            string vin = "FFLTJRI5794965678";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
        [TestMethod]
        public void GetVINCountry_CorrectlyNum() //Проверка, что метод, выводящий континент по vin, выводит результат с правильным типом данных
        {
            string expected = "Северная Америка";
            string vin = "56JHMCM565C404453";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVIN_ReturnNull()
        {
            string vin = "1356154858";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }
        [TestMethod]
        public void GetVIN_ReturnNoNull()
        {
            string vin = "llllll";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }
        [TestMethod]
        public void GetVINCountry_NotCorrectlyVin()
        {
            string vin = "OOOOOOOOOOOOOOOOOOOOOOOOOO";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsTrue(actual == "");
        }
        [TestMethod]
        public void CheckVIN_ReturnNoCorrectly()
        {
            string vin = "1546988486";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }
        [TestMethod]
        public void CheckVIN_NotNullCheck()
        {
            string vin = "4854789";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsNotNull(actual);
        }
    }
}
