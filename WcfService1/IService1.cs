using System.ServiceModel;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int c2f(int celsius);

        [OperationContract]
        int f2c(int fahrenheit);

        [OperationContract]
        string sort(string commaSeparatedNumbers);
    }
}
