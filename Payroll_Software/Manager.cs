using System;
namespace Payroll_Software
{
    public class Manager : Staff
    {
        private const float ManagerHourlyRate = 50;
        public int Allowance { get; private set; }
        public Manager(string name) :base(name, ManagerHourlyRate)
        {
        }
        public override void CalculatePay()
        {
            base.CalculatePay();
            this.Allowance = 1000;
            if (this.TotalHoursWorked > 160)
            {
                this.TotalPay = this.TotalPay + this.Allowance;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
