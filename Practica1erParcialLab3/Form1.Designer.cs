namespace Practica1erParcialLab3
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
            components = new System.ComponentModel.Container();
            dgAlumnos = new DataGridView();
            alumnoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alumnosBindingSource1 = new BindingSource(components);
            materiasBindingSource = new BindingSource(components);
            alumnosBindingSource = new BindingSource(components);
            dgMaterias = new DataGridView();
            materiaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblMateria = new Label();
            lblMostrarMat = new Label();
            label1 = new Label();
            lblMostrarAlum = new Label();
            btnBusca = new Button();
            txtBuscar = new TextBox();
            btnBuscarAlum = new Button();
            txtResultado = new TextBox();
            txtMat = new TextBox();
            txtAlum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMaterias).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgAlumnos
            // 
            dgAlumnos.AllowUserToAddRows = false;
            dgAlumnos.AllowUserToDeleteRows = false;
            dgAlumnos.AllowUserToOrderColumns = true;
            dgAlumnos.AutoGenerateColumns = false;
            dgAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Columns.AddRange(new DataGridViewColumn[] { alumnoIDDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, legajoDataGridViewTextBoxColumn });
            dgAlumnos.DataSource = alumnosBindingSource1;
            dgAlumnos.Dock = DockStyle.Fill;
            dgAlumnos.Location = new Point(0, 0);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowTemplate.Height = 25;
            dgAlumnos.Size = new Size(558, 355);
            dgAlumnos.TabIndex = 0;
            dgAlumnos.CellClick += dgAlumnos_CellClick;
            // 
            // alumnoIDDataGridViewTextBoxColumn
            // 
            alumnoIDDataGridViewTextBoxColumn.DataPropertyName = "_alumnoID";
            alumnoIDDataGridViewTextBoxColumn.HeaderText = "Alumno";
            alumnoIDDataGridViewTextBoxColumn.Name = "alumnoIDDataGridViewTextBoxColumn";
            alumnoIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "_apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.Width = 76;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "_nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 76;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            legajoDataGridViewTextBoxColumn.DataPropertyName = "legajo";
            legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            legajoDataGridViewTextBoxColumn.Width = 67;
            // 
            // alumnosBindingSource1
            // 
            alumnosBindingSource1.DataMember = "_alumnos";
            alumnosBindingSource1.DataSource = materiasBindingSource;
            // 
            // materiasBindingSource
            // 
            materiasBindingSource.DataSource = typeof(Materias_Alumnos.Materias);
            // 
            // alumnosBindingSource
            // 
            alumnosBindingSource.DataMember = "_alumnos";
            alumnosBindingSource.DataSource = materiasBindingSource;
            // 
            // dgMaterias
            // 
            dgMaterias.AllowUserToAddRows = false;
            dgMaterias.AllowUserToDeleteRows = false;
            dgMaterias.AllowUserToOrderColumns = true;
            dgMaterias.AutoGenerateColumns = false;
            dgMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMaterias.Columns.AddRange(new DataGridViewColumn[] { materiaIdDataGridViewTextBoxColumn });
            dgMaterias.DataSource = materiasBindingSource;
            dgMaterias.Dock = DockStyle.Fill;
            dgMaterias.Location = new Point(0, 0);
            dgMaterias.Name = "dgMaterias";
            dgMaterias.Size = new Size(212, 355);
            dgMaterias.TabIndex = 1;
            dgMaterias.CellClick += dgMaterias_CellClick;
            dgMaterias.CellContentClick += dgMaterias_CellContentClick;
            dgMaterias.CellMouseClick += dgMaterias_CellMouseClick;
            dgMaterias.SelectionChanged += dgMaterias_SelectionChanged;
            // 
            // materiaIdDataGridViewTextBoxColumn
            // 
            materiaIdDataGridViewTextBoxColumn.DataPropertyName = "_materiaId";
            materiaIdDataGridViewTextBoxColumn.HeaderText = "Materia";
            materiaIdDataGridViewTextBoxColumn.Name = "materiaIdDataGridViewTextBoxColumn";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(30, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 42);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Datos";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dgMaterias);
            panel1.Location = new Point(40, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 355);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgAlumnos);
            panel2.Location = new Point(332, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 355);
            panel2.TabIndex = 4;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(40, 463);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 5;
            lblMateria.Text = "Materia:";
            // 
            // lblMostrarMat
            // 
            lblMostrarMat.AutoSize = true;
            lblMostrarMat.Location = new Point(96, 463);
            lblMostrarMat.Name = "lblMostrarMat";
            lblMostrarMat.Size = new Size(0, 15);
            lblMostrarMat.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 463);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Alumno:";
            // 
            // lblMostrarAlum
            // 
            lblMostrarAlum.AutoSize = true;
            lblMostrarAlum.Location = new Point(391, 463);
            lblMostrarAlum.Name = "lblMostrarAlum";
            lblMostrarAlum.Size = new Size(0, 15);
            lblMostrarAlum.TabIndex = 8;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(273, 33);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(118, 23);
            btnBusca.TabIndex = 9;
            btnBusca.Text = "Buscar Materia:";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(409, 45);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(192, 23);
            txtBuscar.TabIndex = 10;
            // 
            // btnBuscarAlum
            // 
            btnBuscarAlum.Location = new Point(273, 62);
            btnBuscarAlum.Name = "btnBuscarAlum";
            btnBuscarAlum.Size = new Size(118, 23);
            btnBuscarAlum.TabIndex = 11;
            btnBuscarAlum.Text = "Buscar Alumno:";
            btnBuscarAlum.UseVisualStyleBackColor = true;
            btnBuscarAlum.Click += btnBuscarAlum_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(626, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(264, 73);
            txtResultado.TabIndex = 12;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // txtMat
            // 
            txtMat.Location = new Point(161, 34);
            txtMat.Name = "txtMat";
            txtMat.Size = new Size(100, 23);
            txtMat.TabIndex = 13;
            txtMat.TextAlign = HorizontalAlignment.Center;
            txtMat.TextChanged += txtMat_TextChanged;
            // 
            // txtAlum
            // 
            txtAlum.Location = new Point(161, 62);
            txtAlum.Name = "txtAlum";
            txtAlum.Size = new Size(100, 23);
            txtAlum.TabIndex = 14;
            txtAlum.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 695);
            Controls.Add(txtAlum);
            Controls.Add(txtMat);
            Controls.Add(txtResultado);
            Controls.Add(btnBuscarAlum);
            Controls.Add(txtBuscar);
            Controls.Add(btnBusca);
            Controls.Add(lblMostrarAlum);
            Controls.Add(label1);
            Controls.Add(lblMostrarMat);
            Controls.Add(lblMateria);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMaterias).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgAlumnos;
        private DataGridView dgMaterias;
        private Button btnBuscar;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn alumnoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private BindingSource alumnosBindingSource;
        private BindingSource materiasBindingSource;
        private DataGridViewTextBoxColumn materiaIdDataGridViewTextBoxColumn;
        private BindingSource alumnosBindingSource1;
        private Label lblMateria;
        private Label lblMostrarMat;
        private Label label1;
        private Label lblMostrarAlum;
        private Button btnBusca;
        private TextBox txtBuscar;
        private Button btnBuscarAlum;
        private TextBox txtResultado;
        private TextBox txtMat;
        private TextBox txtAlum;
    }
}