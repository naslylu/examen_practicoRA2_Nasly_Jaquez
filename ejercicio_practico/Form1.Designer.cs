namespace ejercicio_practico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.rb_Femenino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.cbo_Curso = new System.Windows.Forms.ComboBox();
            this.cbo_Seccion = new System.Windows.Forms.ComboBox();
            this.cbo_Area = new System.Windows.Forms.ComboBox();
            this.txt_MaestroTitular = new System.Windows.Forms.TextBox();
            this.dgv_Registros = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area_Tecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maestro_Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.sfd_Guardar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Seccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 371);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Area Tecnica";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 418);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Maestro Titular";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Matricula.Location = new System.Drawing.Point(146, 27);
            this.txt_Matricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(116, 20);
            this.txt_Matricula.TabIndex = 10;
            this.txt_Matricula.TextChanged += new System.EventHandler(this.txt_Matricula_TextChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(146, 64);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(116, 20);
            this.txt_Nombre.TabIndex = 11;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(146, 103);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(116, 20);
            this.txt_Direccion.TabIndex = 12;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(146, 143);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(116, 20);
            this.txt_Telefono.TabIndex = 13;
            // 
            // rb_Femenino
            // 
            this.rb_Femenino.AutoSize = true;
            this.rb_Femenino.Location = new System.Drawing.Point(134, 185);
            this.rb_Femenino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Femenino.Name = "rb_Femenino";
            this.rb_Femenino.Size = new System.Drawing.Size(79, 17);
            this.rb_Femenino.TabIndex = 14;
            this.rb_Femenino.TabStop = true;
            this.rb_Femenino.Text = "Femenino";
            this.rb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(240, 185);
            this.rb_Masculino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(82, 17);
            this.rb_Masculino.TabIndex = 15;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.Text = "Masculino";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(146, 225);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(116, 20);
            this.txt_Email.TabIndex = 16;
            // 
            // cbo_Curso
            // 
            this.cbo_Curso.FormattingEnabled = true;
            this.cbo_Curso.Items.AddRange(new object[] {
            "4to",
            "5to",
            "6to"});
            this.cbo_Curso.Location = new System.Drawing.Point(146, 272);
            this.cbo_Curso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Curso.Name = "cbo_Curso";
            this.cbo_Curso.Size = new System.Drawing.Size(140, 21);
            this.cbo_Curso.TabIndex = 17;
            // 
            // cbo_Seccion
            // 
            this.cbo_Seccion.FormattingEnabled = true;
            this.cbo_Seccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbo_Seccion.Location = new System.Drawing.Point(146, 320);
            this.cbo_Seccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Seccion.Name = "cbo_Seccion";
            this.cbo_Seccion.Size = new System.Drawing.Size(140, 21);
            this.cbo_Seccion.TabIndex = 18;
            // 
            // cbo_Area
            // 
            this.cbo_Area.FormattingEnabled = true;
            this.cbo_Area.Items.AddRange(new object[] {
            "Enfermeria",
            "Contabilidad",
            "Gastronomia",
            "Informatica",
            "Electicidad"});
            this.cbo_Area.Location = new System.Drawing.Point(146, 368);
            this.cbo_Area.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Area.Name = "cbo_Area";
            this.cbo_Area.Size = new System.Drawing.Size(140, 21);
            this.cbo_Area.TabIndex = 19;
            // 
            // txt_MaestroTitular
            // 
            this.txt_MaestroTitular.Location = new System.Drawing.Point(146, 415);
            this.txt_MaestroTitular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaestroTitular.Name = "txt_MaestroTitular";
            this.txt_MaestroTitular.Size = new System.Drawing.Size(116, 20);
            this.txt_MaestroTitular.TabIndex = 20;
            // 
            // dgv_Registros
            // 
            this.dgv_Registros.AllowUserToAddRows = false;
            this.dgv_Registros.AllowUserToDeleteRows = false;
            this.dgv_Registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.Genero,
            this.Email,
            this.Curso,
            this.Seccion,
            this.Area_Tecnica,
            this.Maestro_Titular});
            this.dgv_Registros.Location = new System.Drawing.Point(14, 467);
            this.dgv_Registros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_Registros.Name = "dgv_Registros";
            this.dgv_Registros.ReadOnly = true;
            this.dgv_Registros.Size = new System.Drawing.Size(1086, 150);
            this.dgv_Registros.TabIndex = 21;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Area_Tecnica
            // 
            this.Area_Tecnica.HeaderText = "Area_Tecnica";
            this.Area_Tecnica.Name = "Area_Tecnica";
            this.Area_Tecnica.ReadOnly = true;
            // 
            // Maestro_Titular
            // 
            this.Maestro_Titular.HeaderText = "Maestro_Titular";
            this.Maestro_Titular.Name = "Maestro_Titular";
            this.Maestro_Titular.ReadOnly = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Nuevo.Location = new System.Drawing.Point(558, 12);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(172, 59);
            this.btn_Nuevo.TabIndex = 22;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Location = new System.Drawing.Point(558, 80);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(172, 64);
            this.btn_Guardar.TabIndex = 23;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(558, 238);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(172, 64);
            this.btn_Eliminar.TabIndex = 24;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(558, 163);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(172, 60);
            this.btn_Agregar.TabIndex = 25;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpiar.Location = new System.Drawing.Point(558, 320);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(172, 61);
            this.btn_Limpiar.TabIndex = 26;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Location = new System.Drawing.Point(558, 394);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(172, 53);
            this.btn_Salir.TabIndex = 27;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 618);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dgv_Registros);
            this.Controls.Add(this.txt_MaestroTitular);
            this.Controls.Add(this.cbo_Area);
            this.Controls.Add(this.cbo_Seccion);
            this.Controls.Add(this.cbo_Curso);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.rb_Masculino);
            this.Controls.Add(this.rb_Femenino);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.RadioButton rb_Femenino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox cbo_Curso;
        private System.Windows.Forms.ComboBox cbo_Seccion;
        private System.Windows.Forms.ComboBox cbo_Area;
        private System.Windows.Forms.TextBox txt_MaestroTitular;
        private System.Windows.Forms.DataGridView dgv_Registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area_Tecnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maestro_Titular;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.SaveFileDialog sfd_Guardar;
    }
}

