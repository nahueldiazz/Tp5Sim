using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5Sim
{
    public partial class Form1 : Form
    {
        string llegada_cliente_sin_entrada = "Llegada cliente sin entrada";
        string fin_de_venta_entrada = "Fin de venta";
        string llegada_cliente_con_entrada = "Llegada cliente con entrada";
        string ingreso_a_sala = "Ingreso a sala";

        CalculoProbabilidad proxNum;

        //datos grilla 
        string evento;
        double reloj = 0;
        double llegadaClienteSE;
        double proximaLlegadaClienteSinEntrada = 0;
        double tiempoAtencion;
        double finDeVenta = 0;
        double CantidadEntradasAComprar;
        int colaDeVentas;
        double LlegadaclientCE;
        double proximaLlegadaClienteCE = 0;
        int cantidadQueLleganCE;
        double tiempoIngresoSala;
        double proximoIngreso = 0;
        int colaDeLaSala;
        int ingresoASala;
        int ClienteConAnticipada;
        int cantidadEntradaVendidas;




        //inicializacion de datos 
        double minutosASimular = 0;
        double desde = 0;
        double hastas = 0;
        double minutoLlegadaClienteConEntrada = 0;








        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            proxNum = new CalculoProbabilidad(double.Parse(maxClienteSinEntrada.Text), double.Parse(minimoClienteSinEntrada.Text), double.Parse(maximoVenta.Text),
                double.Parse(minimoTiempoVenta.Text), double.Parse(MaximoClienteConEntrada.Text), double.Parse(minimoClientConEntrada.Text), double.Parse(maximoEntradaSala.Text), double.Parse(minimoEntradaSala.Text));
            minutosASimular = double.Parse(minuto_simular.Text);
            desde = double.Parse(desde_input.Text);
            hastas = double.Parse(hasta_input.Text);
            minutoLlegadaClienteConEntrada = double.Parse(minuto_llegada_Ce.Text);

            proximoIngreso = 16;




            this.iniciarSimulacion();


        }

        public void iniciarSimulacion()
        {
            //calculo del primer reloj del primer evento desde reloj 0
            llegadaClienteSE = proxNum.calcularProbabilidadClienteSinEntrada();
            proximaLlegadaClienteSinEntrada = llegadaClienteSE + reloj;

            //caculo del primer cliente con entrada desde reloj 0
            LlegadaclientCE = proxNum.calcularProbabilidadClienteConEntrada();
            proximaLlegadaClienteCE = LlegadaclientCE + minutoLlegadaClienteConEntrada;



            while (reloj <= minutosASimular)
            {
                




            }

        }


        public void proximoEvento()
        {
            if (proximoIngreso == 0 && finDeVenta == 0)
            {
                reloj = proximaLlegadaClienteCE < proximaLlegadaClienteSinEntrada ? proximaLlegadaClienteCE : proximaLlegadaClienteSinEntrada;
                return;
            }

            if (proximoIngreso == 0)
            {

            }

         

        }


    }
}
