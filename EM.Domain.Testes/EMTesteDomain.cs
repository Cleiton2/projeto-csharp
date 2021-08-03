using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EM.Domain.Testes
{
    [TestClass]
    public class EMTesteDomain
    {
        readonly Aluno aluno = new Aluno();
        [TestMethod]
        public void Aluno()
        {
            aluno.Matricula = 15784785;
            aluno.Nome = "Teste";
            aluno.CPF = "";
            aluno.Nascimento = Convert.ToDateTime("08/08/1997");
            aluno.Sexo = (EnumeradorSexo)0;
        }
        [TestMethod]
        public void TesteEquals()
        {
            Assert.IsTrue(aluno.Equals(aluno));
        }
        [TestMethod]
        public void TesteGetHashcode()
        {
            Assert.AreNotEqual(aluno.GetHashCode(), 0);
        }
        [TestMethod]
        public void TesteToString()
        {
            aluno.ToString();
        }
    }
}

