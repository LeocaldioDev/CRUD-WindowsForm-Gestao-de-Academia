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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login l = new Login(this);
            l.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Login l = new Login(this);
            l.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";

            pb_ledLigado.Image = Properties.Resources.Led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void AbrirForm(int nivel, Form f)
        {

            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario Logado");
            }


        }
        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f = new F_NovoUsuario();
            AbrirForm(2, f);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios ge = new F_GestaoUsuarios();
            AbrirForm(1, ge);
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios h = new F_Horarios();
            AbrirForm(2, h);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professores pf = new F_Professores();

            AbrirForm(2, pf);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas tm = new F_GestaoTurmas();
            AbrirForm(2, tm);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno na = new F_NovoAluno();
            AbrirForm(1, na);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos gest = new F_GestaoAlunos();
            AbrirForm(2, gest);
        }
    }
    
}
