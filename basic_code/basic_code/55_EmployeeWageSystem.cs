/*
 * Program: Employee Wage Computation (UC1–UC14)
 * 
 * Concepts:
 * - OOP (Class, Object)
 * - Interface (Abstraction)
 * - List & Dictionary (Collection)
 * - Random Simulation
 */

using System;
using System.Collections.Generic;

namespace basic_code
{
    // Interface
    internal interface IEmployeeWage
    {
        void AddCompany(string name, int ratePerHour, int maxDays, int maxHours);
        void ComputeWages();
        int GetTotalWage(string company);
    }

    // Company class
    internal class CompanyEmpWage
    {
        public string CompanyName;
        public int RatePerHour;
        public int MaxDays;
        public int MaxHours;
        public int TotalWage;

        public CompanyEmpWage(string name, int rate, int days, int hours)
        {
            CompanyName = name;
            RatePerHour = rate;
            MaxDays = days;
            MaxHours = hours;
        }
    }

    // Implementation
    internal class EmployeeWageBuilder : IEmployeeWage
    {
        private List<CompanyEmpWage> companies = new List<CompanyEmpWage>();
        private Dictionary<string, CompanyEmpWage> map = new Dictionary<string, CompanyEmpWage>();

        public void AddCompany(string name, int ratePerHour, int maxDays, int maxHours)
        {
            CompanyEmpWage company = new CompanyEmpWage(name, ratePerHour, maxDays, maxHours);
            companies.Add(company);
            map[name] = company;
        }

        public void ComputeWages()
        {
            foreach (var company in companies)
            {
                company.TotalWage = ComputeCompanyWage(company);
                Console.WriteLine($"Total Wage for {company.CompanyName}: {company.TotalWage}");
            }
        }

        private int ComputeCompanyWage(CompanyEmpWage company)
        {
            int totalHours = 0;
            int totalDays = 0;

            Random rand = new Random();

            while (totalHours < company.MaxHours && totalDays < company.MaxDays)
            {
                totalDays++;

                int empCheck = rand.Next(0, 3);
                int empHours = 0;

                switch (empCheck)
                {
                    case 1: empHours = 4; break; // Part-time
                    case 2: empHours = 8; break; // Full-time
                    default: empHours = 0; break;
                }

                totalHours += empHours;

                Console.WriteLine($"Day {totalDays} → Hours: {empHours}");
            }

            return totalHours * company.RatePerHour;
        }

        public int GetTotalWage(string company)
        {
            return map.ContainsKey(company) ? map[company].TotalWage : 0;
        }
    }
}
