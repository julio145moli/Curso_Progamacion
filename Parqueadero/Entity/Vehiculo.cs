using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entity
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string TipoVehiculo { get; set; }


        public override string ToString()
        {
            return $"{Placa};{Modelo};{TipoVehiculo};";
        }
    }

    
}