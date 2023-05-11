using Materias_Alumnos;
using System.Collections;
using System.Collections.Generic;

namespace Practica1erParcialLab3
{

    public partial class Form1 : Form
    {
        private List<Materias> lista = new List<Materias>();
        int n = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de alumnos";
            lblMostrarMat.Text = "";
            lblMostrarAlum.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtMat.Text);
            int j = Convert.ToInt32(txtAlum.Text);


            Generador g = new Generador();
            lista = g.GenerarAlumnos(i, j);
            dgMaterias.AutoGenerateColumns = false;
            dgMaterias.DataSource = lista;

        }

        private void dgMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgMaterias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }

        private void dgMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMaterias.CurrentRow != null)
            {
                var mateariaSeleccionada = (Materias)dgMaterias.CurrentRow.DataBoundItem;
                dgAlumnos.DataSource = mateariaSeleccionada._alumnos;
            }

        }

        private void dgMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex; //obtenemos la informacion del evento mediante RowIndex(indice de la fila)

            if (n != -1)//para descartar el encabezado
            {
                lblMostrarMat.Text = (string)dgMaterias.Rows[n].Cells[0].Value;
            }
        }

        private void dgAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex; //obtenemos la informacion del evento mediante RowIndex(indice de la fila)

            //obtenemos la informacion del evento mediante RowIndex(indice de la fila)

            if (n != -1)//para descartar el encabezado
            {
                var u = dgAlumnos.Rows[n].Cells[0].Value;
                var y = dgAlumnos.Rows[n].Cells[1].Value;
                var j = dgAlumnos.Rows[n].Cells[2].Value;
                var k = dgAlumnos.Rows[n].Cells[3].Value;
                var MOSTRAR = $"{u.ToString()} {y.ToString()}{j.ToString()} {k.ToString()}";
                lblMostrarAlum.Text = MOSTRAR;
            }

            int indiceFilaSeleccionada = e.RowIndex;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

            string nombre = txtBuscar.Text;

            foreach (DataGridViewRow row in dgMaterias.Rows)
            {
                string nombremateria = row.Cells[2].Value.ToString();
                if (nombremateria.ToLower().Contains(nombre.ToLower()))
                {
                    row.Selected = true;
                    dgMaterias.CurrentCell = row.Cells[2];
                    break;
                }
            }
        }

        private void btnBuscarAlum_Click(object sender, EventArgs e)
        {


            string nombre = txtBuscar.Text;
            foreach (DataGridViewRow row in dgAlumnos.Rows)
            {
                string nombreAlumno = row.Cells[2].Value.ToString();

                if (nombreAlumno.ToLower().Contains(nombre.ToLower()))
                {
                    row.Selected = true;
                    dgAlumnos.CurrentCell = row.Cells[2];

                    // Obtener el índice de la fila seleccionada
                    int indiceFilaSeleccionada = row.Index;

                    // Obtener la información que deseas mostrar y asignarla al TextBox
                    if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dgAlumnos.Rows.Count)
                    {
                        DataGridViewRow filaSeleccionada = dgAlumnos.Rows[indiceFilaSeleccionada];
                        var detalle = $"Id: {filaSeleccionada.Cells[0].Value.ToString()}\r\n{filaSeleccionada.Cells[1].Value.ToString()}\r\n{filaSeleccionada.Cells[2].Value.ToString()}\r\n{filaSeleccionada.Cells[3].Value.ToString()}";
                        txtResultado.Text = detalle;
                    }

                    break;

                }
            }
        }
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMat_TextChanged(object sender, EventArgs e)
        {

        }



        /*
        string nombre = txtBuscar.Text;

        Alumno alumnoEncontrado = clase.Alumnos.FirstOrDefault(a => a.Nombre.ToLower().Contains(nombre.ToLower()));


        if (alumnoEncontrado != null)
        {
            txtResultado.Text = alumnoEncontrado.Nombre;
        }
        else
        {
            txtResultado.Text = "Alumno no encontrado";
        }
        */
    }
}
