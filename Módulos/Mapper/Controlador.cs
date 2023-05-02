using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAO;
using System.Security.Cryptography;

namespace Mapper
{
    public class Controlador
    {
        Datos datos; DataSet ds;
        public Controlador()
        {
            datos = new Datos();
            ds = datos.Retorna_ds();
        }

        public void Alta(BE_Persona pPersona)
        {
            DataRow dr = ds.Tables["Persona"].NewRow();
            dr.ItemArray = new object[] { pPersona.Nombre, pPersona.Apellido, pPersona.Tipo_identificacion,
                pPersona.Numero_identificacion, pPersona.Pais_origen, pPersona.Genero, pPersona.Obtener_fecha_nacimiento(),
             pPersona.Tipo_usuario };
            ds.Tables["Persona"].Rows.Add(dr);

            datos.Persistir();
        }

        public void Modificar(BE_Persona pPersona_original, BE_Persona pPersona_actualizacion)
        {
            DataRow dr_persona = ds.Tables["Persona"].Select($"Numero_identificacion = {pPersona_original.Numero_identificacion}")[0];
            dr_persona.SetField<string>(0, pPersona_actualizacion.Nombre);
            dr_persona.SetField<string>(1, pPersona_actualizacion.Apellido);
            dr_persona.SetField<string>(2, pPersona_actualizacion.Tipo_identificacion);
            dr_persona.SetField<int>(3, pPersona_actualizacion.Numero_identificacion);
            dr_persona.SetField<string>(4, pPersona_actualizacion.Pais_origen);
            dr_persona.SetField<string>(5, pPersona_actualizacion.Genero);
            dr_persona.SetField<DateTime>(6, pPersona_actualizacion.Obtener_fecha_nacimiento());
           
            datos.Persistir();
        }

        public void Baja(BE_Persona pPersona)
        {
            ds.Tables["Persona"].Select($"Numero_identificacion = {pPersona.Numero_identificacion}")[0].Delete();
            foreach(DataRow dr in ds.Tables["Alumno_cursada"].Select($"Alumno_numero_identificacion = {pPersona}"))
            {
                ds.Tables["Alumno_cursada"].Rows.Remove(dr);
            }
            datos.Persistir();
        }

        public List<BE_Persona> Obtener_lista_personas()
        {
            List<BE_Persona> aux = new List<BE_Persona>();
            foreach (DataRow dr in ds.Tables["Persona"].Rows)
            {
                if (dr.ItemArray[7].ToString() == "Alumno")
                {
                    aux.Add(new BE_Alumno(dr.ItemArray));
                }
                else if (dr.ItemArray[7].ToString() == "Docente")
                {
                    aux.Add(new BE_Docente(dr.ItemArray));
                }
            }
            return aux;
        }

        public List<BE_Cursada> Obtener_cursadas_asociadas(BE_Alumno pAlumno)
        {
            List<BE_Cursada> aux = new List<BE_Cursada>();
            foreach (DataRow numero_cursada in ds.Tables["Alumno_cursada"].
                    Select($"Alumno_numero_identificacion = {pAlumno.Numero_identificacion}"))
            {
                foreach (DataRow cursada in ds.Tables["Cursada"].
                    Select($"Numero_identificacion = {int.Parse(numero_cursada.ItemArray[1].ToString())}"))
                {
                    DataRow materia = ds.Tables["Materia"].Select($"Numero_identificacion = " +
                    $"{int.Parse(cursada.ItemArray[1].ToString())}")[0];
                    DataRow docente = ds.Tables["Persona"].Select($"Numero_identificacion = " +
                        $"{int.Parse(cursada.ItemArray[2].ToString())}")[0];
                    aux.Add(new BE_Cursada(new BE_Materia(materia.ItemArray), new BE_Docente(docente.ItemArray), cursada.ItemArray));
                }
            }
            return aux;
        }

        public void Alta(BE_Materia pMateria)
        {
            DataRow dr = ds.Tables["Materia"].NewRow();
            dr.ItemArray = new object[] { pMateria.Numero_identificacion, pMateria.Nombre,
                pMateria.Año_revision, pMateria.Descripcion };
            ds.Tables["Materia"].Rows.Add(dr);
            datos.Persistir();
        }

        public void Modificar(BE_Materia pMateria_original, BE_Materia pMateria_actualizacion)
        {
            DataRow dr = ds.Tables["Materia"].Select($"Numero_identificacion = {pMateria_original.Numero_identificacion}")[0];
            dr.SetField<string>(1, pMateria_actualizacion.Nombre);
            dr.SetField<int>(2, pMateria_actualizacion.Año_revision);
            dr.SetField<string>(3, pMateria_actualizacion.Descripcion);
            datos.Persistir();
        }

        public void Baja(BE_Materia pMateria)
        {
            ds.Tables["Materia"].Select($"Numero_identificacion = " +
                $"{int.Parse(pMateria.Numero_identificacion.ToString())}")[0].Delete();

            datos.Persistir();
        }

        public List<BE_Materia> Obtener_lista_materias()
        {
            List<BE_Materia> aux = new List<BE_Materia>();
            foreach (DataRow dr in ds.Tables["Materia"].Rows)
            {
                aux.Add(new BE_Materia(dr.ItemArray));
            }
            return aux;
        }

        public void Alta(BE_Cursada pCursada)
        {
            DataRow dr_cursada = ds.Tables["Cursada"].NewRow();
            dr_cursada.ItemArray = new object[] { pCursada.Numero_identificacion, pCursada.Obtener_materia().Numero_identificacion,
                pCursada.Obtener_docente().Numero_identificacion, pCursada.Ciclo_lectivo, pCursada.Cuatrimestre };
            ds.Tables["Cursada"].Rows.Add(dr_cursada);

            datos.Persistir();
        }

        public void Modificar(BE_Cursada pCursada_original, BE_Cursada pCursada_actualizacion)
        {
            DataRow dr_cursada = ds.Tables["Cursada"].Select($"Numero_identificacion = " +
                $"{pCursada_original.Numero_identificacion}")[0];
            dr_cursada.SetField<int>(1, pCursada_actualizacion.Obtener_materia().Numero_identificacion);
            dr_cursada.SetField<int>(2, pCursada_actualizacion.Obtener_docente().Numero_identificacion);
            dr_cursada.SetField<int>(3, pCursada_actualizacion.Ciclo_lectivo);
            dr_cursada.SetField<int>(4, pCursada_actualizacion.Cuatrimestre);

            datos.Persistir();
        }

        public void Baja(BE_Cursada pCursada)
        {
            ds.Tables["Cursada"].Select($"Numero_identificacion = {pCursada.Numero_identificacion}")[0].Delete();
            foreach (DataRow dr in ds.Tables["Alumno_cursada"].Select($"Cursada_numero_identificacion = " +
                $"{pCursada.Numero_identificacion}"))
            {
                ds.Tables["Alumno_cursada"].Rows.Remove(dr);
            }
            datos.Persistir();
        }

        public List<BE_Cursada> Obtener_lista_cursadas()
        {
            List<BE_Cursada> aux = new List<BE_Cursada>();
            foreach(DataRow cursada in ds.Tables["Cursada"].Rows)
            {
                DataRow materia = ds.Tables["Materia"].Select($"Numero_identificacion = " +
                    $"{int.Parse(cursada.ItemArray[1].ToString())}")[0];
                DataRow docente = ds.Tables["Persona"].Select($"Numero_identificacion = " +
                    $"{int.Parse(cursada.ItemArray[2].ToString())}")[0];
                aux.Add(new BE_Cursada(new BE_Materia(materia.ItemArray), new BE_Docente(docente.ItemArray), cursada.ItemArray));
            }
            return aux;
        }

        public List<BE_Alumno> Obtener_alumnos_asociados(BE_Cursada pCursada)
        {
            List<BE_Alumno> aux = new List<BE_Alumno>();
            foreach (DataRow numero_alumno in ds.Tables["Alumno_cursada"].
                Select($"Cursada_numero_identificacion = {pCursada.Numero_identificacion}"))
            {
                foreach (DataRow alumno in ds.Tables["Persona"].Select($"Numero_identificacion = " +
                    $"{int.Parse(numero_alumno.ItemArray[0].ToString())}"))
                {
                    aux.Add(new BE_Alumno(alumno.ItemArray));
                }
            }
            return aux;
        }

        public void Asignar(BE_Alumno pAlumno, BE_Cursada pCursada)
        {
            DataRow dr = ds.Tables["Alumno_cursada"].NewRow();
            dr.ItemArray = new object[] { pAlumno.Numero_identificacion, pCursada.Numero_identificacion };
            ds.Tables["Alumno_cursada"].Rows.Add(dr);
            datos.Persistir();
        }

        public void Derogar(BE_Alumno pAlumno, BE_Cursada pCursada)
        {
            ds.Tables["Alumno_cursada"].Select($"Alumno_numero_identificacion = {pAlumno.Numero_identificacion}")[0].Delete();
            datos.Persistir();
        }
    }
}
