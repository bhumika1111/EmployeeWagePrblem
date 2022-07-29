using System;

namespace EmployeeWage
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(":::::Welcome To EmployeeWage Program::::::");
            Console.WriteLine("**Output for Employee Is Present Or Absent**");
            EmployeeCheck.CheckEmployeeAttendance();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output for Employee Daily Wage**");
            EmpWageDaily.CheckEmpAttendanceFullTime();
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output For Employee Is Full Time Or Part Time**");
            EmpWagePartTime.CheckEmployeePartTime();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output For Employee Wage Using Switch Case**");
            SwitchCase.CheckEmpAttendance();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output For Employee Wage For Month**");
            EmpWageMonth.CheckEmpWageForMonth();
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output For Total Employee Wage In Month**");
            EmpWageHrsInMonth.CheckEmpWageHrsOrDayInMonth();
        }
    }
}
