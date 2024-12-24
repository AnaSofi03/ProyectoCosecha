using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QRCoder;

namespace GeneradorQr1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }  
        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string dni = txtDNI.Text;
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;

            // Validar que los TextBox no estén vacíos
            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, ingrese todos los datos (DNI, Nombre, Apellido).");
                return;
            }

            // Crear el contenido para el QR
            string data = $"{dni}|{nombre} {apellido}";

            // Generar el código QR con QRCoder
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCode.GetGraphic(5);

            // Mostrar el QR en el PictureBox
            using (var ms = new MemoryStream(qrCodeBytes))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }

            // Guardar el QR en un archivo
            File.WriteAllBytes("codigoQR.png", qrCodeBytes);
        }
    }
}
