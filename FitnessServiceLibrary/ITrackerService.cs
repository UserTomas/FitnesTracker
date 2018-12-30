using System.ServiceModel;

namespace FitnessService.Library
{
    [ServiceContract]
    public interface ITrackerService
    {
        [OperationContract]
        string SendMessage(string message);

        [OperationContract(IsInitiating = true)]
        bool ConnectUser(string userName, string password);
    }
}
