using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Digitalizacion_3000_Empleados
{
    public partial class Sistem3000 : Form
    {
        private string selectedPDFPath;
        public Sistem3000()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Sistem3000_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
            this.Hide();
        }

        private void agregarEmpleado_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Hide();
        }

        private void actualizarTabla_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=D:\\CodeCraft\\Winodos forms (.NET Frameworks)\\Digitalizacion_3000_Empleados\\BaseDeDatos_Empleados.db; Version=3;";
                string query = "SELECT Id, Legajo, Apellido_Nombre FROM Empleados";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable; ;
                        }
                    }
                    connection.Close();
                }

            }
            catch(Exception ex)
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Sistem3000_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //   DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
              //  string pdfPath = row.Cells["PDFColumn"].Value.ToString();
                //selectedPDFPath = pdfPath;
            //}
        }

        private void descargarPdf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedPDFPath))
            {
                byte[] pdfBytes = File.ReadAllBytes(selectedPDFPath);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF (*.pdf) | *.pdf";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, pdfBytes);
                    MessageBox.Show("PDF descargado correctamente");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun PDF");

            }
        }
       
    }
}
