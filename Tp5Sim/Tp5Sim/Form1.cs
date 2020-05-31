using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5Sim
{
    public partial class Form1 : Form
    {
        string inicio_evento = "Inic. evento"; 
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
        string estVendedorEnt = "Libre";
        string estCortadorEnt = "Libre";

        double countSeLlenoCine = 0;
        double cantSimulaciones = 0;
        int i = 0;
        int paramCapacidadCine;



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
            //cantidad de simulaciones
            cantSimulaciones++;
            dataGridView1.Rows.Clear();
            this.inicializarVariables();
          //  i = 0;

            proxNum = new CalculoProbabilidad(double.Parse(maxClienteSinEntrada.Text), double.Parse(minimoClienteSinEntrada.Text), double.Parse(maximoVenta.Text),
                double.Parse(minimoTiempoVenta.Text), double.Parse(MaximoClienteConEntrada.Text), double.Parse(minimoClientConEntrada.Text), double.Parse(maximoEntradaSala.Text), double.Parse(minimoEntradaSala.Text));
            minutosASimular = double.Parse(minuto_simular.Text);
            desde = double.Parse(desde_input.Text);
            hastas = double.Parse(hasta_input.Text);
            minutoLlegadaClienteConEntrada = double.Parse(minuto_llegada_Ce.Text);
            paramCapacidadCine = int.Parse(capacidad_cine.Text);
            proximoIngreso = double.Parse(minutos_ingrso_cine.Text);

            this.iniciarSimulacion();


        }

        public void inicializarVariables()
        {

            //datos grilla 
           
             reloj = 0;
             llegadaClienteSE = 0;
             proximaLlegadaClienteSinEntrada = 0;
             tiempoAtencion = 0;
             finDeVenta = 0;
             CantidadEntradasAComprar = 0;
             colaDeVentas = 0;
             LlegadaclientCE = 0;
             proximaLlegadaClienteCE = 0;
             cantidadQueLleganCE = 0;
             tiempoIngresoSala = 0;
             proximoIngreso = 0;
             colaDeLaSala = 0;

             clienteConAnticipada = 0;
             cantidadEntradaVendidas = 0;
             capacidadCine = 0;

            estVendedorEnt = "Libre";
            estCortadorEnt = "Libre";
            i = 0;




            //inicializacion de datos 
             minutosASimular = 0;
             desde = 0;
             hastas = 0;
             minutoLlegadaClienteConEntrada = 0;


        }

        public void iniciarSimulacion()
        {
            //calculo del primer reloj del primer evento desde reloj 0
            llegadaClienteSE = proxNum.calcularProbabilidadClienteSinEntrada();
            proximaLlegadaClienteSinEntrada = llegadaClienteSE + reloj;

            //caculo del primer cliente con entrada desde reloj 0
            LlegadaclientCE = proxNum.calcularProbabilidadClienteConEntrada();
            proximaLlegadaClienteCE = LlegadaclientCE + minutoLlegadaClienteConEntrada;

            dataGridView1.Rows.Add(i, inicio_evento, reloj, llegadaClienteSE, proximaLlegadaClienteSinEntrada, tiempoAtencion, finDeVenta, CantidadEntradasAComprar, estVendedorEnt, colaDeVentas, LlegadaclientCE, proximaLlegadaClienteCE, cantidadQueLleganCE, tiempoIngresoSala, proximoIngreso, estCortadorEnt, colaDeLaSala, capacidadCine, clienteConAnticipada, cantidadEntradaVendidas);

            while (reloj <= minutosASimular)
            {
                i++;
                this.proximoEvento();
                var valorSwitch = this.nombreEvento();

                switch(valorSwitch)
                {
                    case 1: //cliente sin entrada 
                        evento = llegada_cliente_sin_entrada;
                            llegadaClienteSE = proxNum.calcularProbabilidadClienteSinEntrada();
                            proximaLlegadaClienteSinEntrada = llegadaClienteSE + reloj;

                        estVendedorEnt = "Ocupado";

                        if (finDeVenta != 0 && finDeVenta > proximaLlegadaClienteSinEntrada)
                        {
                            colaDeVentas++;
                            tiempoAtencion = 0;
                        }
                        else if (finDeVenta == 0)
                        {
                            
                            tiempoAtencion = proxNum.calcularProbabilidadVentaDeEntrada();
                            finDeVenta = tiempoAtencion + reloj;
                            colaDeVentas = colaDeVentas != 0 ? colaDeVentas - 1 : colaDeVentas;
                        }
                        else {
                            colaDeVentas++;
                            tiempoAtencion = 0;

                        }
                        LlegadaclientCE = 0;
                        cantidadQueLleganCE = 0;
                        CantidadEntradasAComprar = 0;
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
                        if (double.Parse(minutos_ingrso_cine.Text) <= reloj)
                        {
                            estCortadorEnt = colaDeLaSala == 0 || colaDeLaSala == paramCapacidadCine ? "Libre" : "Ocupado";
                        }

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
                      
                        colaDeVentas = colaDeVentas != 0 ? colaDeVentas - 1 : colaDeVentas;
                        estVendedorEnt = colaDeVentas == 0 ? "Libre" : "Ocupado";

                        if (colaDeVentas != 0)
                        {
                            tiempoAtencion = proxNum.calcularProbabilidadVentaDeEntrada();
                            finDeVenta = tiempoAtencion + reloj;
                        }
                        else
                        {
                            tiempoAtencion = 0;
                            finDeVenta = 0;
                        }
                        if (double.Parse(minutos_ingrso_cine.Text) <= reloj) {
                            estCortadorEnt = colaDeLaSala == 0 || colaDeLaSala == paramCapacidadCine ? "Libre" : "Ocupado";
                        }
                        
                       
                        tiempoIngresoSala = 0;
                        LlegadaclientCE = 0;
                        llegadaClienteSE = 0;
                        cantidadQueLleganCE = 0;
                        break;

                    case 4: //entrada a sala 
                        evento = ingreso_a_sala;

                        tiempoIngresoSala = proxNum.calcularProbabilidadEntradaASala();
                        proximoIngreso = tiempoIngresoSala + reloj;
                        capacidadCine = capacidadCine == paramCapacidadCine || colaDeLaSala == 0 ? capacidadCine : capacidadCine + 1;
                        colaDeLaSala = capacidadCine == paramCapacidadCine || colaDeLaSala == 0 ? colaDeLaSala : colaDeLaSala - 1;

                        estCortadorEnt = colaDeLaSala == 0 || colaDeLaSala == paramCapacidadCine ? "Libre" : "Ocupado";


                        LlegadaclientCE = 0;
                        llegadaClienteSE = 0;
                        cantidadQueLleganCE = 0;
                        CantidadEntradasAComprar = 0;
                        tiempoAtencion = 0;
                        break;
                                
                }

                if (reloj >= desde && reloj <= hastas)
                {
                    dataGridView1.Rows.Add(i,evento, reloj, llegadaClienteSE, proximaLlegadaClienteSinEntrada, tiempoAtencion, finDeVenta, CantidadEntradasAComprar,estVendedorEnt, colaDeVentas, LlegadaclientCE, proximaLlegadaClienteCE, cantidadQueLleganCE, tiempoIngresoSala, proximoIngreso, estCortadorEnt,colaDeLaSala, capacidadCine, clienteConAnticipada, cantidadEntradaVendidas);
                }
            }

            dataGridView1.Rows.Add(i, evento, minutosASimular, llegadaClienteSE, proximaLlegadaClienteSinEntrada, tiempoAtencion, finDeVenta, CantidadEntradasAComprar, estVendedorEnt, colaDeVentas, LlegadaclientCE, proximaLlegadaClienteCE, cantidadQueLleganCE, tiempoIngresoSala, proximoIngreso, estCortadorEnt, colaDeLaSala, capacidadCine, clienteConAnticipada, cantidadEntradaVendidas);
            
            int r = dataGridView1.Rows.Count;
            dataGridView1.Rows[r - 1].DefaultCellStyle.ForeColor = Color.FromArgb(156, 0, 6);
            dataGridView1.Rows[r - 1].DefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Punto a
            this.probabiliadQueSeLLeneElCine();
            //Punto b
            this.porcentajePersonaConEntradaNoPuedaEntrar();
            //Punto c
            this.descEnPorcentajeOtorgadoEntAnt();
            //Punto d
            this.cantidadMaximaEnColaVtaEntrada();
            //Punto e
            this.personasEnColaPorEntrar(colaDeLaSala);
            //Punto f
            this.cantidadEntradaVendiasEnCine();

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

        public void probabiliadQueSeLLeneElCine()
        {
            if ((capacidadCine / Convert.ToInt32(capacidad_cine.Text)) == 1)
            {
                countSeLlenoCine++;
            }
            txt_pr_se_llena_cine.Text = proxNum.TruncateFunction((countSeLlenoCine / cantSimulaciones) * 100, 2) + "%";
        }
        public void cantidadMaximaEnColaVtaEntrada()
        {
            var maxColaVta = dataGridView1.Rows.Cast<DataGridViewRow>()
                          .Max(r => Convert.ToInt32(r.Cells["cola_de_ventas"].Value));
            txt_cola_vta_max.Text = maxColaVta.ToString();

        }

        public void porcentajePersonaConEntradaNoPuedaEntrar() {
            txt_personace_no_entra.Text= proxNum.TruncateFunction(((double)colaDeLaSala / (double)capacidadCine)*100,2).ToString()+"%";
        }
        public void personasEnColaPorEntrar(int personasPorEntrar)
        {
            personas_en_cola_por_entrar.Text = personasPorEntrar.ToString();
        }
        public void descEnPorcentajeOtorgadoEntAnt() {
            txt_desc_total_otorgado.Text = proxNum.TruncateFunction((double)clienteConAnticipada / capacidadCine*100, 2).ToString()+"%" ;
        }
        public void cantidadEntradaVendiasEnCine() {
            txt_cant_entrada_vend_en_cine.Text = cantidadEntradaVendidas.ToString();
        }
        private void minuto_llegada_Ce_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_pr_se_llena_cine_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cola_vta_max_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
