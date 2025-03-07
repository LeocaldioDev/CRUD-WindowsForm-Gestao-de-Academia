using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projecto_Gestão_de_Academia
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; // 0= Padrão, 1= Edição, 2= Inserção
        string vqueryDGV = "";
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {

            vqueryDGV = @"
                            
                           Select
                             tbt.N_IDTURMA as 'ID',
                             tbt.T_DSCTURMA as 'Turma',
                             tbh.T_DSCHORARIO as 'Horario'
                            From
                               TABELA_TURMA as tbt inner join TABELA_HORARIO as tbh
                                on tbh.N_IDHORARIO = tbt.N_IDTURMA
                                ";

            dgv_turmas.DataSource = Banco.dql(vqueryDGV);

            dgv_turmas.Columns[0].Width = 70;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 120;


            //popular combobox professores

            string vqueryprofessore = @"
                            
                           Select
                             N_IDPROFESSOR,
                            T_NOMEPROFESSOR
                            From
                               TABELA_PROFESSORES order by N_IDPROFESSOR
                                ";

            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryprofessore);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";


            //popular combobox status (Ativa =A , Paralisada =P , Cancelada= C)

            Dictionary<string, string> st = new Dictionary<string, string>();

            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");

            cb_status.Items.Clear();

            cb_status.DataSource = new BindingSource(st, null);

            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";


            //Popular Combobox horários

            string vqueryhorario = @"
                            
                           Select
                             *
                            From
                               TABELA_HORARIO order by T_DSCHORARIO
                                ";

            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryhorario);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";
        }

        //Calculos de vagas

        private string numerodeVagas()
        {
            string queryVagas = string.Format(@"
                                             Select
                                                count(N_IDALUNOS) as 'contVagas'
                                             From
                                                TABELA_ALUNOS
                                             Where
                                                T_STATUS ='A' and N_IDTURMA = {0}",idSelecionado);

            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            

            DataGridView dgv = (DataGridView)sender;
            int contLinha = dgv.SelectedRows.Count;

            if(contLinha > 0)
            {
                modo = 1;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();

                string vqueryCampos = @"
                                   Select
                                        T_DSCTURMA,
                                        N_IDPROFESSOR,
                                        N_IDHORARIO,
                                        N_MAXALUNOS,
                                        T_STATUS
                                        
                                    From TABELA_TURMA Where N_IDTURMA = " + idSelecionado;



                DataTable dt = Banco.dql(vqueryCampos);

                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");      
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR");
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");
            }
            tb_vagas.Text = numerodeVagas();
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex= -1;
            modo = 2;
            tb_dscTurma.Focus();
        }

        private void btn_salvarEdicao_Click(object sender, EventArgs e)
        {
            if (modo != 0) { 
            int linha = dgv_turmas.SelectedRows[0].Index;
            string queryTurma = "";
                string msg = "";
                if(modo == 1) {
           queryTurma = string.Format(@"
                                   Update TABELA_TURMA set
                                        T_DSCTURMA='{0}',
                                        N_IDPROFESSOR={1},
                                        N_IDHORARIO={2},
                                        N_MAXALUNOS={3},
                                        T_STATUS='{4}'
                                        
                                     Where N_IDTURMA ={5}", tb_dscTurma.Text,cb_professor.SelectedValue,cb_horario.SelectedValue,Int32.Parse(Math.Round(n_maxAlunos.Value,0).ToString()),cb_status.SelectedValue, idSelecionado);
                  
                    msg = "Campo Actualizado";
                }
                else
                {
                   
                    queryTurma = string.Format(@"
                            Insert into TABELA_TURMA
                                        (T_DSCTURMA,
                                        N_IDPROFESSOR,
                                        N_IDHORARIO,
                                        N_MAXALUNOS,
                                        T_STATUS)
                                    Values('{0}',{1},{2},{3},'{4}')", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                   
                    msg = "Campo Inserido";
                }

                Banco.dml(queryTurma);
                if(modo == 1)
                {
            dgv_turmas[1, linha].Value = tb_dscTurma.Text;
            dgv_turmas[2, linha].Value = cb_horario.Text;
                    MessageBox.Show(msg);
                }
                else
                {
                    dgv_turmas.DataSource = Banco.dql(vqueryDGV);
                }
               
            }

        }

        private void btn_exluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes) {

                string queryExcluirTurma = string.Format(@"
                                        Delete
                                        from
                                        TABELA_TURMA
                                        where 
                                        N_IDTURMA ={0} ",idSelecionado);

                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void n_maxAlunos_ValueChanged(object sender, EventArgs e)
        {
            tb_vagas.Text = numerodeVagas();
        }

        private void btn_imprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.conexao+ @"\Turma.pdf";
            FileStream arquvo =new FileStream(nomeArquivo,FileMode.Create);

            Document doc = new Document(PageSize.A4);

            PdfWriter escritorPDF = PdfWriter.GetInstance(doc,arquvo);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.conexao+@"\logo.jpg");
            logo.ScaleToFit(200f, 170f);
            logo.Alignment = Element.ALIGN_LEFT;
            // logo.SetAbsolutePosition(100f, 700f); //x, -y

            string dados = "";

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de Turmas \n\n");


            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("\nProjecto Academia -- Aprendendo c#\n");

            PdfPTable tabela = new PdfPTable(3);
            tabela.DefaultCell.FixedHeight = 20;

            PdfPCell celula1 = new PdfPCell(new Phrase("ID Turma"));
            celula1.BackgroundColor = BaseColor.ORANGE;

            tabela.AddCell(celula1);
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horario"));

            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();



            DialogResult res = MessageBox.Show("Dseja abrir o Relatório?", "Relatório", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.conexao+ @"\Turma.pdf");
            }
            

        }
    }
}
