﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiempoDeViajetp1
{
    public partial class FTiempoDeViaje : Form
    {
        public FTiempoDeViaje()
        {
            InitializeComponent();
        }

        string destino;
        double distancia;
        double velocidad;
        double tiempo;

        private void TiempoDeViaje_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void bCalcularTiempo_Click(object sender, EventArgs e)
        {
            destino = Convert.ToString(tDestino.Text);
            distancia = Convert.ToDouble(tDistancia.Text);
            velocidad = Convert.ToDouble(tVelocidad.Text);

            tiempo = distancia / velocidad;

            MessageBox.Show("El tiempo que durara el viaje hasta " + destino + " es de: \n " + tiempo + " horas");

        }
    }
}
