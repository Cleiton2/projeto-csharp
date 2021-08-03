using System;
using System.Windows.Forms;
using EM.Domain;
using EM.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBD
{
    public partial class CadastroAluno : Form
    {
        readonly RepositorioAluno repositorio = new RepositorioAluno();

        public CadastroAluno()
        {
            InitializeComponent();
            PreencherGrid();
        }

        private void LabelTopo_TextChanged(object sender, EventArgs e)
        {
        }

        private void LabelMatricula_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextoMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtMatricula.MaxLength = 9;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void LabelNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextoNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtNome.MaxLength = 100;
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32;
        }

        private void LabelCPF_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextoCpf_Leave(object sender, EventArgs e)
        {
            string valor = TxtCpf.Text;
            if (!ValidaCPF(valor) && !string.IsNullOrEmpty(TxtCpf.Text))
            {
                MessageBox.Show("O CPF é Inválido !", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCpf.Focus();
                TxtCpf.Clear();
            }
        }

        private void TextoCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtCpf.MaxLength = 11;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && (string)e.Value != string.Empty)
            {
                double.TryParse(e.Value.ToString(), out double d);
                e.Value = d.ToString(@"000\.000\.000-00");
            }
        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            if (BtnLimpar.Text == "Cancelar")
            {
                MudancaEstadoBotaoAdicionar();
            }

        }

        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacoes())
                {
                    return;
                }

                Aluno aluno = PreencherAluno();

                if (lblTopo.Text == "Novo aluno")
                {
                    repositorio.Add(aluno);
                    MessageBox.Show(("Aluno adicionado com sucesso!"), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    repositorio.Update(aluno);
                }
                PreencherGrid();
                LimparCampos();
                MudancaEstadoBotaoAdicionar();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoPesquisa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPesquisa.Text, out int Pesquisa))
            {
                List<Aluno> alunos = new List<Aluno>
                {
                    repositorio.GetByMatricula(Pesquisa)
                };
                try
                {
                    dataGridView1.DataSource = new BindingSource();
                    dataGridView1.DataSource = alunos.ToList();
                    if (alunos[0] == null)
                    {
                        PreencherGrid();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }
            else
            {
                string pesquisaNome = txtPesquisa.Text;
                var alunosParteNome = repositorio.GetByContendoNome(pesquisaNome);
                try
                {
                    dataGridView1.DataSource = new BindingSource();
                    dataGridView1.DataSource = alunosParteNome.ToList();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }

        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            if (dataGridView1.RowCount != 0)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir o registro do aluno?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    aluno.Matricula = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    repositorio.Remove(aluno);
                    PreencherGrid();
                }
            }
            MudancaEstadoBotaoAdicionar();
        }

        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 1)
            {
                btnAdicionar.Text = "Modificar";
                BtnLimpar.Text = "Cancelar";
                lblTopo.Text = "Editando aluno";
                TxtMatricula.ReadOnly = true;

                TxtMatricula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                BoxSexo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                MskNascimento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtCpf.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void PreencherGrid()
        {
            dataGridView1.DataSource = new BindingSource();
            dataGridView1.DataSource = repositorio.GetAll();
        }

        private void LimparCampos()
        {
            TxtMatricula.Clear();
            TxtNome.Clear();
            txtPesquisa.Clear();
            MskNascimento.Clear();
            TxtCpf.Clear();
            BoxSexo.SelectedIndex = -1;
        }

        private Aluno PreencherAluno()
        {
            Aluno aluno = new Aluno(
            Convert.ToInt32(TxtMatricula.Text),
            TxtNome.Text,
            TxtCpf.Text,
            Convert.ToDateTime(MskNascimento.Text),
            (EnumeradorSexo)Enum.Parse(typeof(EnumeradorSexo), BoxSexo.Text));
            return aluno;
        }

        private void MudancaEstadoBotaoAdicionar()
        {
            btnAdicionar.Text = "Adicionar";
            BtnLimpar.Text = "Limpar";
            lblTopo.Text = "Novo aluno";
            TxtMatricula.ReadOnly = false;
            LimparCampos();
        }

        private bool Validacoes()
        {
            if (TxtMatricula.Text.Equals(""))
            {
                MessageBox.Show("O campo 'MATRÍCULA' precisa ser preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMatricula.Focus();
                return false;
            }
            else if (TxtNome.Text.TrimStart().Equals(""))
            {
                MessageBox.Show("O campo 'NOME' precisa ser preenchido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            else if (BoxSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Faça a escolha do campo 'SEXO'!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BoxSexo.Focus();
                return false;
            }
            else if (!MskNascimento.MaskCompleted)
            {
                MessageBox.Show("O campo 'NASCIMENTO' precisa ser preenchido! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MskNascimento.Focus();
                return false;
            }
            if (TxtNome.TextLength < 3)
            {
                MessageBox.Show("O campo 'NOME' deve conter no mínimo 3 letras!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }

            if (CPFJaExiste())
            {
                MessageBox.Show("Este CPF ja foi cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCpf.Clear();
                TxtCpf.Focus();
                return false;
            }

            if ((MatriculaJaExiste() && btnAdicionar.Text == "Adicionar"))
            {
                MessageBox.Show("A matrícula ja esta vinculada a um aluno!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMatricula.Clear();
                TxtMatricula.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf == "00000000000" ||
               cpf == "11111111111" ||
               cpf == "22222222222" ||
               cpf == "33333333333" ||
               cpf == "44444444444" ||
               cpf == "55555555555" ||
               cpf == "66666666666" ||
               cpf == "77777777777" ||
               cpf == "88888888888" ||
               cpf == "99999999999")
            {
                return false;
            }

            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cpf.EndsWith(digito);
        }

        private bool MatriculaJaExiste()
        {
            IEnumerable<Aluno> alunos = repositorio.Get(alunosMatricula => alunosMatricula.Matricula == Convert.ToInt32(TxtMatricula.Text));
            return alunos.Any();
        }

        private bool CPFJaExiste()
        {
            if (TxtCpf.Text == string.Empty)
            {
                return false;
            }

            IEnumerable<Aluno> alunos = repositorio.Get(alunosCPF => alunosCPF.CPF == TxtCpf.Text && alunosCPF.Matricula != Convert.ToInt32(TxtMatricula.Text));
            return alunos.Any();
        }

        private void MaskDataValidacao(object sender, TypeValidationEventArgs e)
        {
            if (e.ReturnValue != null)
            {
                if ((DateTime)e.ReturnValue > DateTime.Today || (DateTime)e.ReturnValue < DateTime.Parse("01/01/1940"))
                {
                    MessageBox.Show("Informe uma data válida entre 01/01/1940 até os dias atuais", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MskNascimento.Text = "";
                    MskNascimento.Focus();
                }
            }
        }
    }
}