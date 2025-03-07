using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Projecto_Gestão_de_Academia
{
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV = "";
        string vqueryCampos = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma ="";
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"

                       select
                        N_IDALUNOS as 'ID',
                        T_NOMEALUNO as 'Aluno'
                       from
                        TABELA_ALUNOS";
            dgv_aluno.DataSource = Banco.dql(vqueryDGV);
            dgv_aluno.Columns[0].Width = 40;
            dgv_aluno.Columns[1].Width = 120;

            tb_nome.Text = dgv_aluno.Rows[dgv_aluno.SelectedRows[0].Index].Cells[1].Value.ToString();


            // popular combobox Turmas

            string vqueryTUrmas = @"
                                    Select    
                                       N_IDTURMA,
                                       ('Vagas: '||((N_MAXALUNOS)-( Select count (tba.N_IDALUNOS) From TABELA_ALUNOS as tba where tba.T_STATUS = 'A' and tba.N_IDTURMA = N_IDTURMA))
                                       || ' /Turma: ' || T_DSCTURMA ) as 'Turma'
                                   From  
                                        TABELA_TURMA
                                    order by N_IDTURMA
                                     ";

            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.dql(vqueryTUrmas);
            cb_turma.DisplayMember = "Turma";
            cb_turma.ValueMember = "N_IDTURMA";

            // Popular Combobox Status ("Ativo = A, Bloqueado = B, Cancelado = C")

            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Activado");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");

            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turma.Text;
            turmaAtual = cb_turma.Text;
            idSelecionado = dgv_aluno.Rows[0].Cells[0].Value.ToString();

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvarEdicao_Click(object sender, EventArgs e)
        {
            turma = cb_turma.Text;
            
            if (turmaAtual == turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma Selecionada, seleciona outra turma");
                    cb_turma.Focus();
                    return;
                }
                linha = dgv_aluno.SelectedRows[0].Index;
                string queryAtualizarAluno = string.Format(@" Update
                                                                TABELA_ALUNOS
                                                               set
                                                                T_NOMEALUNO ='{0}',
                                                                T_TELEFONE ='{1}',
                                                                T_STATUS='{2}',
                                                                N_IDTURMA= {3}
                                                             where
                                                                N_IDALUNOS = '{4}'", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turma.SelectedValue,idSelecionado);
                Banco.dml(queryAtualizarAluno);
                dgv_aluno[1, linha].Value = tb_nome.Text;
            }
        }
        private void btn_ExcluirAluno_Click(object sender, EventArgs e)
        {
        
            if(MessageBox.Show("Confirmar Exclusão?","Excluir",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(pb_foto.ImageLocation))
                {
                    File.Delete(pb_foto.ImageLocation);
                }
                string vqueryExcluirAluno = string.Format(@"Delete From TABELA_ALUNOS where  N_IDALUNOS = '{0}'",idSelecionado);

                Banco.dml(vqueryExcluirAluno);
                dgv_aluno.Rows.Remove(dgv_aluno.CurrentRow);                 
                                                            
                                                            
            }
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if(dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();

                vqueryCampos = string.Format(@"
select
N_IDALUNOS,
T_NOMEALUNO,
T_TELEFONE,
T_STATUS,
N_IDTURMA,
T_FOTO
From
TABELA_ALUNOS where N_IDALUNOS ='{0}'",idSelecionado);


                DataTable dt = Banco.dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_turma.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");
                pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");

                turmaAtual = cb_turma.Text;
            }
        }

        private void btn_imprimirCarteirinha_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dtTurmas = Banco.dql(vqueryCampos);
                FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                Document Doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(Doc,arquivo);

               
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(dtTurmas.Rows[0].Field<string>("T_FOTO"));
                logo.ScaleToFit(200f, 170f);
                logo.Alignment = Element.ALIGN_LEFT;
                // logo.SetAbsolutePosition(100f, 700f); //x, -y

                string dados = "";

                Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)FontStyle.Bold));
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add("Informações Aluno \n\n");

                PdfPTable tabela = new PdfPTable(4);
                tabela.DefaultCell.FixedHeight = 20;

               
                tabela.AddCell("N_IDALUNOS");
                tabela.AddCell("T_NOMEALUNO");
                tabela.AddCell("T_TELEFONE");
                tabela.AddCell("T_STATUS");
                


                for (int i = 0; i < dtTurmas.Rows.Count; i++)
                {
                    tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("N_IDALUNOS").ToString());
                    tabela.AddCell(dtTurmas.Rows[i].Field<string>("T_NOMEALUNO"));
                    tabela.AddCell(dtTurmas.Rows[i].Field<string>("T_TELEFONE"));
                    tabela.AddCell(dtTurmas.Rows[i].Field<string>("T_STATUS"));

                }

                Doc.Open();
                Doc.Add(logo);
                Doc.Add(paragrafo1);
                Doc.Add(tabela);
               
                Doc.Close();

            }
        }
    }
}
