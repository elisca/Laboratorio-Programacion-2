using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio_61
{
    class PersonaDAO
    {
        SqlConnection sqlConexion;
        SqlCommand sqlComando;
        SqlDataReader sqlLectorDatos;
        string bdConexion = @".\SQLExpress";
        string bdNombre = "Ejercicio_61";
        string bdTablaNombre = "dbo.Personas";
        bool bdSI = true;
        public PersonaDAO()
        {
            string strConexion = string.Format("Data source={0};Initial catalog={1};Integrated security={2};", this.bdConexion, this.bdNombre, this.bdSI.ToString());
            try
            {
                sqlConexion = new SqlConnection(strConexion);
                sqlComando = new SqlCommand();
                sqlComando.CommandType = System.Data.CommandType.Text;
                sqlComando.Connection = sqlConexion;
                sqlConexion.Open();
            }
            catch (Exception)
            {}
        }
        public bool Guardar(Persona p)
        {
            bool estado = false;
            if (p != null)
            {
                string comandoGuardar = string.Format("INSERT INTO {0} (Nombre,Apellido) VALUES('{1}','{2}')", this.bdTablaNombre, p.Nombre, p.Apellido);
                sqlComando.CommandText = comandoGuardar;
                sqlComando.ExecuteNonQuery();
                estado = true;
            }

            return estado;
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();
            int auxId;
            string auxNombre;
            string auxApellido;

            sqlComando.CommandText = string.Format("SELECT * FROM {0}", this.bdTablaNombre);
            sqlLectorDatos = sqlComando.ExecuteReader();

            while (sqlLectorDatos.Read())
            {
                auxId = (int)sqlLectorDatos[0];
                auxNombre = sqlLectorDatos[1].ToString();
                auxApellido = sqlLectorDatos[2].ToString();
                listaPersonas.Add(new Persona(auxId, auxNombre, auxApellido));
            }

            sqlLectorDatos.Close();

            return listaPersonas;
        }

        public Persona LeerPorID(int ID)
        {
            string comandoLeerID = string.Format("SELECT * FROM {0} WHERE ID={1}", this.bdTablaNombre, ID);
            Persona auxPersona = null;
            string auxNombre;
            string auxApellido;

            sqlComando.CommandText = comandoLeerID;
            sqlLectorDatos = sqlComando.ExecuteReader();

            while (sqlLectorDatos.Read())
            {
                auxNombre = sqlLectorDatos[1].ToString();
                auxApellido = sqlLectorDatos[2].ToString();
                auxPersona = new Persona(auxNombre, auxApellido);
            }

            return auxPersona;
        }

        public bool Modificar(int ID, string nombre, string apellido)
        {
            bool modificarOk = true;
            if (ID >= 0 && nombre != null && apellido != null)
            {
                string comandoModificar = string.Format("UPDATE {0} SET Nombre='{1}', Apellido='{2}' WHERE ID={3}", this.bdTablaNombre, nombre, apellido, ID);
                sqlComando.CommandText = comandoModificar;
                sqlComando.ExecuteNonQuery();
            }
            else
            {
                modificarOk = false;
            }

            return modificarOk;
        }

        public bool Borrar(int ID)
        {
            bool borrarOk = true;
            if (ID >= 0)
            {
                string comandoBorrar = string.Format("DELETE FROM {0} WHERE ID={1}", this.bdTablaNombre, ID);
                sqlComando.CommandText = comandoBorrar;
                sqlComando.ExecuteNonQuery();
            }
            else
            {
                borrarOk = false;
            }

            return borrarOk;
        }
    }
}
