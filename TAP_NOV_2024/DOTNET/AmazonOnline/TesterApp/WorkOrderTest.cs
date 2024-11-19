using System;
using System.Collections.Generic;


namespace OrderProcessing
{
    class WorkOrderTest
    {
        public static void Main(string [] args)
        {
            DateTime orderDate = DateTime.Now;

            Job job1 = new Job { ID = 1, Title = "Collect Parcel from Amazon Stores", 
                                Description = "Collect all todays parcel to be delivered from Mumbai warehouse", 
                                Duration = 3, 
                                Status = "Not started" };
            Job job2 = new Job { ID = 2, Title = "Deliver Parcel to Customers", 
                                Description = "All Parcels collected to be delivered to mentioned locations", 
                                Duration = 4, 
                                Status = "Not started" };
            Job job3 = new Job { ID = 3, Title = "Report the status of Delivery", 
                                Description = "Collect all todays parcels to be delivered from Mumbai warehouse", 
                                Duration = 3, 
                                Status = "Not started" };
            Job job4 = new Job { ID = 4, Title = "Update WordOrder status", 
                                Description = "Access Online Amazon system to update status of delivery of product", 
                                Duration = 3, 
                                Status = "Not started"};

            List<Job> jobs = new List<Job>();
            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);

            Order theOrder = new WorkOrder
            {
                OrderID = 1001,
                Vendor = "DHL Group",
                Description = "Parcel Delivery to Amazon Customers",
                OrderDate = DateTime.Now,
                StartDate = new DateTime(2024, 11, 15),
                EndDate = new DateTime(2024, 11, 16),     
                Jobs = jobs,
                Priority = 4,
                Status = "Not Started"
            };

            IOrderService service = new WorkOrderService();
            service.Create(theOrder);

            List<Order> allOrders = service.GetOrders();

            Console.WriteLine("WorkOrder Details ");
            Console.WriteLine("---------------------------");

            foreach (WorkOrder order in allOrders)
            {
                Console.WriteLine("Vendor : {0}", order.Vendor);
                Console.WriteLine("Order Date : {0}", order.OrderDate);
                Console.WriteLine("Start Date : {0}", order.StartDate);
                Console.WriteLine("End Date : {0}", order.EndDate);
                Console.WriteLine("Status : {0}", order.Status);

                Console.WriteLine("Job Description");

                foreach(Job job in order.Jobs)
                {
                    Console.WriteLine(job.ID + " " + job.Title + " " + job.Status);
                }
            }
            Console.ReadLine();
        } 
    }
}
