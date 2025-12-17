using System;

delegate double BillingStrategy(double amount);

class Patient
{
    public string Name;
    public string Type;
    public double TreatmentCost;

    public Patient(string name, string type, double cost)
    {
        Name = name;
        Type = type;
        TreatmentCost = cost;
    }
}

class Billing
{
    public BillingStrategy ApplyBilling;

    public double GenerateBill(double amount)
    {
        return ApplyBilling(amount);
    }
}

class Hospital
{
    public event Action<string> Notify;

    public void AdmitPatient(Patient patient)
    {
        Notify?.Invoke("Patient admitted: " + patient.Name);
    }

    public void GenerateFinalBill(Patient patient, double bill)
    {
        Notify?.Invoke("Final bill generated for " + patient.Name + " : Rs " + bill);
    }
}

class Program
{
    static double GeneralBilling(double amount)
    {
        return amount;
    }

    static double InsuranceBilling(double amount)
    {
        return amount * 0.7;
    }

    static double EmergencyBilling(double amount)
    {
        return amount * 1.5;
    }

    static void DepartmentNotification(string message)
    {
        Console.WriteLine("Notification: " + message);
    }

    static void Main()
    {
        Hospital hospital = new Hospital();
        hospital.Notify += DepartmentNotification;

        Console.Write("Enter patient name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select patient type");
        Console.WriteLine("1. O.P.D");
        Console.WriteLine("2. I.C.C.U");
        Console.WriteLine("3. Emergency");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter treatment cost: ");
        double cost = Convert.ToDouble(Console.ReadLine());

        string type = "";
        Billing billing = new Billing();

        if (choice == 1)
        {
            type = "General";
            billing.ApplyBilling = GeneralBilling;
        }
        else if (choice == 2)
        {
            type = "Insurance";
            billing.ApplyBilling = InsuranceBilling;
        }
        else
        {
            type = "Emergency";
            billing.ApplyBilling = EmergencyBilling;
        }

        Patient patient = new Patient(name, type, cost);

        hospital.AdmitPatient(patient);

        double finalBill = billing.GenerateBill(patient.TreatmentCost);

        Console.WriteLine("Patient Type: " + patient.Type);
        Console.WriteLine("Total Bill: Rs " + finalBill);

        hospital.GenerateFinalBill(patient, finalBill);
    }
}
