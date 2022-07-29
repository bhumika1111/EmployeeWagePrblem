﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    /// <summary>
    /// Check The Employee Is Working For Full Time ,Then They Will be Geeting Complete Sallary For That Day.
    /// <summary>
    public static class EmpWageDaily
    {
        /// <summary>
        /// Checks the employee attendance1.
        /// </summary>
        public static void CheckEmpAttendanceFullTime()
        {
            //Constant
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();

            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;
            }
            else 
            {
                Console.WriteLine("Employee Is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: "  + empWage);

        }

    }
}
