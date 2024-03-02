using System.Runtime.Serialization;
using System.ServiceModel;

namespace dodo.Models
{
    [ServiceContract]
    public class Calculadora
    {
        [DataMember]
        public int num1 { get; set; }
        [DataMember]
        public int num2 { get; set; }
        [DataMember]
        public int num3 { get; set; }

    }
}
