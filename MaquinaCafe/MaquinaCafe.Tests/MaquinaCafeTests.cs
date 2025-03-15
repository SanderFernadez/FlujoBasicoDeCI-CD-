using MaquinaCafe.MaquinaCafe;
using Xunit;

namespace MaquinaCafe.MaquinaCafe.Tests
{
    public class MaquinaCafeTests
    {
        private readonly Maquina_Cafe.MaquinaCafe.MaquinaCafe _maquina = new();

        [Fact]
        public void Deberia_Permitir_Seleccionar_Tamano_De_Vaso()
        {
            var resultado = _maquina.SeleccionarVaso("Mediano", true);
            Assert.Equal("Vaso Mediano seleccionado", resultado);
        }

        [Fact]
        public void No_Deberia_Seleccionar_Vaso_Invalido()
        {
            var resultado = _maquina.SeleccionarVaso("Gigante", true);
            Assert.Equal("Error: Tamaño no válido", resultado);
        }

        [Fact]
        public void No_Deberia_Seleccionar_Vaso_Si_No_Hay_Vasos()
        {
            var resultado = _maquina.SeleccionarVaso("Mediano", false);
            Assert.Equal("Error: No hay vasos disponibles", resultado);
        }

        [Fact]
        public void Deberia_Permitir_Seleccionar_Cantidad_De_Azucar()
        {
            var resultado = _maquina.SeleccionarAzucar(2, true);
            Assert.Equal("2 cucharadas de azúcar agregadas", resultado);
        }

        [Fact]
        public void No_Deberia_Seleccionar_Azucar_Invalida()
        {
            var resultado = _maquina.SeleccionarAzucar(-1, true);
            Assert.Equal("Cantidad de azúcar no válida", resultado);
        }

        [Fact]
        public void No_Deberia_Seleccionar_Azucar_Si_No_Hay()
        {
            var resultado = _maquina.SeleccionarAzucar(2, false);
            Assert.Equal("Error: No hay azúcar disponible", resultado);
        }

        [Fact]
        public void No_Deberia_Servir_Cafe_Si_No_Hay_Cafe()
        {
            var resultado = _maquina.ServirCafe("Pequeño", 1, false);
            Assert.Equal("Error: No hay café disponible", resultado);
        }

        [Fact]
        public void Deberia_Servir_Cafe_Correctamente()
        {
            var resultado = _maquina.ServirCafe("Grande", 3, true);
            Assert.Equal("Sirviendo café en un vaso Grande con 3 cucharadas de azúcar", resultado);
        }

        [Fact]
        public void No_Deberia_Servir_Cafe_Sin_Seleccionar_Vaso()
        {
            var resultado = _maquina.ServirCafe("Gigante", 2, true);
            Assert.Equal("Error: Debe seleccionar un vaso antes de servir el café", resultado);
        }

    }
}
