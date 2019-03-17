using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;

namespace MofinNegocios
{
    public static class NList_Exportar
    {
        public class Lst_LibroOrdenes
        {
            public string Secuencia { get; set; }
            public string Tipo_Orden { get; set; }
            public string Titulo_Cod { get; set; }
            public string Titulo_Nme { get; set; }
            public string Titulo_ISIN { get; set; }
            public DateTime Fec_Orden { get; set; }
            public DateTime Fec_Venta { get; set; }
            public int Nominal { get; set; }
            public string Precio { get; set; }
            public decimal Valor_Efectivo { get; set; }
            public string Cuenta { get; set; }
            public string Cliente_Cod { get; set; }
            public string Cliente_Nme { get; set; }
            public string Cliente_Email { get; set; }
            public string Cliente_Status { get; set; }
            public string Cliente_Ejecutivo { get; set; }
            public string Aprobado_Por { get; set; }
            public DateTime Aprobado_Fecha { get; set; }
        }
        public class Lst_Clientes
        {
            public string Tipo_Persona { get; set; }
            public string Status { get; set; }
            public string Codigo { get; set; }
            public string Doc_ID { get; set; }
            public DateTime Doc_ID_Fec_Venc { get; set; }
            public string Nombre { get; set; }
            public byte Puntuacion { get; set; }
            public string Pais_Nacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Pais_Residencia { get; set; }
            public string Estado { get; set; }
            public string Edad { get; set; }
            public string Tipo_PersJurid { get; set; }
            public string Tipo_Estructura { get; set; }
            public string PEP { get; set; }
            public string Vol_Operaciones { get; set; }
            public string Criptomonedas { get; set; }
            public string Profesion { get; set; }
            public string Activ_Comercial { get; set; }
            public string Email { get; set; }
            public string Uso_Cuenta { get; set; }
            public string Nivel_Riesgo { get; set; }
            public decimal Perfil_Financiero { get; set; }
            public int Nro_Transacciones { get; set; }
            public string Ejecutivo { get; set; }
            public string Observacion { get; set; }
            public DateTime Fec_Ult_Actualizacion { get; set; }
        }
    }

}
