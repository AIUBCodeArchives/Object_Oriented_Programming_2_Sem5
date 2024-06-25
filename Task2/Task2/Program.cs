using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public enum DaysOfWeek 
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum OrderStatus 
    {
        Pending,
        Processing,
        Shipped,
        Delivered
    }
    public enum LogLevel
    {
        Info, 
        Warning,
        Error = 404,
        Critical
    }

    public class Schedule 
    {
        public DayOfWeek MeetingDay { get; set; }

        public void PrintMeetingDay ()
        {
            Console.WriteLine($"Meeting Day is set on {MeetingDay}");
        }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }

        public void PrintStatus ()
        {
            switch (Status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine($"Order No. {OrderId} is pending");
                    break;
                case OrderStatus.Processing:
                    Console.WriteLine($"Order No. {OrderId} is processing");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine($"Order No. {OrderId} is Shipped");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine($"Order No. {OrderId} is Delivered");
                    break;
                default:
                    Console.WriteLine("Error, please try again");
                    break;
            }
        }
    }
    
    public class Logger
    {
        public void Logging(LogLevel level, string message)
        {
            Console.WriteLine($"At level-{level}, Message - \"{message}\" ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum - DaysOfWeek");
            //printing meeting day
            Schedule schedule = new Schedule();
            schedule.MeetingDay = DayOfWeek.Monday;
            schedule.PrintMeetingDay();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enum - OrderStatus");
            //printing order 
            Order order = new Order();
            order.OrderId = 101;
            order.Status = OrderStatus.Pending;
            order.PrintStatus();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enum - Logger");
            //printing Logger
            Logger logger = new Logger();
            logger.Logging(LogLevel.Info, "ehehhe - Info");
            logger.Logging(LogLevel.Warning, "Hello - Warning");
            logger.Logging(LogLevel.Error, $"Hello - {(int)LogLevel.Error}");
            logger.Logging(LogLevel.Critical, "Rakin - Critical");

            Console.ReadLine();
        }
    }
}
