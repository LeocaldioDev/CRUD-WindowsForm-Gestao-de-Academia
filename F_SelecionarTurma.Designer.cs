﻿namespace Projecto_Gestão_de_Academia
{
    partial class F_SelecionarTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_TURMA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TURMA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TURMA
            // 
            this.dgv_TURMA.AllowUserToAddRows = false;
            this.dgv_TURMA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TURMA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TURMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TURMA.EnableHeadersVisualStyles = false;
            this.dgv_TURMA.Location = new System.Drawing.Point(3, 2);
            this.dgv_TURMA.MultiSelect = false;
            this.dgv_TURMA.Name = "dgv_TURMA";
            this.dgv_TURMA.ReadOnly = true;
            this.dgv_TURMA.RowHeadersVisible = false;
            this.dgv_TURMA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TURMA.Size = new System.Drawing.Size(633, 422);
            this.dgv_TURMA.TabIndex = 31;
            this.dgv_TURMA.DoubleClick += new System.EventHandler(this.dgv_TURMA_DoubleClick);
            // 
            // F_SelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 426);
            this.Controls.Add(this.dgv_TURMA);
            this.Name = "F_SelecionarTurma";
            this.Text = "F_SelecionarTurma";
            this.Load += new System.EventHandler(this.F_SelecionarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TURMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TURMA;
    }
}