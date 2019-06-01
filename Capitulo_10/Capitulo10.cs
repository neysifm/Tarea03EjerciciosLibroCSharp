using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios.Capitulo_10;


namespace Ejercicios.Capitulo_10
{
    public partial class Capitulo10 : MetroFramework.Forms.MetroForm
    {
        //EJercicio 2
        List<Estudiantes> lista;
        //EJercicio 1
        List<Inventario> inventario;
        public Capitulo10()
        {
            InitializeComponent();
            lista = new List<Estudiantes>();
            inventario = new List<Inventario>();
           
        }
        //EJercicio 2
        private void GuardarEstudiantebutton_Click(object sender, EventArgs e)
        {

            Estudiantes estudiante = new Estudiantes();
            estudiante = GetEstudiante();

            if(estudiante != null)
             lista.Add(estudiante);

            LimpiarEstudiante();
        }
        private Estudiantes GetEstudiante()
        {
            Estudiantes estudiante = new Estudiantes
            {
                Nombre = NombreEstudiantetextBox.Text,
                Matricula = MatriculaEstudiantetextBox.Text,
                Grado = (int)GradoEstudiantenumericUpDown.Value,
                FechaIngreso = FechaIngresoEstudiantedateTimePicker.Value,
                NombreTutor = NombreTutorEstudiantetextBox.Text,
                TelefonoTutor = TelefonoTutorEstudiantetextBox.Text,
                Direccion = DireccionEstudiantetextBox.Text
            };

            return estudiante;
        }
        private void LimpiarEstudiante()
        {
            NombreEstudiantetextBox.Text =string.Empty;
            MatriculaEstudiantetextBox.Text = string.Empty;
            GradoEstudiantenumericUpDown.Value = 1;
            FechaIngresoEstudiantedateTimePicker.Value=DateTime.Now;
            NombreTutorEstudiantetextBox.Text = string.Empty;
            TelefonoTutorEstudiantetextBox.Text = string.Empty;
            DireccionEstudiantetextBox.Text = string.Empty;
        }
        private void NuevoEstudiantebutton_Click(object sender, EventArgs e)
        {
            LimpiarEstudiante();
        }
        private void EliminarEstudiantebutton_Click(object sender, EventArgs e)
        {
            lista.Remove(BuscarEstudiante(MatriculaEstudiantetextBox.Text));
            LimpiarEstudiante();
        }
        private Estudiantes BuscarEstudiante(string matricula)
        {
            foreach(Estudiantes obj in lista)
            {
                if(obj.Matricula.Equals(matricula))
                {
                    return obj;
                }
            }
            return new Estudiantes();
        }
        private void BuscarEstudiantebutton_Click(object sender, EventArgs e)
        {
            SetEstudiante(BuscarEstudiante(MatriculaEstudiantetextBox.Text));
        }
        private void SetEstudiante(Estudiantes estudiante)
        {
            NombreEstudiantetextBox.Text = estudiante.Nombre; ;
            MatriculaEstudiantetextBox.Text = estudiante.Matricula;
            GradoEstudiantenumericUpDown.Value = estudiante.Grado;
            FechaIngresoEstudiantedateTimePicker.Value = estudiante.FechaIngreso;
            NombreTutorEstudiantetextBox.Text = estudiante.NombreTutor;
            TelefonoTutorEstudiantetextBox.Text = estudiante.TelefonoTutor;
            DireccionEstudiantetextBox.Text = estudiante.Direccion;

        }
        //EJercicio 1
        private void GuardarProductobutton_Click(object sender, EventArgs e)
        {
            inventario.Add(GetProducto());
            LimpiarProducto();
        }
        private Inventario GetProducto()
        {

            Inventario producto = new Inventario
            {
                CodigoProducto = (int)CodigoProductonumericUpDown.Value,
                NombreProducto = NombreProductotextBox.Text,
                PrecioProducto = (float)PrecioProductonumericUpDown.Value,
                CantidadProducto = (int)CantidadProductonumericUpDown.Value,
                FechaCaducidad = FechaCaducidadProdcutodateTimePicker.Value,
                DescripcionProducto = DescripcionProductotextBox.Text,
                Gondola = (string)GondolaProductocomboBox.SelectedItem
            };

            return producto;
        }
        //EJercicio 1
        private void LimpiarProducto()
        {
            CodigoProductonumericUpDown.Value = 0;
            NombreProductotextBox.Text = string.Empty;
            PrecioProductonumericUpDown.Value= 0;
            CantidadProductonumericUpDown.Value = 0;
            FechaCaducidadProdcutodateTimePicker.Value = DateTime.Now;
            DescripcionProductotextBox.Text = string.Empty;
            GondolaProductocomboBox.SelectedItem = string.Empty;
        }
        private void NuevoProductobutton_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }
        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            SetProducto(BuscarProducto((int)CodigoProductonumericUpDown.Value));
        }
        private Inventario BuscarProducto(int codigo)
        {
            Inventario producto = new Inventario();
            foreach(Inventario obj in inventario)
            {
                if (obj.CodigoProducto == codigo)
                {
                    return producto = obj; 
                }
            }

            return producto;
        }
        private void SetProducto(Inventario producto)
        {
            CodigoProductonumericUpDown.Value = producto.CodigoProducto;
            NombreProductotextBox.Text = producto.NombreProducto;
            PrecioProductonumericUpDown.Value = (int)producto.PrecioProducto;
            CantidadProductonumericUpDown.Value = producto.CantidadProducto;
            FechaCaducidadProdcutodateTimePicker.Value = producto.FechaCaducidad;
            DescripcionProductotextBox.Text = producto.DescripcionProducto;
            GondolaProductocomboBox.SelectedItem = producto.Gondola;
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            inventario.Remove(BuscarProducto((int)CodigoProductonumericUpDown.Value));
            LimpiarProducto();
        }
        private void CalcualrPerimetrobutton_Click(object sender, EventArgs e)
        {
            Poligono poligono = new Poligono
            {
                Lados = (int)LadosPoligononumericUpDown.Value,
                Longitud = (float)LongitudPoligonosnumericUpDown.Value
            };

            ResultadoPoligonolabel.Text = poligono.Perimetro().ToString(); 
        }
        private void LimpiarPerimetrobutton_Click(object sender, EventArgs e)
        {
            LadosPoligononumericUpDown.Value = 0;
            LongitudPoligonosnumericUpDown.Value = 0;
            ResultadoPoligonolabel.Text = "0";
        }

        private void Capitulo10_Load(object sender, EventArgs e)
        {

        }
    }
}
