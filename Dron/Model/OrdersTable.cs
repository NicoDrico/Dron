using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.Model
{
    internal class OrdersTable
    {
        public int Id { get; set; }
        public int? UsersId { get; set; }
        public string Status { get; set; }
        public int? WorkerId { get; set; }
        public int? CreatedAt { get; set; }
        public string UserName { get; set; }
        public string WorkerName { get; set; }


        public static OrdersTable ConvertOrdersOnOrdersTable(Orders orders)
        {
            OrdersTable ordersTable = new OrdersTable();
            ordersTable.Id = orders.Id;
            ordersTable.UsersId = orders.UsersId;
            ordersTable.Status = orders.Status;
            ordersTable.WorkerId = orders.WorkerId;
            ordersTable.CreatedAt = orders.CreatedAt;


            using (ApplicationContext db = new ApplicationContext())
            {
                Workers workers = DataWorker.SelectAllWorkers().FirstOrDefault(o => o.Id == orders.WorkerId);
                ordersTable.WorkerName = $"{workers.Name} {workers.FatherName} {workers.LastName}";
                ordersTable.UserName = DataWorker.SelectAllClient().FirstOrDefault(j => j.IdClient == orders.UsersId).Name;
            }

            return ordersTable;
        }
    }
}
