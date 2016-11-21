using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Temperatur.Tests
{
    [TestClass()]
    public class TemperatureTests
    {
        private Temperature tK = new Temperature() { Kelvin = 22 }, tC = new Temperature() { Celsius = 22 };
        private Single tDiff = 100;

        private Single tKErwartet = 122;
        private Single tCErwartet = 122;

        private Temperature tErgebnis;
        private Dictionary<Temperature, Single> tmpListKelvin = new Dictionary<Temperature, Single>();
        private Dictionary<Temperature, Single> tmpListFahrenheit = new Dictionary<Temperature, Single>();

        public TemperatureTests()
        {
            tmpListKelvin.Add(Temperature.MinValue, Temperature.MinValue.Kelvin);
            tmpListKelvin.Add(new Temperature() { Kelvin = 1 }, 1);
            tmpListKelvin.Add(new Temperature() { Kelvin = 273.15f }, 273.15f);
            tmpListKelvin.Add(new Temperature() { Kelvin = 373.15f }, 373.15f);
            tmpListKelvin.Add(new Temperature() { Kelvin = 1273.15f }, 1273.15f);
        }

        [TestMethod()]
        public void TemperatureTest()
        {
            Assert.Inconclusive("TEST");
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            foreach (var item in tmpListKelvin)
            {
                tErgebnis = item.Key.Add(tDiff, TemperaturEinheit.Kelvin);
                Assert.AreEqual(item.Value, tErgebnis.Kelvin, $"{item.Key}: Test in {TemperaturEinheit.Kelvin}");
            }
        }

        [TestMethod()]
        public void AddTestMinus()
        {
            Assert.Fail();
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException),"absoluter Nullpunkt")]
        [TestMethod()]
        public void AddTestNullpunkt()
        {
            tK = tK.Add(-tDiff, TemperaturEinheit.Kelvin);
            Assert.AreEqual(tKErwartet, tK.Kelvin,  $"Test in {TemperaturEinheit.Kelvin}");
        }
        [TestMethod()]
        public void AddKelvinTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCelsiusTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddFahrenheitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest1()
        {
            tK.Kelvin = 22;
            String s = tK.ToString(TemperaturEinheit.Kelvin);
            Assert.AreEqual("22K", s, "Das ist saukalt");
        }

        [TestMethod()]
        public void Form1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            Assert.Fail();
        }
    }
}