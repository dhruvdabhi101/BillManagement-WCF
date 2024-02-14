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
    public interface IBilledItemsService
    {
        [OperationContract]
        List<BilledItems> GetBilledItemsByBill(int billId);
        [OperationContract]
        void AddBilledItem(BilledItems item);
        [OperationContract]
        void DeleteBilledItem(int id);
    }
}
