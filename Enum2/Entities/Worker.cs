using Enum2.Entities.Enums;


namespace Enum2.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract); 
        }

        public double Income(int year, int mouth)
        {
            double sum = BaseSalary;
            foreach (HoursContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
