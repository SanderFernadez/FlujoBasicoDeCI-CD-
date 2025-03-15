

namespace Maquina_Cafe.MaquinaCafe
{

    public class MaquinaCafe
    {
        private static readonly HashSet<string> TamanosValidos = new() { "Pequeño", "Mediano", "Grande" };

        /// <summary>
        /// Selecciona un tamaño de vaso si hay disponibilidad.
        /// </summary>
        public string SeleccionarVaso(string tamano, bool tieneVasos)
        {
            if (!TamanosValidos.Contains(tamano))
                return "Error: Tamaño no válido";

            if (!tieneVasos)
                return "Error: No hay vasos disponibles";

            return $"Vaso {tamano} seleccionado";
        }

        /// <summary>
        /// Selecciona la cantidad de azúcar si hay disponibilidad.
        /// </summary>
        public string SeleccionarAzucar(int cucharadas, bool tieneAzucar)
        {
            if (cucharadas < 0 || cucharadas > 5)
                return "Cantidad de azúcar no válida";

            if (!tieneAzucar)
                return "Error: No hay azúcar disponible";

            return $"{cucharadas} cucharadas de azúcar agregadas";
        }

        /// <summary>
        /// Sirve café si hay café disponible y un vaso válido seleccionado.
        /// </summary>
        public string ServirCafe(string tamano, int cucharadas, bool tieneCafe)
        {
            if (!TamanosValidos.Contains(tamano))
                return "Error: Debe seleccionar un vaso antes de servir el café";

            if (!tieneCafe)
                return "Error: No hay café disponible";

            return $"Sirviendo café en un vaso {tamano} con {cucharadas} cucharadas de azúcar";
        }
    }

}
