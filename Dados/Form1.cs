using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private string directorioImagenes = @"C:\Users\SCP\source\repos\Dados\Dados\imagenes\";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDado1_Click_1(object sender, EventArgs e)
        {
            int numeroAleatorio1 = random.Next(1, 7);
            int numeroAleatorio2 = random.Next(1, 7);

            string nombreImagen1 = numeroAleatorio1 + ".png";
            string nombreImagen2 = numeroAleatorio2 + ".png";

            string rutaImagen1 = Path.Combine(directorioImagenes, nombreImagen1);
            string rutaImagen2 = Path.Combine(directorioImagenes, nombreImagen2);

            dado1.ImageLocation = rutaImagen1;
            dado2.ImageLocation = rutaImagen2;

            string nombreDado1 = Path.GetFileName(rutaImagen1);
            string nombreDado2 = Path.GetFileName(rutaImagen2);

            dataGridViewResultados.Rows.Add($"{numeroAleatorio1} - {numeroAleatorio2}");
        }
    }
}
