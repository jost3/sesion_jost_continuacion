using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_corrido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingreso_Click(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = nomb.Text;
            password = contra.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LDGQBD;Initial Catalog=login;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "select user_log,pass_log from inicio_sesion where user_log = '" + usuario + "' AND pass_log = '" + password + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + usuario);
                this.Hide();
                Form3 a1 = new Form3();
                a1.Show();
            }
            else
            {
                MessageBox.Show("No existe  este usuario" + usuario);
            }
        }

        private void nomb_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void nomb_Leave(object sender, EventArgs e)
        {
            if (nomb.Text == "")
            {
                nomb.Text = "ingrese su usuario";
                nomb.ForeColor = Color.Black;
            }
        }

        private void nomb_Enter(object sender, EventArgs e)
        {
            if (nomb.Text == "ingrese su usuario")
            {
                nomb.Text = "";
                nomb.ForeColor = Color.Black;
            }
        }

        private void contra_Leave(object sender, EventArgs e)
        {
            if (contra.Text == "")
            {
                contra.Text = "ingrese su contraseña";
                contra.ForeColor = Color.Black;
            }
        }

        private void contra_Enter(object sender, EventArgs e)
        {
            if (contra.Text == "ingrese su contraseña")
            {
                contra.Text = "";
                contra.ForeColor = Color.Black;
            }
        }

        private void mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contra.Text))
            {
                contra.UseSystemPasswordChar = false;
            }
            else
            {
                contra.UseSystemPasswordChar = true;
            }
        }

        private void cerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            Form2 r = new Form2();
            r.Show();
            this.Hide();
        }
    }
    }

