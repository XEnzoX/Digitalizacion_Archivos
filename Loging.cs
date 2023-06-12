using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Digitalizacion_3000_Empleados
{
    public partial class Loging : Form
    {
       
        public Loging()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textuser_Enter(object sender, EventArgs e)
        {
            if(textuser.Text == "USER")
            {
                textuser.Text = "";
                textuser.ForeColor = Color.LightGray;
            }
        }

        private void textuser_Leave(object sender, EventArgs e)
        {
            if(textuser.Text == "")
            {
                textuser.Text = "USER";
                textuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "PASSWORD")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.Text = "PASSWORD";
                txtpass.ForeColor = Color.DarkGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnclosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Loging_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }

        private void logg_Click(object sender, EventArgs e)
        {
            if(textuser.Text == "Admin" && txtpass.Text == "12345")
            {
                Sistem3000 formSistem3000 = new Sistem3000();
                formSistem3000.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de Usuario o Contraseña incorrectos");
            }
        }
    }
}
