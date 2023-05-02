using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using BLL;
using BE;
using Verificaciones;
using System.Text.RegularExpressions;

namespace Práctica_previa_al_final
{
    public partial class Interfaz : Form
    {
        BLL_Cursada cursada; BLL_Materia materia; BLL_Persona persona; 
        Verificacion_persona verificacion_persona; Verificacion_materia verificacion_materia; Verificacion_cursada verificacion_cursada;
        string busqueda_previa = "";

        public Interfaz()
        {
            InitializeComponent();
            cursada = new BLL_Cursada();
            materia = new BLL_Materia();
            persona = new BLL_Persona();
            verificacion_persona = new Verificacion_persona();
            verificacion_materia = new Verificacion_materia();
            verificacion_cursada = new Verificacion_cursada();
            Iniciar_grillas();
            foreach(DataGridView dgv in this.Controls.OfType<DataGridView>())
            {
                Configurar_grillas(dgv);
            }
        }

        private void Iniciar_grillas()
        {
            Cargar_grilla(dGV_Personas, persona.Obtener_lista_personas());
            Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                        where seleccionado is BE_Alumno
                                        select seleccionado).ToList());
            Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                         where seleccionado is BE_Docente
                                         select seleccionado).ToList());
            Cargar_grilla(dGV_Materias, materia.Obtener_lista());
            Cargar_grilla(dGV_Cursadas, cursada.Obtener_lista());
        }

        private void Configurar_grillas(DataGridView dGV)
        {
            dGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV.MultiSelect = false;
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Cargar_grilla(DataGridView dGV, object obj)
        {
            dGV.DataSource = null;
            dGV.DataSource = obj;
        }

        private void btn_Alta_persona_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo_user = "";
                Regex formato_fecha = new Regex("^(0[1-9]|[1-9]|1[012])/([1-9]|[012][0-9]|3[01])/(19[5-9][0-9]|20[01][0-9])$");
                if (rB_Alumno.Checked) tipo_user = "alumno";
                else if (rB_Docente.Checked) tipo_user = "docente";
                if (rB_Alumno.Checked == false && rB_Docente.Checked == false) 
                {
                    throw new Exception("No se seleccionó si la alta es de un alumno o un docente.");
                }
                string nombre = Interaction.InputBox($"Ingrese el nombre del {tipo_user}.", $"Alta de {tipo_user}");
                if (nombre != "")
                {
                    string apellido = Interaction.InputBox($"Ingrese el apellido del {tipo_user}.", $"Alta de {tipo_user}");
                    if (apellido != "")
                    {

                        string origen = "";
                        string tipo_identificacion = "";
                        DialogResult result = MessageBox.Show($"¿Es extranjero el {tipo_user} a dar de alta?",
                            $"Alta de {tipo_user}", MessageBoxButtons.YesNo);
                        if (result is DialogResult.Yes)
                        {
                            tipo_identificacion = "Pasaporte"; 
                            origen = Interaction.InputBox($"Ingrese el país de origen del {tipo_user}.", $"Alta de {tipo_user}");
                        }
                        else if (result is DialogResult.No)
                        {
                            tipo_identificacion = "DNI";
                            origen = "Argentina";
                        }
                        int numero_identificacion = int.Parse(Interaction.InputBox("Ingrese el número de identificación del alumno.",
                            $"Alta de {tipo_user}"));
                        if (verificacion_persona.Verificar(numero_identificacion) == true) throw new Exception("El numero" +
                            "de identifición ya existe dentro del sistema.");
                        string genero = Interaction.InputBox("Ingrese el género del alumno.", $"Alta de {tipo_user}");
                        if (genero != "")
                        {
                            string fecha_ingresada = Interaction.InputBox($"Ingrese la fecha de nacimiento del {tipo_user}.",
                            $"Alta de {tipo_user}");
                            DateTime fecha_nacimiento = DateTime.Now;
                            if (formato_fecha.IsMatch(fecha_ingresada))
                            {
                                fecha_nacimiento = DateTime.Parse(fecha_ingresada);
                            }
                            else
                            {
                                throw new Exception($"La fecha ingresada del {tipo_user} que se quiere cargar " +
                                    $"tiene un formato incorrecto.");
                            }
                            if(rB_Alumno.Checked) persona.Alta(new BE_Alumno(new object[] { nombre, apellido, tipo_identificacion, numero_identificacion,
                                origen, genero, fecha_nacimiento }));
                            else if (rB_Docente.Checked) persona.Alta(new BE_Docente(new object[] { nombre, apellido, tipo_identificacion, numero_identificacion,
                                origen, genero, fecha_nacimiento }));
                            
                        }
                    }
                }
                Cargar_grilla(dGV_Personas, persona.Obtener_lista_personas());
                Cargar_grilla(dGV_Alumnos, from BE_Persona persona in persona.Obtener_lista_personas() where persona is BE_Alumno select persona);
                Cargar_grilla(dGV_Docentes, from BE_Persona persona in persona.Obtener_lista_personas() where persona is BE_Docente select persona);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Modificar_persona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Personas.Rows.Count == 0) throw new Exception("No hay personas para modificar.");
                BE_Persona seleccionado = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Persona;
                string tipo_user = "";
                if (seleccionado is BE_Alumno) tipo_user = seleccionado.Tipo_usuario.ToLower();
                if (seleccionado is BE_Docente) tipo_user = seleccionado.Tipo_usuario.ToLower();
                string nombre = Interaction.InputBox($"Ingrese el nuevo nombre del {tipo_user}.", $"Modificar {tipo_user}",
                        seleccionado.Nombre);
                string apellido = Interaction.InputBox($"Ingrese el nuevo apellido del {tipo_user}.", $"Modificar {tipo_user}",
                    seleccionado.Apellido);
                bool extranjero = bool.Parse(MessageBox.Show($"¿Es extranjero el {tipo_user} a modificar?",
                     $"Modificar {tipo_user}", MessageBoxButtons.YesNo).ToString());
                string origen = "";
                string tipo_identificacion = "";
                if (extranjero == true)
                {
                    tipo_identificacion = "Pasaporte";
                    origen = Interaction.InputBox($"Ingrese el nuevo país de origen del {tipo_user}.", $"Modificar {tipo_user}");
                }
                else
                {
                    tipo_identificacion = "DNI";
                    origen = "Argentina";
                }
                int numero_identificacion = int.Parse(Interaction.InputBox($"Ingrese el nuevo número de identificación del {tipo_user}.",
                    $"Modificar {tipo_user}", seleccionado.Numero_identificacion.ToString()));
                if (verificacion_persona.Verificar(numero_identificacion) == true &&
                    verificacion_persona.Verificar(seleccionado.Numero_identificacion) == false)
                {
                    throw new Exception($"El numero de identificación del {tipo_user} a cargar ya existe dentro del sistema.");
                }
                string genero = Interaction.InputBox($"Ingrese el nuevo género del {tipo_user}.", $"Modificar {tipo_user}",
                    seleccionado.Genero);
                DateTime fecha_nacimiento = DateTime.Parse(Interaction.InputBox($"Ingrese la nueva fecha de nacimiento del {tipo_user}.",
                    $"Modificar {tipo_user}", seleccionado.Obtener_fecha_nacimiento().Date.ToString()));
                if(seleccionado is BE_Alumno) persona.Modificar(seleccionado, new BE_Alumno(new object[] { nombre, apellido, tipo_identificacion,
                        numero_identificacion, origen, genero, fecha_nacimiento }));
                else if(seleccionado is BE_Docente) persona.Modificar(seleccionado, new BE_Docente(new object[] { nombre, apellido, tipo_identificacion,
                        numero_identificacion, origen, genero, fecha_nacimiento }));
                Cargar_grilla(dGV_Personas, persona.Obtener_lista_personas());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Baja_persona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Personas.Rows.Count == 0) throw new Exception("No hay personas para eliminar.");
                BE_Persona seleccionado = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Persona;
                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar al usuario " +
                    $"de nombre {seleccionado.Nombre} {seleccionado.Apellido} e identificación de origen {seleccionado.Tipo_identificacion} " +
                    $"con número {seleccionado.Numero_identificacion}", $"Baja de {seleccionado.Tipo_identificacion}?", MessageBoxButtons.YesNo);
                if (result is DialogResult.Yes)
                {
                    persona.Baja(dGV_Personas.SelectedRows[0].DataBoundItem as BE_Persona);
                    Cargar_grilla(dGV_Personas, persona.Obtener_lista_personas());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Persona_asignar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dGV_Alumnos.Rows.Count > 0 && dGV_Cursadas.Rows.Count > 0)
                {
                    BE_Alumno alumno = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Alumno;
                    BE_Cursada cursada = dGV_Cursadas.SelectedRows[0].DataBoundItem as BE_Cursada;
                    if (MessageBox.Show($"¿Desea asociar al alumno {alumno.Nombre} {alumno.Apellido} a la cursada de la materia {cursada.Obtener_materia().Nombre} " +
                        $"con el profesor {cursada.Obtener_docente().Nombre} {cursada.Obtener_docente().Apellido}?", "Asignar alumno a una cursada", MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        persona.Asignar(alumno, cursada);
                    }
                }
                else
                {
                    throw new Exception("No hay suficientes alumnos y/o cursadas para poder hacer esta operación.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Persona_derogar_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Alumno alumno = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Alumno;
                BE_Cursada cursada = dGV_Cursadas.SelectedRows[0].DataBoundItem as BE_Cursada;
                if (MessageBox.Show($"¿Desea derogar al alumno {alumno.Nombre} {alumno.Apellido} de la cursada de la materia {cursada.Obtener_materia().Nombre}" +
                    $"con el profesor {cursada.Obtener_docente().Nombre} {cursada.Obtener_docente().Apellido}?", "Derogar alumno de una cursada", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    persona.Derogar(alumno, cursada);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Alta_materia_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Ingrese el nombre de la materia.", "Alta de materia");
                int numero_identificacion = 0;
                do
                {
                    Random random = new Random();
                    numero_identificacion = random.Next(1, 2000);
                } while (verificacion_materia.Verificar(numero_identificacion) == true);
                int Año_revision = int.Parse(Interaction.InputBox("Ingrese el año de revisión de la materia.", "Alta de materia"));
                string descripcion = Interaction.InputBox("Ingrese una descripción para la materia.", "Alta de materia");
                materia.Alta(new BE_Materia(new object[] { numero_identificacion, nombre, Año_revision, descripcion }));
                Cargar_grilla(dGV_Materias, materia.Obtener_lista());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Modificar_materia_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Materia seleccionado = dGV_Materias.SelectedRows[0].DataBoundItem as BE_Materia;
                if (dGV_Materias.Rows.Count == 0) throw new Exception("No hay materias para modificar.");
                if (seleccionado != null)
                {
                    string nombre = Interaction.InputBox("Ingrese un nuevo nombre para la materia.", "Modificar materia",
                    seleccionado.Nombre);
                    int Año_revision = int.Parse(Interaction.InputBox("Ingrese un nuevo año de revisión para la materia.", 
                        "Modificar materia", seleccionado.Año_revision.ToString()));
                    string descripcion = Interaction.InputBox("Ingrese una nueva descripción para la materia.", "Modificar materia",
                        seleccionado.Descripcion);
                    materia.Modificar(seleccionado, new BE_Materia(new object[] {
                    seleccionado.Numero_identificacion, nombre, Año_revision, descripcion }));
                    Cargar_grilla(dGV_Materias, materia.Obtener_lista());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Baja_materia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Materias.Rows.Count == 0) throw new Exception("No hay materias para eliminar.");
                materia.Baja(dGV_Materias.SelectedRows[0].DataBoundItem as BE_Materia);
                Cargar_grilla(dGV_Materias, materia.Obtener_lista());
            }
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Alta_cursada_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Materia materia_seleccionada = dGV_Materias.SelectedRows[0].DataBoundItem as BE_Materia;
                BE_Docente docente_seleccionado = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Docente;
                if (docente_seleccionado != null && materia_seleccionada != null)
                {
                    int ciclo_lectivo = int.Parse(Interaction.InputBox("Ingrese el ciclo lectivo de la cursada.",
                        "Alta de cursada"));
                    int cuatrimestre = int.Parse(Interaction.InputBox("Ingrese el cuatrimestre de la cursada.",
                        "Alta de cursada"));
                    int numero_identificacion = 0;
                    do
                    {
                        Random random = new Random();
                        numero_identificacion = random.Next(0, 2000);
                    } while (verificacion_cursada.Verificar(numero_identificacion));
                    cursada.Alta(new BE_Cursada(materia_seleccionada, docente_seleccionado, new object[] { numero_identificacion,
                        ciclo_lectivo, cuatrimestre,}));
                    Cargar_grilla(dGV_Cursadas, cursada.Obtener_lista());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Modificar_cursada_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Cursadas.Rows.Count == 0) throw new Exception("No hay cursadas para modificar.");
                BE_Cursada cursada_seleccionada = dGV_Cursadas.SelectedRows[0].DataBoundItem as BE_Cursada;
                BE_Materia materia_seleccionada = dGV_Materias.SelectedRows[0].DataBoundItem as BE_Materia;
                BE_Docente docente_seleccionado = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Docente;
                if (docente_seleccionado != null && materia_seleccionada != null)
                {
                    int ciclo_lectivo = int.Parse(Interaction.InputBox("Ingrese el nuevo ciclo lectivo de la cursada.",
                        "Modificar cursada", cursada_seleccionada.Ciclo_lectivo.ToString()));
                    int cuatrimestre = int.Parse(Interaction.InputBox("Ingrese el nuevo cuatrimestre de la cursada.",
                        "Modificar cursada", cursada_seleccionada.Cuatrimestre.ToString()));
                    cursada.Alta(new BE_Cursada(materia_seleccionada, docente_seleccionado, new object[] { 
                        cursada_seleccionada.Numero_identificacion, ciclo_lectivo, cuatrimestre,}));
                    Cargar_grilla(dGV_Cursadas, cursada.Obtener_lista());
                }
            }
            catch (Exception) { }
        }

        private void btn_Baja_cursada_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Cursadas.Rows.Count == 0) throw new Exception("No hay cursadas para eliminar.");
                cursada.Baja(dGV_Cursadas.SelectedRows[0].DataBoundItem as BE_Cursada);
                Cargar_grilla(dGV_Cursadas, cursada.Obtener_lista());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Barra_busqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (busqueda_previa != "")
                {
                    Barra_busqueda.Text = busqueda_previa;
                }
                else
                {
                    Barra_busqueda.Text = "";
                }
                Barra_busqueda.ForeColor = Color.Black;
            }
            catch (Exception) { }
        }

        private void Barra_busqueda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Barra_busqueda.Text != "")
                {
                    busqueda_previa = Barra_busqueda.Text;
                }
                Barra_busqueda.Text = "Buscar elemento en grillas";
                Barra_busqueda.ForeColor = Color.Gray;
            }
            catch (Exception) { }
        }

        private void dGV_Cursadas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BE_Cursada seleccionado = dGV_Cursadas.SelectedRows[0].DataBoundItem as BE_Cursada;
                if (seleccionado != null)
                {
                    lbl_Cursada_alumnos.Text = $"Grilla de alumnos pertenecientes a la cursada de la materia: {seleccionado.Materia}";
                    Cargar_grilla(dGV_Cursada_alumnos, cursada.Obtener_alumnos_asociados(seleccionado));
                }
            }
            catch (Exception) { }
        }

        private void dGV_Personas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BE_Alumno seleccionado = dGV_Personas.SelectedRows[0].DataBoundItem as BE_Alumno;
                if (seleccionado != null)
                {
                    lbl_Alumno_cursadas.Text = $"Grilla de cursadas asociadas al alumno: {seleccionado.Nombre} {seleccionado.Apellido}";
                    Cargar_grilla(dGV_Alumno_cursadas, persona.Obtener_cursadas_asociadas(seleccionado));
                }
            }
            catch (Exception) { }
        }

        private void Barra_busqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex($"^{Barra_busqueda.Text}", RegexOptions.IgnoreCase);
                if (Barra_busqueda.Text != "Buscar elemento en grillas" && Barra_busqueda.Text != "")
                {
                    Cargar_grilla(dGV_Personas, persona.Obtener_lista_personas().FindAll(x => regex.IsMatch(x.Nombre) ||
                        regex.IsMatch(x.Apellido) || regex.IsMatch(x.Numero_identificacion.ToString())));
                    Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                where seleccionado is BE_Alumno && regex.IsMatch(seleccionado.Nombre)
                                                || seleccionado is BE_Alumno && regex.IsMatch(seleccionado.Apellido)
                                                || seleccionado is BE_Alumno && regex.IsMatch(seleccionado.Numero_identificacion.ToString())
                                                select seleccionado).ToList());
                    Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                 where seleccionado is BE_Docente && regex.IsMatch(seleccionado.Nombre)
                                                 || seleccionado is BE_Docente && regex.IsMatch(seleccionado.Apellido)
                                                 || seleccionado is BE_Docente &&
                                                 regex.IsMatch(seleccionado.Numero_identificacion.ToString())
                                                 select seleccionado).ToList());
                    Cargar_grilla(dGV_Materias, materia.Obtener_lista().
                        FindAll(x => regex.IsMatch(x.Nombre) || regex.IsMatch(x.Numero_identificacion.ToString())));
                    Cargar_grilla(dGV_Cursadas, cursada.Obtener_lista().
                        FindAll(x => regex.IsMatch(x.Nombre_docente) || regex.IsMatch(x.Apellido_docente)
                        || regex.IsMatch(x.Numero_identificacion.ToString())));
                }
                else
                {
                    Iniciar_grillas();
                }
            }
            catch (Exception) { }
        }

        private void reestablecerGrillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciar_grillas();
        }

        private void dGV_Cursadas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(dGV_Cursadas.Rows.Count == 0)
            {
                dGV_Cursada_alumnos.DataSource = null;
                lbl_Cursada_alumnos.Text = "Grilla de alumnos pertenecientes a la cursada de la materia:";
            }
        }

        private void porNombreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Personas.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar personas por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Personas, (from seleccionado in persona.Obtener_lista_personas()
                                                     orderby seleccionado.Nombre ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar personas por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Personas, (from seleccionado in persona.Obtener_lista_personas()
                                                     orderby seleccionado.Nombre descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porApellidoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Personas.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar personas por apellido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Personas, (from seleccionado in persona.Obtener_lista_personas()
                                                     orderby seleccionado.Apellido ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar personas por apellido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Personas, (from seleccionado in persona.Obtener_lista_personas()
                                                     orderby seleccionado.Apellido descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porEdadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Personas.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar personas por edad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Personas, (from seleccionado in persona.Obtener_lista_personas()
                                                     orderby seleccionado.Edad ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar personas por edad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Personas, (from seleccionado in persona.Obtener_lista_personas()
                                                     orderby seleccionado.Edad descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ascendenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Materias.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar materias por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Materias, (from seleccionado in materia.Obtener_lista()
                                                     orderby seleccionado.Nombre ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar materias por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Materias, (from seleccionado in materia.Obtener_lista()
                                                     orderby seleccionado.Nombre descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception) { }
        }

        private void descendenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Materias.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar materias por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Materias, (from seleccionado in materia.Obtener_lista()
                                                     orderby seleccionado.Nombre ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar materias por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Materias, (from seleccionado in materia.Obtener_lista()
                                                     orderby seleccionado.Nombre descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception) { }
        }

        private void porNombreToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Cursadas.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar cursadas por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Cursadas, (from seleccionado in cursada.Obtener_lista()
                                                     orderby seleccionado.Materia ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar cursadas por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Cursadas, (from seleccionado in cursada.Obtener_lista()
                                                     orderby seleccionado.Materia descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception) { }
        }

        private void porCicloLectivoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Cursadas.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar cursadas por ciclo lectivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Cursadas, (from seleccionado in cursada.Obtener_lista()
                                                     orderby seleccionado.Ciclo_lectivo ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar cursadas por ciclo lectivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Cursadas, (from seleccionado in cursada.Obtener_lista()
                                                     orderby seleccionado.Ciclo_lectivo descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception) { }
        }

        private void porCantidadDeAlumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Cursadas.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar cursadas por cantidad de alumnos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Cursadas, (from seleccionado in cursada.Obtener_lista()
                                                     orderby cursada.Obtener_alumnos_asociados(seleccionado).Count ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar cursadas por cantidad de alumnos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Cursadas, (from seleccionado in cursada.Obtener_lista()
                                                     orderby cursada.Obtener_alumnos_asociados(seleccionado).Count descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception) { }
        }

        private void porNombreToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Docentes.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar docentes por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                     where seleccionado is BE_Docente
                                                     orderby seleccionado.Nombre ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar docentes por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                     where seleccionado is BE_Docente
                                                     orderby seleccionado.Nombre descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porApellidoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Docentes.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar docentes por apellido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                     where seleccionado is BE_Docente
                                                     orderby seleccionado.Apellido ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar docentes por apellido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                     where seleccionado is BE_Docente
                                                     orderby seleccionado.Apellido descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porEdadToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Docentes.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar docentes por edad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                     where seleccionado is BE_Docente
                                                     orderby seleccionado.Edad ascending
                                                     select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar docentes por edad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Docentes, (from seleccionado in persona.Obtener_lista_personas()
                                                     where seleccionado is BE_Docente
                                                     orderby seleccionado.Edad descending
                                                     select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porNombreToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Alumnos.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar alumnos por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                    where seleccionado is BE_Alumno
                                                    orderby seleccionado.Nombre ascending
                                                    select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar alumnos por nombre", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                    where seleccionado is BE_Alumno
                                                    orderby seleccionado.Nombre descending
                                                    select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porApellidoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Alumnos.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar alumnos por apellido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                    where seleccionado is BE_Alumno
                                                    orderby seleccionado.Apellido ascending
                                                    select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar alumnos por apellido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                    where seleccionado is BE_Alumno
                                                    orderby seleccionado.Apellido descending
                                                    select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void porEdadToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Alumnos.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ordenar de forma ascendente?",
                        "Ordenar alumnos por edad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                    where seleccionado is BE_Alumno
                                                    orderby seleccionado.Edad ascending
                                                    select seleccionado).ToList());
                    }
                    else if (MessageBox.Show("¿Desea ordenar de forma descendente?",
                        "Ordenar alumno spor  edad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cargar_grilla(dGV_Alumnos, (from seleccionado in persona.Obtener_lista_personas()
                                                    where seleccionado is BE_Alumno
                                                    orderby seleccionado.Edad descending
                                                    select seleccionado).ToList());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
