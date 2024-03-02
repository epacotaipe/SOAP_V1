using dodo.Models;
using dodo.Services;

namespace dodo.Controllers
{

    public class SoapService : ISoapService
    {
        public string Sum(Calculadora calculadora)
        {
            return Convert.ToString(calculadora.num1+calculadora.num2 + calculadora.num3);
        }
    }
}
