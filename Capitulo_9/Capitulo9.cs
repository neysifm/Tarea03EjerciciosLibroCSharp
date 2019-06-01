﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Capitulo_9
{
    public partial class Capitulo9 : MetroFramework.Forms.MetroForm
    {
        List<Mascota> lista;
        public struct Producto
        {
            public string nombre;
            public float precio;
            public DateTime fechaCaducidad;
        }
        public struct Dueño
        {
            public string nombre;
            public string direccion;
            public string telefono;

            public Dueño(string nombre,string direccion,string telefono)
            {
                this.nombre = nombre;
                this.direccion = direccion;
                this.telefono = telefono;
            }
        }
        public struct Mascota
        {
            public string nombre;
            public int edad;
            public string raza;
            public Dueño dueño;
        }
        public Capitulo9()
        {
            InitializeComponent();
            lista = new List<Mascota>();
        }
        private void AgregarProductobutton_Click(object sender, EventArgs e)
        {
            Producto producto;
            producto.nombre =NombreProductotextBox.Text;
            producto.precio = (float)PrecioProductonumericUpDown.Value;
            producto.fechaCaducidad = FechaCaducidaddateTimePicker.Value;

            ListViewItem item = new ListViewItem(producto.nombre);
            item.SubItems.Add(producto.precio.ToString());
            item.SubItems.Add(producto.fechaCaducidad.ToShortDateString());
            ProductoslistView.Items.Add(item);

            NombreProductotextBox.Text = string.Empty;
            PrecioProductonumericUpDown.Value = 0;
            FechaCaducidaddateTimePicker.Value = DateTime.Now;
        }
        private void GuardarMascotabutton_Click(object sender, EventArgs e)
        {
            Mascota mascota;
            mascota.nombre = NombreMascotatextBox.Text;
            mascota.edad = (int)EdadMascotanumericUpDown.Value;
            mascota.raza = RazaMascotatextBox.Text;
            mascota.dueño.nombre = NombreDueñotextBox.Text;
            mascota.dueño.telefono = TelefonoDueñotextBox.Text;
            mascota.dueño.direccion = DirecciónDueñotextBox.Text;
            lista.Add(mascota);
            LimpiarMascota();
        }
        private void LimpiarMascota()
        {
            NombreMascotatextBox.Text = string.Empty; 
            EdadMascotanumericUpDown.Value=0;
            RazaMascotatextBox.Text = string.Empty; 
            NombreDueñotextBox.Text = string.Empty; 
            TelefonoDueñotextBox.Text = string.Empty; 
            DirecciónDueñotextBox.Text = string.Empty; 
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarMascota();
        }
        private void BuscarMascotabutton_Click(object sender, EventArgs e)
        {
                Mascota mascota = new Mascota();
                foreach (Mascota obj in lista)
                {
                    if(obj.nombre.Equals(NombreMascotatextBox.Text))
                    {
                        mascota = obj;
                        break;
                    }             
                }
                NombreMascotatextBox.Text = mascota.nombre;
                EdadMascotanumericUpDown.Value = mascota.edad;
                RazaMascotatextBox.Text = mascota.raza;
                NombreDueñotextBox.Text = mascota.dueño.nombre;
                TelefonoDueñotextBox.Text = mascota.dueño.telefono;
                DirecciónDueñotextBox.Text = mascota.dueño.direccion;    
        }

        private void Capitulo9_Load(object sender, EventArgs e)
        {

        }
    }
}
