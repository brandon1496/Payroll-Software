using System;
namespace Payroll_Software
{
    public class Staff
    {
        private float HourlyRate;
        private int HoursWorked;
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int TotalHoursWorked{
            get {
                return this.HoursWorked;
            }
            set {
                if (value > 0 ){
                    this.HoursWorked = value; 
                }
                else {
                    this.HoursWorked = 0;
                }
            }
        }
        public Staff(string name, float rate)
        {
            this.NameOfStaff = name;
            this.HourlyRate = rate;
        }
        public virtual void CalculatePay(){
            Console.WriteLine("Calculating.........");
            this.BasicPay = this.HourlyRate * this.HoursWorked;
            this.TotalPay = this.BasicPay;
        }
        public override string ToString()
        {
            return "Name of staff: " + this.NameOfStaff + "\n" + "Hourly Rate: " +
                                           this.HourlyRate + "\n" + "Basic Rate: " +
                                           this.BasicPay + "\n" + "Total Pay: " + this.TotalPay;
        }

    }
}
