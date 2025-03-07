namespace Projecto_Gestão_de_Academia
{
    partial class F_GestaoAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Financeiro = new System.Windows.Forms.Button();
            this.btn_ExcluirAluno = new System.Windows.Forms.Button();
            this.btn_salvarEdicao = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_imprimirCarteirinha = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.AllowUserToAddRows = false;
            this.dgv_aluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.EnableHeadersVisualStyles = false;
            this.dgv_aluno.Location = new System.Drawing.Point(5, 12);
            this.dgv_aluno.MultiSelect = false;
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.ReadOnly = true;
            this.dgv_aluno.RowHeadersVisible = false;
            this.dgv_aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aluno.Size = new System.Drawing.Size(296, 444);
            this.dgv_aluno.TabIndex = 32;
            this.dgv_aluno.SelectionChanged += new System.EventHandler(this.dgv_aluno_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Financeiro);
            this.panel1.Controls.Add(this.btn_ExcluirAluno);
            this.panel1.Controls.Add(this.btn_salvarEdicao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 47);
            this.panel1.TabIndex = 33;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(448, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(164, 41);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Financeiro
            // 
            this.btn_Financeiro.Enabled = false;
            this.btn_Financeiro.Location = new System.Drawing.Point(299, 3);
            this.btn_Financeiro.Name = "btn_Financeiro";
            this.btn_Financeiro.Size = new System.Drawing.Size(143, 41);
            this.btn_Financeiro.TabIndex = 2;
            this.btn_Financeiro.Text = "Financeiro";
            this.btn_Financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirAluno
            // 
            this.btn_ExcluirAluno.Location = new System.Drawing.Point(167, 3);
            this.btn_ExcluirAluno.Name = "btn_ExcluirAluno";
            this.btn_ExcluirAluno.Size = new System.Drawing.Size(126, 41);
            this.btn_ExcluirAluno.TabIndex = 1;
            this.btn_ExcluirAluno.Text = "Excluir Aluno";
            this.btn_ExcluirAluno.UseVisualStyleBackColor = true;
            this.btn_ExcluirAluno.Click += new System.EventHandler(this.btn_ExcluirAluno_Click);
            // 
            // btn_salvarEdicao
            // 
            this.btn_salvarEdicao.Location = new System.Drawing.Point(13, 3);
            this.btn_salvarEdicao.Name = "btn_salvarEdicao";
            this.btn_salvarEdicao.Size = new System.Drawing.Size(148, 41);
            this.btn_salvarEdicao.TabIndex = 0;
            this.btn_salvarEdicao.Text = "Salvar Edições";
            this.btn_salvarEdicao.UseVisualStyleBackColor = true;
            this.btn_salvarEdicao.Click += new System.EventHandler(this.btn_salvarEdicao_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(319, 261);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(138, 157);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 34;
            this.pb_foto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(322, 42);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(290, 20);
            this.tb_nome.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(322, 99);
            this.mtb_telefone.Mask = "(244)999999999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(124, 20);
            this.mtb_telefone.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(476, 99);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(136, 21);
            this.cb_status.TabIndex = 40;
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(319, 164);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(293, 21);
            this.cb_turma.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Clique Duplo para aterar a foto";
            // 
            // btn_imprimirCarteirinha
            // 
            this.btn_imprimirCarteirinha.Location = new System.Drawing.Point(319, 202);
            this.btn_imprimirCarteirinha.Name = "btn_imprimirCarteirinha";
            this.btn_imprimirCarteirinha.Size = new System.Drawing.Size(293, 23);
            this.btn_imprimirCarteirinha.TabIndex = 43;
            this.btn_imprimirCarteirinha.Text = "Imprimir Carteirinha";
            this.btn_imprimirCarteirinha.UseVisualStyleBackColor = true;
            this.btn_imprimirCarteirinha.Click += new System.EventHandler(this.btn_imprimirCarteirinha_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Turma";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 509);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_imprimirCarteirinha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_turma);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_aluno);
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GestaoAlunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Financeiro;
        private System.Windows.Forms.Button btn_ExcluirAluno;
        private System.Windows.Forms.Button btn_salvarEdicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_imprimirCarteirinha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}