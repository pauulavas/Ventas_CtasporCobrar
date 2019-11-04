﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_VentasyCtasPorCobrar
{
    public partial class Cliente : Form
    {
        //string usuario = "";
        public Cliente()
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "Nombre", "Apellido", "Telefono", "Direccion","DPI","NIT","Nombre Contacto","Telefono Contacto","Tipo Cliente","estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
           
            navegador1.asignarTabla("tbl_clientes");
            navegador1.asignarNombreForm("Clientes");
            navegador1.asignarComboConTabla("tbl_tipocliente", "kidtipocliente",1);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}