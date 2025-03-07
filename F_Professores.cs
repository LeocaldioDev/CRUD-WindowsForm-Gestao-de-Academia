using System;
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
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }
        private void actualizarGridView()
        {
            string vquery = @"
                   Select
                    N_IDPROFESSOR as 'ID',
                    T_NOMEPROFESSOR as 'Professor',
                    T_TELEFONE as 'Telefone'
                   From
                      TABELA_PROFESSORES order by T_NOMEPROFESSOR
                ";


            dgv_professores.DataSource = Banco.dql(vquery);
        }
        private void F_Professores_Load(object sender, EventArgs e)
        {
            actualizarGridView();
            dgv_professores.Columns[0].Width =60;
            dgv_professores.Columns[1].Width = 200;
            dgv_professores.Columns[2].Width = 110;
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = new DataTable();
            if(dgv.SelectedRows.Count > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                String vquery = @"Select * from TABELA_PROFESSORES where N_IDPROFESSOR = " + vid;

                dt = Banco.dql(vquery);

                tb_idProfessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_nomeProfessor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }


            
        }

        private void btn_novoProfessor_Click(object sender, EventArgs e)
        {
            tb_idProfessor.Clear();
            tb_nomeProfessor.Clear();
            mtb_telefone.Clear();
            tb_nomeProfessor.Focus();
        }

        private void btn_salvarProfessor_Click(object sender, EventArgs e)
        {
          
            int linha = dgv_professores.SelectedRows[0].Index;
            DataTable dt = new DataTable();
            string vquery;
            if (string.IsNullOrEmpty(tb_idProfessor.Text))
            {
                vquery = @"Insert into TABELA_PROFESSORES (T_NOMEPROFESSOR,T_TELEFONE) values ('"+tb_nomeProfessor.Text+"','"+mtb_telefone.Text+"')";
            }
            else
            {
                vquery = @"Update TABELA_PROFESSORES set T_NOMEPROFESSOR ='"+tb_nomeProfessor.Text+ "',T_TELEFONE='"+mtb_telefone.Text+ "' where N_IDPROFESSOR =" +tb_idProfessor.Text;
            }
            Banco.dml(vquery);
            actualizarGridView();
            dgv_professores.CurrentCell = dgv_professores[0,linha];


        }

        private void btn_excluirProfessir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tens a certeza?", "Excluir?", MessageBoxButtons.YesNo);
            
            if (res == DialogResult.Yes)
            {
                string vquery = "Delete from TABELA_PROFESSORES where N_IDPROFESSOR =" + tb_idProfessor.Text;
            

            Banco.dml(vquery);
            actualizarGridView();
        
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
