using BillManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Services
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetUserById(int userId);
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void UpdateUser(User user);
        [OperationContract]
        void DeleteUser(int userId);
        [OperationContract]
        List<Bill> GetAllBill(int userId);
    }
}
