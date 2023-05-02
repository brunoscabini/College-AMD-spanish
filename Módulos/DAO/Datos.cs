using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace DAO
{
    public class Datos
    {
        DataSet ds; string path; bool flag = false;
        public Datos ()
        {
            ds = new DataSet();
            path = "Persistencia.csv";
            if (!File.Exists(path)) Crear();
            Leer();
        }

        private void Crear()
        {
            DataTable Persona = new DataTable("Persona");
            Persona.Columns.Add(new DataColumn("Nombre", typeof(string)));
            Persona.Columns.Add(new DataColumn("Apellido", typeof(string)));
            Persona.Columns.Add(new DataColumn("Tipo_identificacion", typeof(string)));
            Persona.Columns.Add(new DataColumn("Numero_identificacion", typeof(int)));
            Persona.Columns.Add(new DataColumn("Pais_origen", typeof(string)));
            Persona.Columns.Add(new DataColumn("Genero", typeof(string)));
            Persona.Columns.Add(new DataColumn("Fecha_nacimiento", typeof(DateTime)));
            Persona.Columns.Add(new DataColumn("Tipo_usuario", typeof(string)));
            ds.Tables.Add(Persona);

            DataTable Materia = new DataTable("Materia");
            Materia.Columns.Add(new DataColumn("Numero_identificacion", typeof(int)));
            Materia.Columns.Add(new DataColumn("Nombre", typeof(string)));
            Materia.Columns.Add(new DataColumn("Año_revision", typeof(int)));
            Materia.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            ds.Tables.Add(Materia);

            DataTable Cursada = new DataTable("Cursada");
            Cursada.Columns.Add(new DataColumn("Numero_identificacion", typeof(int)));
            Cursada.Columns.Add(new DataColumn("Materia_numero_identificacion", typeof(int)));
            Cursada.Columns.Add(new DataColumn("Docente_numero_identificacion", typeof(int)));
            Cursada.Columns.Add(new DataColumn("Ciclo lectivo", typeof(int)));
            Cursada.Columns.Add(new DataColumn("Cuatrimestre", typeof(int)));
            ds.Tables.Add(Cursada);

            DataTable Alumno_cursada = new DataTable("Alumno_cursada");
            Alumno_cursada.Columns.Add(new DataColumn("Alumno_numero_identificacion", typeof(int)));
            Alumno_cursada.Columns.Add(new DataColumn("Cursada_numero_identificacion", typeof(int)));
            ds.Tables.Add(Alumno_cursada);

            File.Create(path).Dispose();
            ds.WriteXml(path, XmlWriteMode.WriteSchema);
        }

        private void Leer()
        {
            ds.ReadXml(path);
        }

        public void Persistir()
        {
            ds.WriteXml(path, XmlWriteMode.WriteSchema);
        }

        public DataSet Retorna_ds()
        {
            if(flag == false)
            {
                flag = true;
            }
            else
            {
                Leer();
            }
            return ds;
        }
    }
}
