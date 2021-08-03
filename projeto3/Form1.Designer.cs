using System;
using System.Windows.Forms;

namespace ProjetoBD
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTopo = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.BoxSexo = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.MskNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.Location = new System.Drawing.Point(13, 2);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(69, 16);
            this.lblTopo.TabIndex = 1;
            this.lblTopo.Text = "Novo aluno";
            this.lblTopo.TextChanged += new System.EventHandler(this.LabelTopo_TextChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 164);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(571, 23);
            this.txtPesquisa.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPesquisa.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(597, 163);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(88, 24);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.BotaoPesquisa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunoBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView1.Location = new System.Drawing.Point(16, 199);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 127);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(483, 332);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 24);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcluir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(572, 332);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 24);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblMatricula.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricula.Location = new System.Drawing.Point(16, 10);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(72, 17);
            this.LblMatricula.TabIndex = 0;
            this.LblMatricula.Text = " Matrícula*";
            this.LblMatricula.TextChanged += new System.EventHandler(this.LabelMatricula_TextChanged);
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.HideSelection = false;
            this.TxtMatricula.Location = new System.Drawing.Point(19, 30);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtMatricula.ShortcutsEnabled = false;
            this.TxtMatricula.Size = new System.Drawing.Size(127, 23);
            this.TxtMatricula.TabIndex = 1;
            this.TxtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoMatricula_KeyPress);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(152, 10);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(44, 17);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome*";
            this.LblNome.TextChanged += new System.EventHandler(this.LabelNome_TextChanged);
            // 
            // TxtNome
            // 
            this.TxtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNome.Location = new System.Drawing.Point(152, 30);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.ShortcutsEnabled = false;
            this.TxtNome.Size = new System.Drawing.Size(511, 23);
            this.TxtNome.TabIndex = 3;
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoNome_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(16, 64);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 17);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo*";
            // 
            // BoxSexo
            // 
            this.BoxSexo.BackColor = System.Drawing.SystemColors.Window;
            this.BoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxSexo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BoxSexo.FormattingEnabled = true;
            this.BoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.BoxSexo.Location = new System.Drawing.Point(19, 84);
            this.BoxSexo.Name = "BoxSexo";
            this.BoxSexo.Size = new System.Drawing.Size(127, 23);
            this.BoxSexo.TabIndex = 5;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(152, 65);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(78, 17);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Nascimento*";
            // 
            // MskNascimento
            // 
            this.MskNascimento.Location = new System.Drawing.Point(156, 84);
            this.MskNascimento.Mask = "00/00/0000";
            this.MskNascimento.Name = "MskNascimento";
            this.MskNascimento.ShortcutsEnabled = false;
            this.MskNascimento.Size = new System.Drawing.Size(112, 23);
            this.MskNascimento.TabIndex = 7;
            this.MskNascimento.ValidatingType = typeof(System.DateTime);
            this.MskNascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.MaskDataValidacao);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPF.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(271, 63);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 17);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdicionar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(580, 84);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(83, 24);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BotaoAdicionar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnLimpar);
            this.panel1.Controls.Add(this.TxtCpf);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.MskNascimento);
            this.panel1.Controls.Add(this.lblNascimento);
            this.panel1.Controls.Add(this.BoxSexo);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Controls.Add(this.TxtMatricula);
            this.panel1.Controls.Add(this.LblMatricula);
            this.panel1.Location = new System.Drawing.Point(16, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 128);
            this.panel1.TabIndex = 0;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnLimpar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(499, 83);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(274, 84);
            this.TxtCpf.MaxLength = 11;
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.ShortcutsEnabled = false;
            this.TxtCpf.Size = new System.Drawing.Size(198, 23);
            this.TxtCpf.TabIndex = 12;
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoCpf_KeyPress);
            this.TxtCpf.Leave += new System.EventHandler(this.TextoCpf_Leave);
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Width = 76;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(EM.Domain.Aluno);
            // 
            // CadastroAluno
            // 
            this.ClientSize = new System.Drawing.Size(706, 374);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTopo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblTopo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private Label LblMatricula;
        private TextBox TxtMatricula;
        private Label LblNome;
        private TextBox TxtNome;
        private Label lblSexo;
        private ComboBox BoxSexo;
        private Label lblNascimento;
        private MaskedTextBox MskNascimento;
        private Label lblCPF;
        private Button btnAdicionar;
        private Panel panel1;
        private BindingSource alunoBindingSource;
        private Button BtnLimpar;
        private TextBox TxtCpf;
        private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
    }
}

