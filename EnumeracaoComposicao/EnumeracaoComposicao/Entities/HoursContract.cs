using System;


namespace EnumeracaoComposicao.Entities
{
    class HoursContract
    {
        public DateTime Date { get; set; }

        public Double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HoursContract()
        {
        }

        public HoursContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
