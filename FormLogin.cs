using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaodeVendas
{
    partial class FormLogin : Form
    {
        public FormLogin( )
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                Controle c = new Controle();
                Form1_Gestor fg = new Form1_Gestor( );
                this.Hide();
                fg.ShowDialog( );
            }
            else
            { 
                MessageBox.Show( "Usuario ou senha incorretos!", null ,MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
