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
        double llegadaClienteSE = 0;
        double proximaLlegadaClienteSinEntrada = 0;
        double tiempoAtencion = 0;
        double finDeVenta = 0;
        int CantidadEntradasAComprar = 0;
        int colaDeVentas = 0;
        double LlegadaclientCE = 0;
        double proximaLlegadaClienteCE = 0;
        int cantidadQueLleganCE = 0;
        double tiempoIngresoSala = 0;
        double proximoIngreso = 0;
        int colaDeLaSala = 0;

        int clienteConAnticipada = 0;
        int cantidadEntradaVendidas = 0;
        int capacidadCine = 0;

        int i = 0;




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
            dataGridView1.Rows.Clear();
            this.inicializarVariables();
            i = 0;

            proxNum = new CalculoProbabilidad(double.Parse(maxClienteSinEntrada.Text), double.Parse(minimoClienteSinEntrada.Text), double.Parse(maximoVenta.Text),
                double.Parse(minimoTiempoVenta.Text), double.Parse(MaximoClienteConEntrada.Text), double.Parse(minimoClientConEntrada.Text), double.Parse(maximoEntradaSala.Text), double.Parse(minimoEntradaSala.Text));
            minutosASimular = double.Parse(minuto_simular.Text);
            desde = double.Parse(desde_input.Text);
            hastas = double.Parse(hasta_input.Text);
            minutoLlegadaClienteConEntrada = double.Parse(minuto_llegada_Ce.Text);

            proximoIngreso = double.Parse(minutos_ingrso_cine.Text);





            this.iniciarSimulacion();


        }

        public void inicializarVariables()
        {

            //datos grilla 
           
            double reloj = 0;
            double llegadaClienteSE = 0;
            double proximaLlegadaClienteSinEntrada = 0;
            double tiempoAtencion = 0;
            double finDeVenta = 0;
            int CantidadEntradasAComprar = 0;
            int colaDeVentas = 0;
            double LlegadaclientCE = 0;
            double proximaLlegadaClienteCE = 0;
            int cantidadQueLleganCE = 0;
            double tiempoIngresoSala = 0;
            double proximoIngreso = 0;
            int colaDeLaSala = 0;

            int clienteConAnticipada = 0;
            int cantidadEntradaVendidas = 0;
            int capacidadCine = 0;

            int i = 0;




            //inicializacion de datos 
            double minutosASimular = 0;
            double desde = 0;
            double hastas = 0;
            double minutoLlegadaClienteConEntrada = 0;


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
                this.proximoEvento();
                var valorSwitch = this.nombreEvento();

                switch(valorSwitch)
                {
                    case 1: //cliente sin entrada 
                        evento = llegada_cliente_sin_entrada;
                            llegadaClienteSE = proxNum.calcularProbabilidadClienteSinEntrada();
                            proximaLlegadaClienteSinEntrada = llegadaClienteSE + reloj;

                            if (finDeVenta != 0 && finDeVenta > proximaLlegadaClienteSinEntrada)
                            {
                                colaDeVentas = colaDeVentas + 1;
                                tiempoAtencion = 0;
                            }
                            else if (finDeVenta == 0)
                            {
                     
                                    tiempoAtencion = proxNum.calcularProbabilidadVentaDeEntrada();
                                    finDeVenta = tiempoAtencion + reloj;
                                    colaDeVentas = colaDeVentas != 0 ? colaDeVentas - 1 : colaDeVentas;
                            }
                           


                        LlegadaclientCE = 0;
                        cantidadQueLleganCE = 0;
                        cantidadQueLleganCE = 0;
                        tiempoIngresoSala = 0;

                        break;
                    case 2: //cliente con entrada
                        evento = llegada_cliente_con_entrada;
                        LlegadaclientCE = proxNum.calcularProbabilidadClienteConEntrada();
                        proximaLlegadaClienteCE = LlegadaclientCE + reloj;

                        cantidadQueLleganCE = proxNum.personasQueLleganConEntradas();
                        colaDeLaSala += cantidadQueLleganCE;
                        //cantidadEntradaVendidas += cantidadQueLleganCE;
                        clienteConAnticipada += cantidadQueLleganCE;


                        tiempoIngresoSala = 0;
                        llegadaClienteSE = 0;
                        CantidadEntradasAComprar = 0;
                        tiempoAtencion = 0;
                        break;
                        

                    case 3: //fin de ventas
                        evento = fin_de_venta_entrada;
                        CantidadEntradasAComprar = proxNum.entradaQueCompraClienteSinEntrada();
                        colaDeLaSala += CantidadEntradasAComprar;
                        cantidadEntradaVendidas += CantidadEntradasAComprar;
                        tiempoAtencion = proxNum.calcularProbabilidadVentaDeEntrada();
                        finDeVenta = tiempoAtencion + reloj;
                        colaDeVentas = colaDeVentas != 0 ? colaDeVentas - 1 : colaDeVentas;


                        tiempoIngresoSala = 0;
                        LlegadaclientCE = 0;
                        llegadaClienteSE = 0;
                        cantidadQueLleganCE = 0;
                        break;

                    case 4: //entrada a sala 
                        evento = ingreso_a_sala;

                        tiempoIngresoSala = proxNum.calcularProbabilidadEntradaASala();
                        proximoIngreso = tiempoIngresoSala + reloj;
                        capacidadCine = capacidadCine == 100 || colaDeLaSala == 0 ? capacidadCine : capacidadCine + 1;
                        colaDeLaSala = capacidadCine == 100 || colaDeLaSala == 0 ? colaDeLaSala : colaDeLaSala - 1;




                        LlegadaclientCE = 0;
                        llegadaClienteSE = 0;
                        cantidadQueLleganCE = 0;
                        CantidadEntradasAComprar = 0;
                        tiempoAtencion = 0;
                        break;
                                
                }

                if (reloj >= desde && reloj <= hastas)
                {
                    dataGridView1.Rows.Add(i,evento, reloj, llegadaClienteSE, proximaLlegadaClienteSinEntrada, tiempoAtencion, finDeVenta, CantidadEntradasAComprar, colaDeVentas, LlegadaclientCE, proximaLlegadaClienteCE, cantidadQueLleganCE, tiempoIngresoSala, proximoIngreso, colaDeLaSala, capacidadCine, clienteConAnticipada, cantidadEntradaVendidas);
                }

                i++;

            }

            dataGridView1.Rows.Add(i,evento, minutosASimular, llegadaClienteSE, proximaLlegadaClienteSinEntrada, tiempoAtencion, finDeVenta, CantidadEntradasAComprar, colaDeVentas, LlegadaclientCE, proximaLlegadaClienteCE, cantidadQueLleganCE, tiempoIngresoSala, proximoIngreso, colaDeLaSala, capacidadCine, clienteConAnticipada, cantidadEntradaVendidas);

        }


        public void proximoEvento()
        {
            List<double> num = new List<double>();

            
            if (finDeVenta == 0)
            {
                num.Add(proximaLlegadaClienteCE);
                num.Add(proximaLlegadaClienteSinEntrada);
                num.Add(proximoIngreso);
                reloj = num.Min();
                return;
            }
            else
            {
                num.Add(proximaLlegadaClienteCE);
                num.Add(proximaLlegadaClienteSinEntrada);
                num.Add(proximoIngreso);
                num.Add(finDeVenta);
                reloj = num.Min();
                return;

            }

        }

        public int nombreEvento()
        {
            if (reloj == proximaLlegadaClienteSinEntrada) return 1;
            if (reloj == proximaLlegadaClienteCE) return 2;
            if (finDeVenta != 0 && reloj == finDeVenta) return 3;

            return 4;
        }   


    }
}
