
using System;

public class HourlyEmployee : Employee
{
    private decimal pay;
    private decimal hours;


    public HourlyEmployee(string first, string last, string ssn,
       decimal hourlyPay, decimal hoursWorked)
        : base(first, last, ssn)
    {
        Payment = hourlyPay;
        Hours = hoursWorked;
    }

    public decimal Payment
    {
        get
        {
            return pay;
        }
        set
        {
            if (value >= 0)
                pay = value;
            else
                throw new Exception("The earnings must bee >=0");
        }
    }
    public decimal Hours
    {
        get
        {
            return hours;
        }
        set
        {
            if (value >= 0 && value <= 168)
                hours = value;
            else
                throw new Exception("The earnings must bee >=0 and <= 168");
        }
    }

    public override string ToString()
    {
        return string.Format(
              "hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2},",
              base.ToString(), "hourly payment", Payment, "hours worked", Hours);
    }

    public override decimal Earnings()
    {
        if (Hours < 40)
            return Payment * Hours;
        else
            return (40 * Payment) + ((Hours - 40) * Payment * 1.5M);
    }
}

           



