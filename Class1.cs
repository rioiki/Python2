using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO
{

    internal class Cliente
    {
        // Definir las Variables

        public string nombre;
        public string tipo_documento;
        public string documento;
        public string edad;
        public string razón_social;
        public string estado_civil;
        public string estrato;
        public string ocupación;
        public string tipo_contrato;
        public string antigüedad_laboral;
        public string tipo_vivienda;
        public string nivelEducativo;
        public string personaAcargo;
        public string productoSolicitado;
        public double ingresos;
        public double egresos;
        public string calificacionCentralesRiesgo;



        //Hacemos el Get y Set

        public string Calificacion_CentralesRiesgo { get; set; }
        public double Egresos { get; set; }
        public double Ingresos { get; set; }
        public string Producto_Solicitado { get; set; }
        public string Perona_Cargo { get; set; }
        public string Nivel_Educativio { get; set; }
        public string Tipo_Documento { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Razón_Social { get; set; }
        public string Estado_Social { get; set; }
        public int Estrato { get; set; }
        public string Ocupación { get; set; }
        public string Tipo_Contrato { get; set; }
        public string Antiguedad { get; set; }
        public string Tipo_Vivienda { get; set; }
    }
}

