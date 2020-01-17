// BasePlusCommissionEmployee.cs
// BasePlusCommissionEmployee class that extends CommissionEmployee.
public class PayrollTest
{
    public static void Main(string[] args)
    {
        SalariedEmployee salariedEmployee =
            new SalariedEmployee("Daniel", "Oszczapinski", "123-12-1234", 200M);
        HourlyEmployee hourlyEmployee =
            new HourlyEmployee("Stan", "live", "000-00-0000", 10M, 13M);
        CommissionEmployee commissionEmployee =
            new CommissionEmployee("lane", "peter", "112-12-1122", 100M, .1M);
        BaseCommissionEmployee baseCommissionEmployee =
            new BaseCommissionEmployee("Jane", "Dove", "133-33-4433", 20M, .2M, 40M);

        Employee[] employeses = new Employee[4];

        Employee[0] = salariedEmployee;
        Employee[1] = hourlyEmployee;
        Employee[2] = commissionEmployee;
        Employee[3] = baseCommissionEmployee;

    }
}