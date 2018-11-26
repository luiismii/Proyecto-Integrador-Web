using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Proyecto.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Logica.BL.ClsUsuarios clsUsuarios = new Logica.BL.ClsUsuarios();
            Logica.BL.ClsClientes clsClientes = new Logica.BL.ClsClientes();

            Logica.Modelos.ClsUsuarios obClsUsuarios = new Logica.Modelos.ClsUsuarios
            {
                stLogin = "dsantafe@gmail.com",
                stPassword = "123456",
                stImagen = "",
                ClsPerfiles = new Logica.Modelos.ClsPerfiles
                {
                    inId = 2
                }
            };

            Logica.Modelos.ClsPosiblesClientes obClsPosiblesClientes = new Logica.Modelos.ClsPosiblesClientes
            {
                inId_Cliente = 1144198881,
                stPrimerNombre = "David",
                stSegundoNombre = "",
                stPrimerApellido = "Santafe",
                stSegundoApellido = "Zorrilla",
                stDireccion = "",
                stTelefono = "55555",
                stCorreo = "dsantafe@gmail.com",
                stFecha_Nacimiento = "1996"
            };

            //Assert
            Assert.AreEqual("Se Realizo el Proceso Con Exito", clsUsuarios.CreateUsuario(obClsUsuarios, obClsPosiblesClientes));
        }
    }
}
