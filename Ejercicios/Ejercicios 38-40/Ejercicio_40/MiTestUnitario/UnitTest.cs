using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTestUnitario
{
    [TestClass]
    public class UnitTest
    {
        /*Crear un test unitario que valide que la lista de llamadas de la centralita 
            esté instanciada al crear un nuevo objeto del tipo Centralita.*/
        [TestMethod]
        public void ValidarListaDeLlamadas()
        {
            // arrange
            Centralita lista = new Centralita();
            // Act

            // Assert
            Assert.IsNotNull(lista.Llamadas);
        }

        /*Controlar mediante un nuevo método de test unitario que la excepción 
        CentralitaExcepcion se lance al intentar cargar una segunda llamada con 
        solamente los mismos datos de origen y destino de una llamada Local ya existente.*/
        [TestMethod]
        public void ValidarLlamadas_MismoOrigenYDestino()
        {
            // arrange
            
            // Act

            // Assert
        }

    }
}
