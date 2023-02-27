using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoEscanhos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=DESKTOP-43OTBI3\\SQLEXPRESS;database=escanhos; integrated security=true");

        private void ingresar_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                string con = "select * from usuario where usuario='"+usuario.Text+"' and contrasena='" +contrasenha.Text+"'";
                SqlCommand comando = new SqlCommand(con, connection);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {
                    MessageBox.Show("Bienvenido/a");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
                connection.Close();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            
        }
    }
}
