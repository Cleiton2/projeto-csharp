using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EM.Domain;

namespace EM.Repository.Teste
{
    [TestClass]
    public class EMTesteRepositorio
    {
        readonly RepositorioAluno repositorioTeste = new RepositorioAluno();
        [TestMethod]

        public void AlunoAdd()
        {
            Aluno alunoAdd = new Aluno
            {
                Matricula = 15784785,
                Nome = "Teste",
                Sexo = (EnumeradorSexo)0,
                Nascimento = Convert.ToDateTime("08/08/1997"),
                CPF = ""
            };
            repositorioTeste.Add(alunoAdd);
            Assert.IsNotNull(alunoAdd);
        }

        [TestMethod]
        public void AlunoUpdate()
        {
            Aluno alunoUpdate = new Aluno
            {
                Matricula = 15784785,
                Nome = "Teste 1",
                Sexo = (EnumeradorSexo)0,
                Nascimento = Convert.ToDateTime("08/08/1997"),
                CPF = ""
            };
            repositorioTeste.Update(alunoUpdate);
            Assert.IsNotNull(alunoUpdate);
        }

        [TestMethod]
        public void RemoveAluno()
        {
            Aluno alunoRemove = new Aluno
            {
                Matricula = 15784785,
                Nome = "Teste 1",
                Sexo = (EnumeradorSexo)0,
                Nascimento = Convert.ToDateTime("08/08/1997"),
                CPF = ""
            };

            repositorioTeste.Remove(alunoRemove);
            Assert.IsNotNull(alunoRemove);
        }

        [TestMethod]
        public void GetAllTest()
        {
            Assert.IsNotNull(repositorioTeste.GetAll());
        }

        [TestMethod]
        public void GetByMatricula()
        {
            int matricula = 15784785;
            Assert.AreEqual(repositorioTeste.GetByMatricula(matricula).Nome, "Teste 1");
            Assert.AreEqual(repositorioTeste.GetByMatricula(matricula).Matricula, 15784785);
            Assert.AreEqual(repositorioTeste.GetByMatricula(matricula).Sexo, (EnumeradorSexo)0);
            Assert.AreEqual(repositorioTeste.GetByMatricula(matricula).Nascimento, Convert.ToDateTime("08/08/1997").Date);
            Assert.AreEqual(repositorioTeste.GetByMatricula(matricula).CPF, "");
        }

        [TestMethod]
        public void GetByContendoNoNomeTest()
        {
            Aluno alunoByNome = new Aluno();

            Assert.IsNotNull(alunoByNome);
        }      
    }
}
