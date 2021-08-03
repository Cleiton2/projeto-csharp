using FirebirdSql.Data.FirebirdClient;
using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Windows.Forms;

namespace EM.Repository
{
    public class RepositorioAluno : RepositoryAbstract<Aluno>
    {
        private static readonly RepositorioAluno instanciaFireBird = new RepositorioAluno();

        public RepositorioAluno() { }

        public FbConnection GetConexao()
        {
            string conn = @"DataSource=localhost;Port=3053;Database=c:\dados\BANCODEDADOS_v3.FB3;username=SYSDBA;password=masterkey";
            return new FbConnection(conn);
        }

        public static RepositorioAluno GetInstancia()
        {
            return instanciaFireBird;
        }

        public override void Add(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = RepositorioAluno.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "INSERT into Alunos Values(" + aluno.Matricula + ",'" + aluno.Nome + "','" + (int)aluno.Sexo + "','" +
                    aluno.Nascimento.ToString("dd.MM.yyyy") + "','" + aluno.CPF + "')";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public override void Remove(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = RepositorioAluno.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DELETE from Alunos Where matricula= " + aluno.Matricula + ";";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public override void Update(Aluno aluno)
        {
          using (FbConnection conexaoFireBird = RepositorioAluno.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Update ALUNOS SET MATRICULA = '" + Convert.ToInt32(aluno.Matricula) +
                                                 "', NOME = '" + aluno.Nome +
                                                 "', CPF = '" + aluno.CPF +
                                                 "', NASCIMENTO= '" + aluno.Nascimento.ToString("yyyy-MM-dd") +
                                                 "', SEXO= '" + Convert.ToInt32(aluno.Sexo) + "'" +
                                                 " Where MATRICULA= " + aluno.Matricula + ";";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch(FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {          
            return GetAll().Where(predicate.Compile());
        }

        public IEnumerable<Aluno> GetByContendoNome(string parteDoNome)
        {
            return Get(x => x.Nome.ToUpper().Contains(parteDoNome.ToUpper())).ToList();
        }

        public Aluno GetByMatricula(int matricula)
        {
            try
            {
                return Get(m => m.Matricula == matricula).First();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Aluno inexistente!");
                return null;
            }
        }

        public override IEnumerable<Aluno> GetAll()
        {
            using (FbConnection conexaoFireBird= RepositorioAluno.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string consulta = "SELECT * FROM ALUNOS ORDER BY NOME ASC;";
                    FbCommand cmd = new FbCommand(consulta, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    List<Aluno> alunos = new List<Aluno>();
                    while (dr.Read())
                    {
                        alunos.Add(new Aluno()
                        {
                            Matricula = Convert.ToInt32(dr["MATRICULA"]),
                            Nome = dr["NOME"].ToString(),
                            CPF = dr["CPF"].ToString(),
                            Nascimento = Convert.ToDateTime(dr["NASCIMENTO"]),
                            Sexo = (EnumeradorSexo)Convert.ToInt32(dr["SEXO"].ToString())
                        });
                    }
                    dr.Close();
                    return alunos;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }       
    }
}

