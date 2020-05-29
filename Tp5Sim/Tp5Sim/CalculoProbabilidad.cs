﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5Sim
{
    public class CalculoProbabilidad
    {
        double maxSinEntrada = 0;
        double minSinEntrada = 0;
        double maxVenta = 0;
        double minVenta = 0;
        double maxConEentrada = 0;
        double minConEntrada = 0;
        double maxEntradaSala = 0;
        double minEntradaSala = 0;

        Random rnd = new Random();


        int nro1 = 1;
        int nro2 = 2;
        int nro3 = 3;
        int nro4 = 4;


        public CalculoProbabilidad (double maxSE, double minSE, double maxVenta, double minVenta, double maxCE, double minCE, double maxEntradaSala, double minEntradaSala)
        {
            this.maxSinEntrada = maxSE;
            this.minSinEntrada = minSE;
            this.maxVenta = maxVenta;
            this.minVenta = minVenta;
            this.maxConEentrada = maxCE;
            this.minConEntrada = minCE;
            this.maxEntradaSala = maxEntradaSala;
            this.minEntradaSala = minEntradaSala;
               
        }

        public double calcularProbabilidadClienteSinEntrada()
        {
            var nuevoRnd = rnd.NextDouble();

            return minSinEntrada + (nuevoRnd * (maxSinEntrada - minSinEntrada)); 

        }

        public double calcularProbabilidadClienteConEntrada()
        {
            var nuevoRnd = rnd.NextDouble();

            return minConEntrada + (nuevoRnd * (maxConEentrada - minConEntrada));

        }

        public double calcularProbabilidadVentaDeEntrada()
        {
            var nuevoRnd = rnd.NextDouble();

            return minVenta + (nuevoRnd * (maxVenta - minVenta));

        }

        public double calcularProbabilidadEntradaASala()
        {
            var nuevoRnd = rnd.NextDouble();

            return minEntradaSala + (nuevoRnd * (maxEntradaSala - minEntradaSala));

        }

        public int entradaQueCompraClienteSinEntrada()
        {
            var nuevoRnd = rnd.NextDouble();
         
            if (nuevoRnd < 0.25) return nro1;
            if (nuevoRnd < 0.50) return nro2;
            if (nuevoRnd < 0.75) return nro3;
            return nro4;
            
        }

        public int personasQueLleganConEntradas()
        {
            var nuevoRnd = rnd.NextDouble();

            if (nuevoRnd < 0.33) return nro1;
            if (nuevoRnd < 0.66) return nro2;
            return nro3;
        }

    }
}
