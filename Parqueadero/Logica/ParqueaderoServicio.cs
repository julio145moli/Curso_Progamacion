using Datos;
using Entity;

namespace Logica
{
    public class ParqueaderoServicio
    {

        RepositorioParqueadero repositorio = new RepositorioParqueadero();

        public string Guardar(Vehiculo vehiculo, Parqueadero parqueadero, Persona persona)
        {
            try
            {
                if (vehiculo == null)
                {
                    return "\nNo se pudo guardar vehiculo\n";
                }
                else
                {
                    repositorio.Agregar(vehiculo,parqueadero,persona);
                    return "\nEl vehiculo " + vehiculo.Placa + " fue guardado\n";
                }
            }
            catch (Exception e)
            {
                return "\nError " + e + "\n";
            }
        }
    }
}