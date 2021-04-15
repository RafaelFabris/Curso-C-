using System;
using System.Collections.Generic;
using EnumeracaoComposicao.Entities.Enums;

namespace EnumeracaoComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year , int month)
        {
            double sum = BaseSalary;
            foreach (HoursContract contracts in Contracts)
            {
                if(contracts.Date.Year == year && contracts.Date.Month == month)
                {
                    sum += contracts.TotalValue();
                }
            }

            return sum;
        }
    }
}
