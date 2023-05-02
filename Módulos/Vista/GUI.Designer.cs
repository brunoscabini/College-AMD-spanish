namespace Práctica_previa_al_final
{
    partial class Interfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV_Personas = new System.Windows.Forms.DataGridView();
            this.dGV_Alumnos = new System.Windows.Forms.DataGridView();
            this.dGV_Cursadas = new System.Windows.Forms.DataGridView();
            this.dGV_Docentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Cursada_alumnos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dGV_Cursada_alumnos = new System.Windows.Forms.DataGridView();
            this.dGV_Materias = new System.Windows.Forms.DataGridView();
            this.btn_Alta_persona = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_Docente = new System.Windows.Forms.RadioButton();
            this.rB_Alumno = new System.Windows.Forms.RadioButton();
            this.btn_Baja_persona = new System.Windows.Forms.Button();
            this.btn_Modificar_persona = new System.Windows.Forms.Button();
            this.btn_Persona_desasignar = new System.Windows.Forms.Button();
            this.btn_Persona_asignar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Baja_materia = new System.Windows.Forms.Button();
            this.btn_Modificar_materia = new System.Windows.Forms.Button();
            this.btn_Alta_materia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Baja_cursada = new System.Windows.Forms.Button();
            this.btn_Modificar_cursada = new System.Windows.Forms.Button();
            this.btn_Alta_cursada = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Barra_busqueda = new System.Windows.Forms.ToolStripTextBox();
            this.reestablecerGrillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grillaDePersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porCicloLectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCantidadDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porEdadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.porEdadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_Alumno_cursadas = new System.Windows.Forms.Label();
            this.dGV_Alumno_cursadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Personas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Cursadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Docentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Cursada_alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Materias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumno_cursadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Personas
            // 
            this.dGV_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Personas.Location = new System.Drawing.Point(110, 54);
            this.dGV_Personas.Name = "dGV_Personas";
            this.dGV_Personas.Size = new System.Drawing.Size(449, 150);
            this.dGV_Personas.TabIndex = 0;
            this.dGV_Personas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Personas_RowEnter);
            // 
            // dGV_Alumnos
            // 
            this.dGV_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alumnos.Location = new System.Drawing.Point(110, 392);
            this.dGV_Alumnos.Name = "dGV_Alumnos";
            this.dGV_Alumnos.Size = new System.Drawing.Size(247, 150);
            this.dGV_Alumnos.TabIndex = 1;
            // 
            // dGV_Cursadas
            // 
            this.dGV_Cursadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Cursadas.Location = new System.Drawing.Point(110, 223);
            this.dGV_Cursadas.Name = "dGV_Cursadas";
            this.dGV_Cursadas.Size = new System.Drawing.Size(449, 150);
            this.dGV_Cursadas.TabIndex = 3;
            this.dGV_Cursadas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Cursadas_RowEnter);
            this.dGV_Cursadas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGV_Cursadas_RowsRemoved);
            // 
            // dGV_Docentes
            // 
            this.dGV_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Docentes.Location = new System.Drawing.Point(363, 392);
            this.dGV_Docentes.Name = "dGV_Docentes";
            this.dGV_Docentes.Size = new System.Drawing.Size(247, 150);
            this.dGV_Docentes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grilla de personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grilla de alumnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grilla de docentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grilla de cursadas";
            // 
            // lbl_Cursada_alumnos
            // 
            this.lbl_Cursada_alumnos.AutoSize = true;
            this.lbl_Cursada_alumnos.Location = new System.Drawing.Point(561, 207);
            this.lbl_Cursada_alumnos.Name = "lbl_Cursada_alumnos";
            this.lbl_Cursada_alumnos.Size = new System.Drawing.Size(287, 13);
            this.lbl_Cursada_alumnos.TabIndex = 11;
            this.lbl_Cursada_alumnos.Text = "Grilla de alumnos pertenecientes a la cursada de la materia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grilla de materias";
            // 
            // dGV_Cursada_alumnos
            // 
            this.dGV_Cursada_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Cursada_alumnos.Location = new System.Drawing.Point(565, 223);
            this.dGV_Cursada_alumnos.Name = "dGV_Cursada_alumnos";
            this.dGV_Cursada_alumnos.Size = new System.Drawing.Size(421, 150);
            this.dGV_Cursada_alumnos.TabIndex = 9;
            // 
            // dGV_Materias
            // 
            this.dGV_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Materias.Location = new System.Drawing.Point(565, 54);
            this.dGV_Materias.Name = "dGV_Materias";
            this.dGV_Materias.Size = new System.Drawing.Size(421, 150);
            this.dGV_Materias.TabIndex = 8;
            // 
            // btn_Alta_persona
            // 
            this.btn_Alta_persona.Location = new System.Drawing.Point(6, 19);
            this.btn_Alta_persona.Name = "btn_Alta_persona";
            this.btn_Alta_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta_persona.TabIndex = 13;
            this.btn_Alta_persona.Text = "Alta";
            this.btn_Alta_persona.UseVisualStyleBackColor = true;
            this.btn_Alta_persona.Click += new System.EventHandler(this.btn_Alta_persona_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_Docente);
            this.groupBox1.Controls.Add(this.rB_Alumno);
            this.groupBox1.Controls.Add(this.btn_Baja_persona);
            this.groupBox1.Controls.Add(this.btn_Modificar_persona);
            this.groupBox1.Controls.Add(this.btn_Alta_persona);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 152);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona";
            // 
            // rB_Docente
            // 
            this.rB_Docente.AutoSize = true;
            this.rB_Docente.Location = new System.Drawing.Point(6, 129);
            this.rB_Docente.Name = "rB_Docente";
            this.rB_Docente.Size = new System.Drawing.Size(66, 17);
            this.rB_Docente.TabIndex = 17;
            this.rB_Docente.TabStop = true;
            this.rB_Docente.Text = "Docente";
            this.rB_Docente.UseVisualStyleBackColor = true;
            // 
            // rB_Alumno
            // 
            this.rB_Alumno.AutoSize = true;
            this.rB_Alumno.Checked = true;
            this.rB_Alumno.Location = new System.Drawing.Point(6, 106);
            this.rB_Alumno.Name = "rB_Alumno";
            this.rB_Alumno.Size = new System.Drawing.Size(60, 17);
            this.rB_Alumno.TabIndex = 16;
            this.rB_Alumno.TabStop = true;
            this.rB_Alumno.Text = "Alumno";
            this.rB_Alumno.UseVisualStyleBackColor = true;
            // 
            // btn_Baja_persona
            // 
            this.btn_Baja_persona.Location = new System.Drawing.Point(6, 77);
            this.btn_Baja_persona.Name = "btn_Baja_persona";
            this.btn_Baja_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja_persona.TabIndex = 15;
            this.btn_Baja_persona.Text = "Baja";
            this.btn_Baja_persona.UseVisualStyleBackColor = true;
            this.btn_Baja_persona.Click += new System.EventHandler(this.btn_Baja_persona_Click);
            // 
            // btn_Modificar_persona
            // 
            this.btn_Modificar_persona.Location = new System.Drawing.Point(6, 48);
            this.btn_Modificar_persona.Name = "btn_Modificar_persona";
            this.btn_Modificar_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar_persona.TabIndex = 14;
            this.btn_Modificar_persona.Text = "Modificar";
            this.btn_Modificar_persona.UseVisualStyleBackColor = true;
            this.btn_Modificar_persona.Click += new System.EventHandler(this.btn_Modificar_persona_Click);
            // 
            // btn_Persona_desasignar
            // 
            this.btn_Persona_desasignar.Location = new System.Drawing.Point(6, 48);
            this.btn_Persona_desasignar.Name = "btn_Persona_desasignar";
            this.btn_Persona_desasignar.Size = new System.Drawing.Size(75, 23);
            this.btn_Persona_desasignar.TabIndex = 19;
            this.btn_Persona_desasignar.Text = "Derogar";
            this.btn_Persona_desasignar.UseVisualStyleBackColor = true;
            this.btn_Persona_desasignar.Click += new System.EventHandler(this.btn_Persona_derogar_Click);
            // 
            // btn_Persona_asignar
            // 
            this.btn_Persona_asignar.Location = new System.Drawing.Point(6, 19);
            this.btn_Persona_asignar.Name = "btn_Persona_asignar";
            this.btn_Persona_asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_Persona_asignar.TabIndex = 18;
            this.btn_Persona_asignar.Text = "Asignar";
            this.btn_Persona_asignar.UseVisualStyleBackColor = true;
            this.btn_Persona_asignar.Click += new System.EventHandler(this.btn_Persona_asignar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Baja_materia);
            this.groupBox2.Controls.Add(this.btn_Modificar_materia);
            this.groupBox2.Controls.Add(this.btn_Alta_materia);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 109);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materia";
            // 
            // btn_Baja_materia
            // 
            this.btn_Baja_materia.Location = new System.Drawing.Point(6, 77);
            this.btn_Baja_materia.Name = "btn_Baja_materia";
            this.btn_Baja_materia.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja_materia.TabIndex = 15;
            this.btn_Baja_materia.Text = "Baja";
            this.btn_Baja_materia.UseVisualStyleBackColor = true;
            this.btn_Baja_materia.Click += new System.EventHandler(this.btn_Baja_materia_Click);
            // 
            // btn_Modificar_materia
            // 
            this.btn_Modificar_materia.Location = new System.Drawing.Point(6, 48);
            this.btn_Modificar_materia.Name = "btn_Modificar_materia";
            this.btn_Modificar_materia.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar_materia.TabIndex = 14;
            this.btn_Modificar_materia.Text = "Modificar";
            this.btn_Modificar_materia.UseVisualStyleBackColor = true;
            this.btn_Modificar_materia.Click += new System.EventHandler(this.btn_Modificar_materia_Click);
            // 
            // btn_Alta_materia
            // 
            this.btn_Alta_materia.Location = new System.Drawing.Point(6, 19);
            this.btn_Alta_materia.Name = "btn_Alta_materia";
            this.btn_Alta_materia.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta_materia.TabIndex = 13;
            this.btn_Alta_materia.Text = "Alta";
            this.btn_Alta_materia.UseVisualStyleBackColor = true;
            this.btn_Alta_materia.Click += new System.EventHandler(this.btn_Alta_materia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Baja_cursada);
            this.groupBox3.Controls.Add(this.btn_Modificar_cursada);
            this.groupBox3.Controls.Add(this.btn_Alta_cursada);
            this.groupBox3.Location = new System.Drawing.Point(12, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(92, 109);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursada";
            // 
            // btn_Baja_cursada
            // 
            this.btn_Baja_cursada.Location = new System.Drawing.Point(6, 77);
            this.btn_Baja_cursada.Name = "btn_Baja_cursada";
            this.btn_Baja_cursada.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja_cursada.TabIndex = 15;
            this.btn_Baja_cursada.Text = "Baja";
            this.btn_Baja_cursada.UseVisualStyleBackColor = true;
            this.btn_Baja_cursada.Click += new System.EventHandler(this.btn_Baja_cursada_Click);
            // 
            // btn_Modificar_cursada
            // 
            this.btn_Modificar_cursada.Location = new System.Drawing.Point(6, 48);
            this.btn_Modificar_cursada.Name = "btn_Modificar_cursada";
            this.btn_Modificar_cursada.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar_cursada.TabIndex = 14;
            this.btn_Modificar_cursada.Text = "Modificar";
            this.btn_Modificar_cursada.UseVisualStyleBackColor = true;
            this.btn_Modificar_cursada.Click += new System.EventHandler(this.btn_Modificar_cursada_Click);
            // 
            // btn_Alta_cursada
            // 
            this.btn_Alta_cursada.Location = new System.Drawing.Point(6, 19);
            this.btn_Alta_cursada.Name = "btn_Alta_cursada";
            this.btn_Alta_cursada.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta_cursada.TabIndex = 13;
            this.btn_Alta_cursada.Text = "Alta";
            this.btn_Alta_cursada.UseVisualStyleBackColor = true;
            this.btn_Alta_cursada.Click += new System.EventHandler(this.btn_Alta_cursada_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Barra_busqueda,
            this.reestablecerGrillasToolStripMenuItem,
            this.ordenarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 27);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Barra_busqueda
            // 
            this.Barra_busqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Barra_busqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Barra_busqueda.Name = "Barra_busqueda";
            this.Barra_busqueda.Size = new System.Drawing.Size(200, 23);
            this.Barra_busqueda.Text = "Buscar elemento en grillas";
            this.Barra_busqueda.Leave += new System.EventHandler(this.Barra_busqueda_Leave);
            this.Barra_busqueda.Click += new System.EventHandler(this.Barra_busqueda_Click);
            this.Barra_busqueda.TextChanged += new System.EventHandler(this.Barra_busqueda_TextChanged);
            // 
            // reestablecerGrillasToolStripMenuItem
            // 
            this.reestablecerGrillasToolStripMenuItem.Name = "reestablecerGrillasToolStripMenuItem";
            this.reestablecerGrillasToolStripMenuItem.Size = new System.Drawing.Size(119, 23);
            this.reestablecerGrillasToolStripMenuItem.Text = "Reestablecer grillas";
            this.reestablecerGrillasToolStripMenuItem.Click += new System.EventHandler(this.reestablecerGrillasToolStripMenuItem_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grillaDePersonasToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.cursadasToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.alumnosToolStripMenuItem});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.ordenarToolStripMenuItem.Text = "Ordenar grillas";
            // 
            // grillaDePersonasToolStripMenuItem
            // 
            this.grillaDePersonasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porApellidoToolStripMenuItem,
            this.porEdadToolStripMenuItem});
            this.grillaDePersonasToolStripMenuItem.Name = "grillaDePersonasToolStripMenuItem";
            this.grillaDePersonasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grillaDePersonasToolStripMenuItem.Text = "Personas";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click_1);
            // 
            // porApellidoToolStripMenuItem
            // 
            this.porApellidoToolStripMenuItem.Name = "porApellidoToolStripMenuItem";
            this.porApellidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porApellidoToolStripMenuItem.Text = "Por apellido";
            this.porApellidoToolStripMenuItem.Click += new System.EventHandler(this.porApellidoToolStripMenuItem_Click_1);
            // 
            // porEdadToolStripMenuItem
            // 
            this.porEdadToolStripMenuItem.Name = "porEdadToolStripMenuItem";
            this.porEdadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porEdadToolStripMenuItem.Text = "Por edad";
            this.porEdadToolStripMenuItem.Click += new System.EventHandler(this.porEdadToolStripMenuItem_Click_1);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ascendenteToolStripMenuItem.Text = "Por nombre";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click_1);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descendenteToolStripMenuItem.Text = "Por año de revisión";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click_1);
            // 
            // cursadasToolStripMenuItem
            // 
            this.cursadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem1,
            this.porCicloLectivoToolStripMenuItem,
            this.porCantidadDeAlumnosToolStripMenuItem});
            this.cursadasToolStripMenuItem.Name = "cursadasToolStripMenuItem";
            this.cursadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cursadasToolStripMenuItem.Text = "Cursadas";
            // 
            // porNombreToolStripMenuItem1
            // 
            this.porNombreToolStripMenuItem1.Name = "porNombreToolStripMenuItem1";
            this.porNombreToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.porNombreToolStripMenuItem1.Text = "Por nombre";
            this.porNombreToolStripMenuItem1.Click += new System.EventHandler(this.porNombreToolStripMenuItem1_Click_1);
            // 
            // porCicloLectivoToolStripMenuItem
            // 
            this.porCicloLectivoToolStripMenuItem.Name = "porCicloLectivoToolStripMenuItem";
            this.porCicloLectivoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.porCicloLectivoToolStripMenuItem.Text = "Por ciclo lectivo";
            this.porCicloLectivoToolStripMenuItem.Click += new System.EventHandler(this.porCicloLectivoToolStripMenuItem_Click_1);
            // 
            // porCantidadDeAlumnosToolStripMenuItem
            // 
            this.porCantidadDeAlumnosToolStripMenuItem.Name = "porCantidadDeAlumnosToolStripMenuItem";
            this.porCantidadDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.porCantidadDeAlumnosToolStripMenuItem.Text = "Por cantidad de alumnos";
            this.porCantidadDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.porCantidadDeAlumnosToolStripMenuItem_Click_1);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem2,
            this.porApellidoToolStripMenuItem1,
            this.porEdadToolStripMenuItem1});
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docentesToolStripMenuItem.Text = "Docentes";
            // 
            // porNombreToolStripMenuItem2
            // 
            this.porNombreToolStripMenuItem2.Name = "porNombreToolStripMenuItem2";
            this.porNombreToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem2.Text = "Por nombre";
            this.porNombreToolStripMenuItem2.Click += new System.EventHandler(this.porNombreToolStripMenuItem2_Click_1);
            // 
            // porApellidoToolStripMenuItem1
            // 
            this.porApellidoToolStripMenuItem1.Name = "porApellidoToolStripMenuItem1";
            this.porApellidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.porApellidoToolStripMenuItem1.Text = "Por apellido";
            this.porApellidoToolStripMenuItem1.Click += new System.EventHandler(this.porApellidoToolStripMenuItem1_Click_1);
            // 
            // porEdadToolStripMenuItem1
            // 
            this.porEdadToolStripMenuItem1.Name = "porEdadToolStripMenuItem1";
            this.porEdadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.porEdadToolStripMenuItem1.Text = "Por edad";
            this.porEdadToolStripMenuItem1.Click += new System.EventHandler(this.porEdadToolStripMenuItem1_Click_1);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem3,
            this.porApellidoToolStripMenuItem2,
            this.porEdadToolStripMenuItem2});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // porNombreToolStripMenuItem3
            // 
            this.porNombreToolStripMenuItem3.Name = "porNombreToolStripMenuItem3";
            this.porNombreToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem3.Text = "Por nombre";
            this.porNombreToolStripMenuItem3.Click += new System.EventHandler(this.porNombreToolStripMenuItem3_Click_1);
            // 
            // porApellidoToolStripMenuItem2
            // 
            this.porApellidoToolStripMenuItem2.Name = "porApellidoToolStripMenuItem2";
            this.porApellidoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.porApellidoToolStripMenuItem2.Text = "Por apellido";
            this.porApellidoToolStripMenuItem2.Click += new System.EventHandler(this.porApellidoToolStripMenuItem2_Click_1);
            // 
            // porEdadToolStripMenuItem2
            // 
            this.porEdadToolStripMenuItem2.Name = "porEdadToolStripMenuItem2";
            this.porEdadToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.porEdadToolStripMenuItem2.Text = "Por edad";
            this.porEdadToolStripMenuItem2.Click += new System.EventHandler(this.porEdadToolStripMenuItem2_Click_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(18, 519);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 16;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Persona_asignar);
            this.groupBox4.Controls.Add(this.btn_Persona_desasignar);
            this.groupBox4.Location = new System.Drawing.Point(12, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(92, 84);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // lbl_Alumno_cursadas
            // 
            this.lbl_Alumno_cursadas.AutoSize = true;
            this.lbl_Alumno_cursadas.Location = new System.Drawing.Point(616, 376);
            this.lbl_Alumno_cursadas.Name = "lbl_Alumno_cursadas";
            this.lbl_Alumno_cursadas.Size = new System.Drawing.Size(193, 13);
            this.lbl_Alumno_cursadas.TabIndex = 23;
            this.lbl_Alumno_cursadas.Text = "Grilla de cursadas asociadas al alumno:";
            // 
            // dGV_Alumno_cursadas
            // 
            this.dGV_Alumno_cursadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alumno_cursadas.Location = new System.Drawing.Point(616, 392);
            this.dGV_Alumno_cursadas.Name = "dGV_Alumno_cursadas";
            this.dGV_Alumno_cursadas.Size = new System.Drawing.Size(370, 150);
            this.dGV_Alumno_cursadas.TabIndex = 22;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 556);
            this.Controls.Add(this.lbl_Alumno_cursadas);
            this.Controls.Add(this.dGV_Alumno_cursadas);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Cursada_alumnos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGV_Cursada_alumnos);
            this.Controls.Add(this.dGV_Materias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Cursadas);
            this.Controls.Add(this.dGV_Docentes);
            this.Controls.Add(this.dGV_Alumnos);
            this.Controls.Add(this.dGV_Personas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Interfaz";
            this.Text = "Universidad de tecnología";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Personas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Cursadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Docentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Cursada_alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Materias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alumno_cursadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Personas;
        private System.Windows.Forms.DataGridView dGV_Alumnos;
        private System.Windows.Forms.DataGridView dGV_Cursadas;
        private System.Windows.Forms.DataGridView dGV_Docentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Cursada_alumnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGV_Cursada_alumnos;
        private System.Windows.Forms.DataGridView dGV_Materias;
        private System.Windows.Forms.Button btn_Alta_persona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_Docente;
        private System.Windows.Forms.RadioButton rB_Alumno;
        private System.Windows.Forms.Button btn_Baja_persona;
        private System.Windows.Forms.Button btn_Modificar_persona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Baja_materia;
        private System.Windows.Forms.Button btn_Modificar_materia;
        private System.Windows.Forms.Button btn_Alta_materia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Baja_cursada;
        private System.Windows.Forms.Button btn_Modificar_cursada;
        private System.Windows.Forms.Button btn_Alta_cursada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Persona_desasignar;
        private System.Windows.Forms.Button btn_Persona_asignar;
        private System.Windows.Forms.ToolStripTextBox Barra_busqueda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_Alumno_cursadas;
        private System.Windows.Forms.DataGridView dGV_Alumno_cursadas;
        private System.Windows.Forms.ToolStripMenuItem reestablecerGrillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grillaDePersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porCicloLectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCantidadDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem porApellidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porEdadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem porApellidoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem porEdadToolStripMenuItem2;
    }
}

