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

namespace Projecto_Gestão_de_Academia
{
    

    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFoto;
        string destinoCompleto = "";
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> Stato= new Dictionary<string, string>();
            Stato.Add("A", "Activa");
            Stato.Add("B", "Bloqueado");
            Stato.Add("C", "Cancelado");

            cb_status.DataSource = new BindingSource(Stato, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            mtb_telefone.Enabled = true;
            cb_status.Enabled = true;
            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            tb_nome.Focus();
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_novo.Enabled = false;
            btn_selturma.Enabled = true;
            btn_selplano.Enabled = true;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
            btn_selturma.Enabled = false;
            btn_selplano.Enabled = false;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if(destinoCompleto == " ")
            {
                if(MessageBox.Show("Sem foto selecionada, deseja continuar?","Erro",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != " ")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);

                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar?", "Erro", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }



            string queryInsertAluno = string.Format(@"

                                 Insert into TABELA_ALUNOS
                                 (T_NOMEALUNO,T_TELEFONE,T_STATUS,N_IDTURMA,T_FOTO)

                                 Values  
                                 ('{0}','{1}','{2}',{3},'{4}')",tb_nome.Text,mtb_telefone.Text,cb_status.SelectedValue,tb_turma.Tag.ToString(),destinoCompleto.ToString());
           

            Banco.dml(queryInsertAluno);
            

            MessageBox.Show("novo aluno inserido");

            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            cb_status.SelectedIndex = 0;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_novo.Enabled = true;
            btn_selturma.Enabled = false;
            btn_selplano.Enabled = false;
            pb_foto.ImageLocation = destinoCompleto;
        }

        private void btn_selturma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma SELE = new F_SelecionarTurma(this);
            SELE.ShowDialog();
        }

        private void btn_addFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFoto;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo ja existe, deseja substituir?","Substituir",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pb_foto.ImageLocation = origemCompleto;
        }
    }
}
