using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using Calculadora.Model;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTest
    {
        

        [TestMethod]
        public void TesteSalDes20Desconto()
        {
            Desenvolvedor dev = new Desenvolvedor("Lucas Ferreira Hubie", "lucas.hubie@email.com", 5500);
            Assert.AreEqual(4400,dev.Salario);
        }
        [TestMethod]
        public void TesteSalGer30Desconto()
        {
            Gerente ger = new Gerente("Lucas Ferreira Hubie", "lucas.hubie@email.com", 5000);
            Assert.AreEqual(3500,ger.Salario);
        }
        [TestMethod]
        public void TesteSalDBA25Desconto()
        {
            Dba dba = new Dba("Lucas Ferreira Hubie", "lucas.hubiel@email.com", 2000);
            Assert.AreEqual(1500,dba.Salario);
        }
        [TestMethod]
        public void TesteSalTes25Desconto()
        {
            Testador test = new Testador("Lucas Ferreira Hubie", "lucas.hubiel@email.com", 2000); ;
            Assert.AreEqual(1500,test.Salario);
        }
        [TestMethod]
        public void TesteSalDes10Desconto()
        {
            Desenvolvedor dev = new Desenvolvedor("Lucas Ferreira Hubie", "lucas.hubie@email.com", 2500);
            Assert.AreEqual(2250,dev.Salario);
        }
        [TestMethod]
        public void TesteSalGer20Desconto()
        {
            Gerente ger = new Gerente("Lucas Ferreira Hubie", "lucas.hubie@email.com", 4500);
            Assert.AreEqual(3600,ger.Salario);
        }
        [TestMethod]
        public void TesteSalDBA15Desconto()
        {
            Dba dba = new Dba("Lucas Ferreira Hubie", "lucas.hubie@email.com", 1500);
            Assert.AreEqual(1275,dba.Salario);
        }
        [TestMethod]
        public void TesteSalTes15Desconto()
        {
            Testador test = new Testador("Lucas Ferreira Hubie", "lucas.hubie@email.com", 1500); ;
            Assert.AreEqual(1275,test.Salario);
        }
        [TestMethod]
        public void TesteSalDesFinal()
        {
            Desenvolvedor dev = new Desenvolvedor("Lucas Ferreira Hubie", "lucas.hubie@email.com", 5000);
            Assert.AreEqual(4000,dev.Salario);
        }
        [TestMethod]
        public void TesteSalGerFinal()
        {
            Gerente ger = new Gerente("Lucas Ferreira Hubie", "lucas.hubie@email.com", 2500);
            Assert.AreEqual(2000,ger.Salario);
        }
        [TestMethod]
        public void TesteSalDBAFinal()
        {
            Dba dba = new Dba("Lucas Ferreira Hubie", "lucas.hubie@email.com", 550);
            Assert.AreEqual(467.50,dba.Salario);
        }
        [TestMethod]
        public void TesteSalTesFinal()
        {
            Testador test = new Testador("Lucas Ferreira Hubie", "lucas.hubie@email.com", 1500); ;
            Assert.AreEqual(1275,test.Salario);
        }
    }
}
