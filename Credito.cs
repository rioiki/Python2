using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO
{
    internal class Credito
    {
        private double valorCredito;
        private double tasaInteres;
        private int plazoMeses;

        public Credito(double valorCredito, double tasaInteres, int plazoMeses)
        {
            this.valorCredito = valorCredito;
            this.tasaInteres = tasaInteres;
            this.plazoMeses = plazoMeses;
        }

        public double CalcularCredito()
        {
            // Calcular el valor por capital
            double valorPorCapital = valorCredito / plazoMeses;

            // Calcular el valor por intereses
            double valorPorIntereses = valorCredito * (tasaInteres / 100);

            // Calcular el valor de la cuota
            double valorCuota = valorPorCapital + valorPorIntereses;

            return valorCuota;
        }
    }
}

