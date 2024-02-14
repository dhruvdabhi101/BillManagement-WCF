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
    public interface IBillService
    {
        [OperationContract]
        List<Bill> GetBillById(int billId);
        [OperationContract]
        void addBill(Bill bill);
        [OperationContract]
        void DeleteBill(int billId);

    }
}
