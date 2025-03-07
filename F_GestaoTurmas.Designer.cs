namespace Projecto_Gestão_de_Academia
{
    partial class F_GestaoTurmas
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
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimirTurma = new System.Windows.Forms.Button();
            this.btn_exluirTurma = new System.Windows.Forms.Button();
            this.btn_salvarEdicao = new System.Windows.Forms.Button();
            this.btn_novaTurma = new System.Windows.Forms.Button();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.n_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.cm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dscTurma = new System.Windows.Forms.TextBox();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(465, 485);
            this.dgv_turmas.TabIndex = 30;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimirTurma);
            this.panel1.Controls.Add(this.btn_exluirTurma);
            this.panel1.Controls.Add(this.btn_salvarEdicao);
            this.panel1.Controls.Add(this.btn_novaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 34);
            this.panel1.TabIndex = 31;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(658, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(116, 28);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimirTurma
            // 
            this.btn_imprimirTurma.Location = new System.Drawing.Point(492, 3);
            this.btn_imprimirTurma.Name = "btn_imprimirTurma";
            this.btn_imprimirTurma.Size = new System.Drawing.Size(160, 28);
            this.btn_imprimirTurma.TabIndex = 8;
            this.btn_imprimirTurma.Text = "Imprimir Turma";
            this.btn_imprimirTurma.UseVisualStyleBackColor = true;
            this.btn_imprimirTurma.Click += new System.EventHandler(this.btn_imprimirTurma_Click);
            // 
            // btn_exluirTurma
            // 
            this.btn_exluirTurma.Location = new System.Drawing.Point(304, 3);
            this.btn_exluirTurma.Name = "btn_exluirTurma";
            this.btn_exluirTurma.Size = new System.Drawing.Size(182, 28);
            this.btn_exluirTurma.TabIndex = 7;
            this.btn_exluirTurma.Text = "Excluir Turma";
            this.btn_exluirTurma.UseVisualStyleBackColor = true;
            this.btn_exluirTurma.Click += new System.EventHandler(this.btn_exluirTurma_Click);
            // 
            // btn_salvarEdicao
            // 
            this.btn_salvarEdicao.Location = new System.Drawing.Point(151, 3);
            this.btn_salvarEdicao.Name = "btn_salvarEdicao";
            this.btn_salvarEdicao.Size = new System.Drawing.Size(147, 28);
            this.btn_salvarEdicao.TabIndex = 6;
            this.btn_salvarEdicao.Text = "Salvar Edição";
            this.btn_salvarEdicao.UseVisualStyleBackColor = true;
            this.btn_salvarEdicao.Click += new System.EventHandler(this.btn_salvarEdicao_Click);
            // 
            // btn_novaTurma
            // 
            this.btn_novaTurma.Location = new System.Drawing.Point(3, 3);
            this.btn_novaTurma.Name = "btn_novaTurma";
            this.btn_novaTurma.Size = new System.Drawing.Size(142, 28);
            this.btn_novaTurma.TabIndex = 5;
            this.btn_novaTurma.Text = "Nova Turma";
            this.btn_novaTurma.UseVisualStyleBackColor = true;
            this.btn_novaTurma.Click += new System.EventHandler(this.btn_novaTurma_Click);
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(483, 98);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(282, 21);
            this.cb_professor.TabIndex = 1;
            // 
            // n_maxAlunos
            // 
            this.n_maxAlunos.Location = new System.Drawing.Point(483, 177);
            this.n_maxAlunos.Name = "n_maxAlunos";
            this.n_maxAlunos.Size = new System.Drawing.Size(99, 20);
            this.n_maxAlunos.TabIndex = 2;
            this.n_maxAlunos.ValueChanged += new System.EventHandler(this.n_maxAlunos_ValueChanged);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(612, 175);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(153, 21);
            this.cb_status.TabIndex = 3;
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(484, 241);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(281, 21);
            this.cb_horario.TabIndex = 4;
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(484, 76);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(51, 13);
            this.cm.TabIndex = 36;
            this.cm.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Máximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Horário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome Turma";
            // 
            // tb_dscTurma
            // 
            this.tb_dscTurma.Location = new System.Drawing.Point(484, 43);
            this.tb_dscTurma.Name = "tb_dscTurma";
            this.tb_dscTurma.Size = new System.Drawing.Size(281, 20);
            this.tb_dscTurma.TabIndex = 41;
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(487, 319);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(147, 20);
            this.tb_vagas.TabIndex = 42;
            this.tb_vagas.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Vagas Disponiveis";
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.tb_dscTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.n_maxAlunos);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_turmas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimirTurma;
        private System.Windows.Forms.Button btn_exluirTurma;
        private System.Windows.Forms.Button btn_salvarEdicao;
        private System.Windows.Forms.Button btn_novaTurma;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.NumericUpDown n_maxAlunos;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dscTurma;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.Label label5;
    }
}