using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_61
{
    public partial class Form1 : Form
    {
        PersonaDAO personaDAO;
        List<Persona> listaPersonas;
        public Form1()
        {
            InitializeComponent();
            personaDAO = new PersonaDAO();
            listaPersonas = new List<Persona>();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.listaPersonas = personaDAO.Leer();

            this.lstPersonas.Items.Clear();
            foreach (Persona auxPersona in this.listaPersonas)
            {
                this.lstPersonas.Items.Add(string.Format("{0} {1}", auxPersona.Nombre, auxPersona.Apellido));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona auxPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
            this.personaDAO.Guardar(auxPersona);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            personaDAO.Modificar(int.Parse(txtID.Text), txtNombre.Text, txtApellido.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            personaDAO.Borrar(int.Parse(txtID.Text));
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] datosPersona = lstPersonas.SelectedItem.ToString().Split(' ');

            txtNombre.Text = datosPersona[0];
            txtApellido.Text = datosPersona[1];
        }
    }
}
