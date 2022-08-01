using System;

namespace YoutubeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManger projectManger = new ProjectManger();
            //IPersonManager customerManager = new CustomerManager();
            //IPersonManager employeeManager = new EmployeeManager();
            projectManger.BaseAdd(new InternManager());
        }
    }
}