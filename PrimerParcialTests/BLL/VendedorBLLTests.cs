using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class VendedorBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Vendedor vendedor = new Vendedor()
            {
                vendedorID = 1,
                Nombres = "Vendedor 1",
                Sueldo = 10000,
                RetencionPorcentaje = 10,
                RetencionCalculo = "1000"
            };
            paso = VendedorBLL.Guardar(vendedor);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Vendedor vendedor = new Vendedor()
            {
                vendedorID = 1,
                Nombres = "Vendedor 10",
                Sueldo = 10000,
                RetencionPorcentaje = 10,
                RetencionCalculo = "1000"
            };
            paso = VendedorBLL.Modificar(vendedor);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = VendedorBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Vendedor vendedor = VendedorBLL.Buscar(1);
            Assert.AreEqual(vendedor, vendedor);
        }
    }
}