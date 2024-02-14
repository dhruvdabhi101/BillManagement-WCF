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
    public interface IItemService
    {
        [OperationContract]
        Item GetItemById(int itemId);
        [OperationContract]
        List<Item> GetAllItems();
        [OperationContract]
        void AddItem(Item item);
        [OperationContract]
        void UpdateItem(Item item);
        [OperationContract]
        void DeleteItem(int itemId);
    }
}
