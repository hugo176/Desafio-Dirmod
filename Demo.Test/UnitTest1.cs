using System.Reflection;
using System;
using Xunit;
using Ejercicio_1;

namespace Demo.Test
{
    public class UnitTest1
    {
        private Class1 _service = null;

        public UnitTest1(){
            _service = new Class1();
        }

        [Fact]
        public void Test1()
        {
            String resultado = _service.getCadenaNumerica("este es un test unitario");
            String valorEsperado = "33 7777 8 33 0 33 7777 0 88 66 0 8 33 7777 8 0 88 66 444 8 2 777 444 666";
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void Test2()
        {
            String resultado = _service.getCadenaNumerica("hola");
            String valorEsperado = "44 666 555 2";
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
