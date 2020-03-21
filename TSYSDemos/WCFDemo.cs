using System;
using System.ServiceModel;

namespace TSYSDemos {
    class WCFDemo {
    }
    [ServiceContract]
    public interface IRegisterationService {
        [OperationContract]
        [FaultContract(typeof(string))]
        void Register(string email);
    }

    public class RegisterationService : IRegisterationService {
        public void Register(string email) {

            try {

            } catch (Exception ex) {

                throw new FaultException(ex.Message);
            }
        }
    }
}

