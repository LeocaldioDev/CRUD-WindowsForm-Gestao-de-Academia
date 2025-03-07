using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Projecto_Gestão_de_Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;


        // FUnçoes Genericas
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source ="+Globais.caminhoBanco + Globais.nomeBanco);
            
            conexao.Open();

            return conexao;
        }

        public static DataTable dql(string sql)  // função generica para comandos de Consulta (Select)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            } catch (Exception ex){
                
                throw ex;

            }

        }



        public static void dml(string q, string msgOK = null,string msgErro = null)  // função generica para Manipulação (Insert,Delete,Update)
        {


            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK!= null)
                {
                    MessageBox.Show(msgOK);
                }

            }

            catch (Exception ex)

            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgOK);
                }
                throw ex;
            }
        }



        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText ="Select * from TABELA_USUARIO";
                    da = new SQLiteDataAdapter(cmd.CommandText,vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;

                
               
            }
            catch(Exception ex)
            {
                
                throw ex;
            }


        }





        //Funções do form F_NovoUsuario

        public static void NovoUsuario(Usuario usu)
        {
            
            if (existeUsername(usu))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd =vcon.CreateCommand();
                cmd.CommandText = "Insert into TABELA_USUARIO(T_NOMEUSUARIO,T_USERNAME,T_SENHAUSUARIO,T_STATUSUSUARIO,N_NIVELUSUARIO) Values(@nome,@username,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("@nome",usu.nome);
                cmd.Parameters.AddWithValue("@username", usu.username);
                cmd.Parameters.AddWithValue("@senha", usu.senha);
                cmd.Parameters.AddWithValue("@status", usu.status);
                cmd.Parameters.AddWithValue("@nivel", usu.nivel);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuario Inserido");
                vcon.Close();

            }
            catch
            {
                MessageBox.Show("erro ao gravar novo usuario");
            }
        }

        public static DataTable login(string nomeusuario, string senhausuario)
        {
            SQLiteDataAdapter adapta;
            DataTable saida = new DataTable();
            var conexao = ConexaoBanco();
            var cmd = conexao.CreateCommand();
            cmd.CommandText = "select * from TABELA_USUARIO where T_USERNAME = @nome and T_SENHAUSUARIO =@senha";
            cmd.Parameters.AddWithValue("@nome", nomeusuario);
            cmd.Parameters.AddWithValue("@senha", senhausuario);
            adapta = new SQLiteDataAdapter(cmd);
            adapta.Fill(saida);
            conexao.Close();
            return saida;
        }

        private static bool existeUsername(Usuario u)
        {
            bool res=true;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
                   cmd.CommandText = "Select T_USERNAME from TABELA_USUARIO where T_USERNAME = '"+u.username+"'";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }



             return res;
 

        }

        //Fim Funções do form F_NovoUsuario



        //Funções do FOrm F_GestaoUsuarios

        public static DataTable ObterTodosUsuariosIDNomes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try{
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO AS 'ID',T_NOMEUSUARIO AS 'NOME USUARIO' FROM TABELA_USUARIO";
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }

            catch(Exception ex) 
            
            {
                throw ex;
            }

        }






        public static DataTable ObterDadosUsuarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM TABELA_USUARIO WHERE N_IDUSUARIO = @id";
                cmd.Parameters.AddWithValue("@id", id);
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }

            catch (Exception ex)

            {
                throw ex;
            }

        }




        public static void ActualizarUsuario(Usuario u)
        {
           

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE TABELA_USUARIO SET T_NOMEUSUARIO = @nome, T_USERNAME = @username, T_SENHAUSUARIO = @senha, T_STATUSUSUARIO = @status, N_NIVELUSUARIO = @nivel WHERE N_IDUSUARIO = @id";

                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.ExecuteNonQuery();
                vcon.Close();
                
            }

            catch (Exception ex)

            {
                throw ex;
            }

        }


        public static void DeletarUsuarios(string id)
        {
           

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM TABELA_USUARIO WHERE N_IDUSUARIO = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }

            catch (Exception ex)

            {
                throw ex;
            }

        }
        //Fim Funções do form F_GestaoUsuarios

    }
}
