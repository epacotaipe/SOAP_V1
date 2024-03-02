using dodo.Models;
using System.ServiceModel;

namespace dodo.Services
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(Calculadora calculadora);
    }
}
