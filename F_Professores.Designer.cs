namespace Projecto_Gestão_de_Academia
{
    partial class F_Professores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_idProfessor = new System.Windows.Forms.TextBox();
            this.tb_nomeProfessor = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_novoProfessor = new System.Windows.Forms.Button();
            this.btn_salvarProfessor = new System.Windows.Forms.Button();
            this.btn_excluirProfessir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.EnableHeadersVisualStyles = false;
            this.dgv_professores.Location = new System.Drawing.Point(12, 55);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.RowHeadersVisible = false;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(473, 336);
            this.dgv_professores.TabIndex = 0;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirProfessir);
            this.panel1.Controls.Add(this.btn_salvarProfessor);
            this.panel1.Controls.Add(this.btn_novoProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 41);
            this.panel1.TabIndex = 1;
            // 
            // tb_idProfessor
            // 
            this.tb_idProfessor.Location = new System.Drawing.Point(13, 23);
            this.tb_idProfessor.Name = "tb_idProfessor";
            this.tb_idProfessor.ReadOnly = true;
            this.tb_idProfessor.Size = new System.Drawing.Size(72, 20);
            this.tb_idProfessor.TabIndex = 2;
            // 
            // tb_nomeProfessor
            // 
            this.tb_nomeProfessor.Location = new System.Drawing.Point(103, 22);
            this.tb_nomeProfessor.Name = "tb_nomeProfessor";
            this.tb_nomeProfessor.Size = new System.Drawing.Size(255, 20);
            this.tb_nomeProfessor.TabIndex = 3;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(365, 22);
            this.mtb_telefone.Mask = "(+244)999999999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(120, 20);
            this.mtb_telefone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // btn_novoProfessor
            // 
            this.btn_novoProfessor.Location = new System.Drawing.Point(16, 6);
            this.btn_novoProfessor.Name = "btn_novoProfessor";
            this.btn_novoProfessor.Size = new System.Drawing.Size(103, 23);
            this.btn_novoProfessor.TabIndex = 0;
            this.btn_novoProfessor.Text = "Novo Professor";
            this.btn_novoProfessor.UseVisualStyleBackColor = true;
            this.btn_novoProfessor.Click += new System.EventHandler(this.btn_novoProfessor_Click);
            // 
            // btn_salvarProfessor
            // 
            this.btn_salvarProfessor.Location = new System.Drawing.Point(138, 6);
            this.btn_salvarProfessor.Name = "btn_salvarProfessor";
            this.btn_salvarProfessor.Size = new System.Drawing.Size(104, 23);
            this.btn_salvarProfessor.TabIndex = 1;
            this.btn_salvarProfessor.Text = "Salvar";
            this.btn_salvarProfessor.UseVisualStyleBackColor = true;
            this.btn_salvarProfessor.Click += new System.EventHandler(this.btn_salvarProfessor_Click);
            // 
            // btn_excluirProfessir
            // 
            this.btn_excluirProfessir.Location = new System.Drawing.Point(259, 6);
            this.btn_excluirProfessir.Name = "btn_excluirProfessir";
            this.btn_excluirProfessir.Size = new System.Drawing.Size(103, 23);
            this.btn_excluirProfessir.TabIndex = 2;
            this.btn_excluirProfessir.Text = "Excluir";
            this.btn_excluirProfessir.UseVisualStyleBackColor = true;
            this.btn_excluirProfessir.Click += new System.EventHandler(this.btn_excluirProfessir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(368, 6);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(117, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // F_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_nomeProfessor);
            this.Controls.Add(this.tb_idProfessor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_professores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Professores";
            this.Load += new System.EventHandler(this.F_Professores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_idProfessor;
        private System.Windows.Forms.TextBox tb_nomeProfessor;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirProfessir;
        private System.Windows.Forms.Button btn_salvarProfessor;
        private System.Windows.Forms.Button btn_novoProfessor;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}