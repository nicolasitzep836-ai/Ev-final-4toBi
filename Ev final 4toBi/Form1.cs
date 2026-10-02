using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_final_4toBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextUsuario_TextChanged(object sender, EventArgs e)
        {
            if(TextUsuario.Text == "Nicolas" && TextContraseña.Text =="40")
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            else 
            {
                MessageBox.Show("sus datos son invalidos por favor intente de nuevo");
            }
        }
}
}
