using System;
namespace Payroll_Software
{
    public class Admin : Staff
    {
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;
        public float OverTime { get; private set; }  
        public Admin(string name) :base(name, adminHourlyRate)
        {
        }
        public override void CalculatePay()
        {
            base.CalculatePay();

            if (this.TotalHoursWorked > 160)
            {
                this.OverTime = overtimeRate * (TotalHoursWorked - 160);
                this.TotalPay = this.TotalPay + this.OverTime;
            }
        }
    }
}
