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
    public partial class Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        LinkedList<string> eu = new LinkedList<string>();
        

        private void btn_logar_Click(object sender, EventArgs e)
        {
            
            string nomeusuario = tb_username.Text;
            string senhausuario = tb_senha.Text;

            if(nomeusuario =="" || senhausuario == "")
            {
                MessageBox.Show("Nome ou Senha errada");
                tb_username.Focus(); 
                return;
            }
            
            
            dt = Banco.login(nomeusuario,senhausuario);

            if(dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");

                form1.pb_ledLigado.Image = Properties.Resources.Led_verde;
                Globais.nivel =int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado =true;
                this.Close();
            }
            else {
                MessageBox.Show("usuario não encontrado");
            }

        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            

        
    }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
