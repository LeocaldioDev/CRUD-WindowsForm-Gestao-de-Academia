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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                     Select
                        N_IDHORARIO as 'ID',
                        T_DSCHORARIO as 'Horario'
                     From
                        TABELA_HORARIO Order by T_DSCHORARIO     
                ";

            dgv_horario.DataSource = Banco.dql(vquery);
            dgv_horario.Columns[0].Width = 60;
            dgv_horario.Columns[1].Width = 170;
        }

        private void dgv_horario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int contLinhas = dgv.SelectedRows.Count;

            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string vquery = @"
                     Select
                        *
                     From
                        TABELA_HORARIO 
                        where N_IDHORARIO =" + vid;

                dt = Banco.dql(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_horario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO").ToString();
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            mtb_horario.Clear();
            mtb_horario.Focus();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_id.Text == "")
            {
                vquery = "insert into TABELA_HORARIO (T_DSCHORARIO) values ('" + mtb_horario.Text+"')";
                
            }
            else
            {
                vquery = "update TABELA_HORARIO set T_DSCHORARIO ='" + mtb_horario.Text + "' where N_IDHORARIO ="+tb_id.Text;
            }
            Banco.dml(vquery);
            vquery = @"
                     Select
                        N_IDHORARIO as 'ID',
                        T_DSCHORARIO as 'Horario'
                     From
                        TABELA_HORARIO 
                        order by T_DSCHORARIO
                ";

                dgv_horario.DataSource = Banco.dql(vquery);
           
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Conformar Exclusão?", "Excluir?", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes) {

                string vquery = "Delete from TABELA_HORARIO where N_IDHORARIO="+ tb_id.Text;

                Banco.dml(vquery);

                dgv_horario.Rows.Remove(dgv_horario.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
