using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class ProductoTests
    {
        [TestMethod]
        public void TestProductoProperties()
        {
            var producto = new Producto { Id = 1, Nombre = "Producto 1", Precio = 10.0m };
            Assert.AreEqual(1, producto.Id);
            Assert.AreEqual("Producto 1", producto.Nombre);
            Assert.AreEqual(10.0m, producto.Precio);
        }
    }
}