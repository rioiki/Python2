using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO
{
    public class Usuario
    {
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public string CalificacionCredito { get; set; }
        public int PuntajeCredito { get; set; }
    }

    public class CapacidadFinanciera
    {
        public static bool CalcularCapacidad(Usuario cliente, double valorCuota)
        {
            // Calcular la capacidad financiera (ingresos menos egresos)
            double capacidadFinanciera = cliente.Ingresos - cliente.Egresos;


            // Verificar si la capacidad financiera es mayor en un 20% adicional del valor de la cuota
            double porcentajeAdicional = valorCuota * 0.20;
            bool cumpleCapacidad = capacidadFinanciera > (valorCuota + porcentajeAdicional);

            // Verificar que la calificación de crédito sea A y el puntaje obtenido sea mayor a 250
            bool cumpleCalificacion = cliente.CalificacionCredito == "A" && cliente.PuntajeCredito > 250;

            // Devolver true si se cumplen ambas condiciones
            return cumpleCapacidad && cumpleCalificacion;
        }
    }
}
