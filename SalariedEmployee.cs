using System;

public class SalariedEmployee : Employee
{
    private decimal salaryWeekly;

    public SalariedEmployee(string first, string last, string ssn,
      decimal salary)
        : base(first, last, ssn)
    {
        salaryWeekly = salary;
    }

    public decimal SalaryWeekly
    {
        get
        {
            return salaryWeekly;
        }
        set
        {
            if (value >= 0)
                salaryWeekly = value;
            else
                throw new Exception("The weekly salary must bee >=0");
        }
    }
    public override string ToString()
    {
        return string.Format("Employee salary : {0}\n{1}: {2:c}",
        base.ToString(), "Weekly salary", SalaryWeekly);
    }
    public override decimal Earnings()
    {
        return SalaryWeekly;

    }

}
            
            