﻿namespace Projecto_Gestão_de_Academia
{
    partial class F_NovoAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_selturma = new System.Windows.Forms.Button();
            this.btn_selplano = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_addFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(16, 39);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(369, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(430, 38);
            this.mtb_telefone.Mask = "(244)999999999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(147, 20);
            this.mtb_telefone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(16, 117);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(233, 21);
            this.cb_status.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turma";
            // 
            // tb_turma
            // 
            this.tb_turma.Enabled = false;
            this.tb_turma.Location = new System.Drawing.Point(295, 117);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(265, 20);
            this.tb_turma.TabIndex = 7;
            // 
            // tb_plano
            // 
            this.tb_plano.Enabled = false;
            this.tb_plano.Location = new System.Drawing.Point(16, 197);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(311, 20);
            this.tb_plano.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plano";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 34);
            this.panel1.TabIndex = 10;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(624, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(146, 28);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(319, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(146, 28);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(167, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(146, 28);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(146, 28);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_selturma
            // 
            this.btn_selturma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_selturma.Enabled = false;
            this.btn_selturma.Location = new System.Drawing.Point(566, 115);
            this.btn_selturma.Name = "btn_selturma";
            this.btn_selturma.Size = new System.Drawing.Size(30, 23);
            this.btn_selturma.TabIndex = 11;
            this.btn_selturma.Text = "...";
            this.btn_selturma.UseVisualStyleBackColor = false;
            this.btn_selturma.Click += new System.EventHandler(this.btn_selturma_Click);
            // 
            // btn_selplano
            // 
            this.btn_selplano.Enabled = false;
            this.btn_selplano.Location = new System.Drawing.Point(333, 195);
            this.btn_selplano.Name = "btn_selplano";
            this.btn_selplano.Size = new System.Drawing.Size(30, 23);
            this.btn_selplano.TabIndex = 12;
            this.btn_selplano.Text = "...";
            this.btn_selplano.UseVisualStyleBackColor = true;
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(632, 61);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(138, 157);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 35;
            this.pb_foto.TabStop = false;
            // 
            // btn_addFoto
            // 
            this.btn_addFoto.Location = new System.Drawing.Point(624, 19);
            this.btn_addFoto.Name = "btn_addFoto";
            this.btn_addFoto.Size = new System.Drawing.Size(146, 28);
            this.btn_addFoto.TabIndex = 4;
            this.btn_addFoto.Text = "Add Foto";
            this.btn_addFoto.UseVisualStyleBackColor = true;
            this.btn_addFoto.Click += new System.EventHandler(this.btn_addFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 278);
            this.Controls.Add(this.btn_addFoto);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.btn_selplano);
            this.Controls.Add(this.btn_selturma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_selturma;
        private System.Windows.Forms.Button btn_selplano;
        public System.Windows.Forms.TextBox tb_turma;
        public System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btn_addFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}