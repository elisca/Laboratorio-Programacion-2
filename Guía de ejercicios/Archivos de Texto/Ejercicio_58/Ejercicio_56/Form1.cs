using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        string ultimaRuta;
        bool archivoModificado;
        
        public Form1()
        {
            InitializeComponent();
            archivoModificado = false;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";
            openFileDialog1.ShowDialog();
            ultimaRuta = openFileDialog1.FileName;
            if (ultimaRuta != null && ultimaRuta != "")
            {
                //Archivos txt
                if (openFileDialog1.FilterIndex == 1)
                {
                    IO.PuntoTxt auxTxt = new IO.PuntoTxt();

                    this.rtb1.Text = auxTxt.Leer(openFileDialog1.FileName);
                }
                //Archivos dat
                else
                {
                    IO.PuntoDat auxDat = new IO.PuntoDat();

                    this.rtb1.Text = (auxDat.Leer(openFileDialog1.FileName)).Contenido;
                    MessageBox.Show("Ruta: " + openFileDialog1.FileName + " Retorno: " + auxDat.Leer(openFileDialog1.FileName));
                }
                archivoModificado = false;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivoModificado && MessageBox.Show("¿Desea guardar las modificaciones realizadas al archivo antes de salir?", "Confirmar guardar cambios",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                guardarToolStripMenuItem_Click(sender, e);
            }
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultimaRuta != null && ultimaRuta != "")
            {
                //Archivos txt
                if (ultimaRuta.EndsWith(".txt"))
                {
                    IO.PuntoTxt auxTxt = new IO.PuntoTxt();
                    if (auxTxt.Guardar(saveFileDialog1.FileName, this.rtb1.Text))
                    {
                        archivoModificado = false;
                        MessageBox.Show("Archivo de texto guardado exitosamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al intentar guardar el archivo de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //Archivos dat
                else if(ultimaRuta.EndsWith(".dat"))
                {
                    IO.PuntoDat auxDat = new IO.PuntoDat();
                    auxDat.Contenido = this.rtb1.Text;
                    if (auxDat.Guardar(saveFileDialog1.FileName, auxDat))
                    {
                        archivoModificado = false;
                        MessageBox.Show("Archivo de datos guardado exitosamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al intentar guardar el archivo de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";
            saveFileDialog1.ShowDialog();
            ultimaRuta = saveFileDialog1.FileName;

            guardarToolStripMenuItem_Click(sender, e);
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            archivoModificado = true;
        }
    }
}
