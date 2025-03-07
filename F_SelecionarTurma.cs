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
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno fnovousuario;
        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();
            fnovousuario = f; 
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurma = string.Format(@"
                                            select
                                                
                                                tbt.N_IDTURMA as 'ID',
                                                tbt.T_DSCTURMA as 'Turma',
                                                tbh.T_DSCHORARIO as 'Horário',
                                                tbp.T_NOMEPROFESSOR as 'Professor',
                                                tbt.N_MAXALUNOS as 'Max.Alunos',

                                            (Select
                                                    Count(N_IDALUNOS)
                                             From 
                                                TABELA_ALUNOS as tba
                                            Where
                                                tba.N_IDTURMA = tbt.N_IDTURMA and tba.T_STATUS = 'A') as 'Quantidade Alunos'
                                                
                                                From

                                                TABELA_TURMA as tbt inner join TABELA_PROFESSORES as tbp
                                                on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR 

                                                inner join
                                                TABELA_HORARIO as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
                                                ");

            dgv_TURMA.DataSource = Banco.dql(queryTurma);





        }

        private void dgv_TURMA_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdeAlunos = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAlunos = int.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            if(qtdeAlunos >= maxAlunos)
            {
                MessageBox.Show("Não há vagas nesta turma");
            }
            else
            {
                fnovousuario.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                fnovousuario.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
