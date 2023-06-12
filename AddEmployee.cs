using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;

namespace Digitalizacion_3000_Empleados
{
    public partial class AddEmployee : Form
    {
        private string connectionString = "Data Source=D:\\CodeCraft\\Winodos forms (.NET Frameworks)\\Digitalizacion_3000_Empleados\\BaseDeDatos_Empleados.db; Version=3";
        private string rutaPdf;
        public AddEmployee()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // Verificar si la tabla "Empleados" ya existe
            bool tableExists = CheckIfTableExists("Empleados");

            if (!tableExists)
            {
                // Crear la tabla "Empleados" si no existe
                CreateEmployeesTable();
            }

        }

       

        private bool CheckIfTableExists(string tableName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Consulta para verificar si la tabla ya existe
                string query = "SELECT name FROM sqlite_master WHERE type='table' AND name=@TableName";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TableName", tableName);
                    object result = command.ExecuteScalar();
                    return (result != null && result.ToString() == tableName);
                }
            }
        }

        private void CreateEmployeesTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Consulta para crear la tabla "Empleados"
                string createTableQuery = "CREATE TABLE Empleados (Id INTEGER PRIMARY KEY, Legajo VARCHAR (8), Apellido_Nombre TEXT, Imagen IMAGE, Pdf BLOB)";



                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery(); // Ejecutar la consulta para crear la tabla
                }

                connection.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sistem3000 formSistem3000 = new Sistem3000();
            formSistem3000.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Id")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Id";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Legajo")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Legajo";
                textBox2.ForeColor = Color.DimGray;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Apellido y Nombre")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Apellido y Nombre";
                textBox3.ForeColor = Color.DimGray;
            }
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void AddEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string id = textBox1.Text;
            string legajo = textBox2.Text;
            string apellidoNombre = textBox3.Text;
            Image imagen = pictureBox1.Image;
            byte[] pdfBytes = File.ReadAllBytes(rutaPdf);

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para insertar los datos en la tabla "Empleados"
                    string insertQuery = "INSERT INTO Empleados (Id, Legajo, Apellido_Nombre, Imagen, Pdf) VALUES (@Id, @Legajo, @ApellidoNombre, @Imagen, @Pdf)";

                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Legajo", legajo);
                        command.Parameters.AddWithValue("@ApellidoNombre", apellidoNombre);
                        command.Parameters.AddWithValue("@Imagen", ImageToByteArray(imagen));
                        command.Parameters.AddWithValue("@Pdf", pdfBytes);

                        command.ExecuteNonQuery(); // Ejecutar la consulta de inserción
                    }

                    connection.Close();
                }

                MessageBox.Show("Datos insertados correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos en la base de datos: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagenes (*.jpg, *jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                MostrarImage(rutaImagen);
            }
        }
        private void MostrarImage (string rutaImagen)
        {
            if(!string.IsNullOrEmpty(rutaImagen))
            {
                Image imageOriginal = Image.FromFile(rutaImagen);

                Image imagenRedimencioada = ResizeImage(imageOriginal, pictureBox1.Width, pictureBox1.Height);

                pictureBox1.Image = imagenRedimencioada;
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using(Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return bitmap;
        }

        private byte[] ImageToByteArray(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream()) 
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.Filter = "Archivos PDF (*.pdf) | *.pdf";

            if(openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                rutaPdf = openFileDialog2.FileName;
            }
        }
    }
}
