namespace P04.Recharge
{
    using System;

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Mila Akexieva");
            Robot robot = new Robot("R500", 80);
            RechargeStation rechargeStation = new RechargeStation();
            rechargeStation.Recharge(robot);

            employee.Work(8);
            robot.Work(24);
            Console.WriteLine(robot.CurrentPower);
        }
    }
}
