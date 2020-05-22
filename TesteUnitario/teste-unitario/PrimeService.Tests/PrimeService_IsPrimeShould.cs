using Xunit;
using PrimeService;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {        
        private readonly PrimeService _primeService;  
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        //[Fact]//declara que o metodo será rodado pelo test runner
        [Theory]//representa um conjunto de teste a ser executado com o mesmo codigo alternando, porém, as entradas.
        [InlineData(0)]//especificando as entradas que serao usadas
        [InlineData(-1)]
        [InlineData(1)]
        public void IsPrime_InputLassThan2_ReturnFalse(int value)
        {           
            var result = _primeService.IsPrime(value);//verifica se 1 eh primo
            Assert.False(result,$"{value} should not be prime");//nao deveria ser
        }  

        //realizando o teste para os primos menores que 10
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
         public void IsPrime_SomeInputs_ReturnTrue(int value)
        {           
            var result = _primeService.IsPrime(value);//verifica se 1 eh primo
            Assert.True(result,$"{value} should be prime");//nao deveria ser
        }  

        //testando numeros abaixo de 10 que nao sao primos
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void IsPrime_SomeInputsLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result,$"{value} should not be prime");
        }
    }
}
