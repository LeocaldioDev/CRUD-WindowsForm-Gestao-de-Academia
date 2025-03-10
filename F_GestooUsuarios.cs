﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Gestão_de_Academia
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIDNomes();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 200;
        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario n = new F_NovoUsuario();
            n.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIDNomes();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int countlinhas = dgv.SelectedRows.Count;
            DataTable dt = new DataTable();


            if (countlinhas > 0)
            {
                
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuarios(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO");
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME");
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO");
            }
        }

        private void btn_fecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SalvarAlterações_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();

            u.id =Convert.ToInt32(tb_id.Text);
            u.nome = tb_nome.Text;
            u.username = tb_username.Text;
            u.senha = tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel = Convert.ToInt32(n_nivel.Value);

            Banco.ActualizarUsuario(u);
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIDNomes();
            dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];

        }

        private void btn_ExcluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                Banco.DeletarUsuarios(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }
    }
}
