namespace Escuela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtmatricula = new TextBox();
            txtnombre = new TextBox();
            txtgrupo = new TextBox();
            txtespecialidad = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnguardar = new Button();
            btnmostrar = new Button();
            btnlimpiar = new Button();
            dgvalumnos = new DataGridView();
            nudsemestre = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvalumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudsemestre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 162);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 39);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Semestre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 162);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Grupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 251);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Especialidad:";
            // 
            // txtmatricula
            // 
            txtmatricula.Location = new Point(95, 31);
            txtmatricula.Name = "txtmatricula";
            txtmatricula.Size = new Size(171, 23);
            txtmatricula.TabIndex = 5;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(95, 158);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(171, 23);
            txtnombre.TabIndex = 6;
            // 
            // txtgrupo
            // 
            txtgrupo.Location = new Point(400, 154);
            txtgrupo.Name = "txtgrupo";
            txtgrupo.Size = new Size(169, 23);
            txtgrupo.TabIndex = 8;
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(400, 251);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new Size(169, 23);
            txtespecialidad.TabIndex = 9;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(620, 34);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 10;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(620, 153);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(75, 23);
            btnmostrar.TabIndex = 11;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(620, 263);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 12;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvalumnos
            // 
            dgvalumnos.AllowUserToAddRows = false;
            dgvalumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvalumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvalumnos.Location = new Point(29, 377);
            dgvalumnos.Name = "dgvalumnos";
            dgvalumnos.ReadOnly = true;
            dgvalumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvalumnos.Size = new Size(666, 258);
            dgvalumnos.TabIndex = 13;
            // 
            // nudsemestre
            // 
            nudsemestre.Location = new Point(400, 32);
            nudsemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudsemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudsemestre.Name = "nudsemestre";
            nudsemestre.Size = new Size(169, 23);
            nudsemestre.TabIndex = 14;
            nudsemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 669);
            Controls.Add(nudsemestre);
            Controls.Add(dgvalumnos);
            Controls.Add(btnlimpiar);
            Controls.Add(btnmostrar);
            Controls.Add(btnguardar);
            Controls.Add(txtespecialidad);
            Controls.Add(txtgrupo);
            Controls.Add(txtnombre);
            Controls.Add(txtmatricula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvalumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudsemestre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtmatricula;
        private TextBox txtnombre;
        private TextBox txtgrupo;
        private TextBox txtespecialidad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnguardar;
        private Button btnmostrar;
        private Button btnlimpiar;
        private DataGridView dgvalumnos;
        private NumericUpDown nudsemestre;
    }
}
