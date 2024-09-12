class CompanyData
{
    static void Main()
    {
        Console.Write("Please Enter Company Name: ");
        String company = Console.ReadLine();

        Console.Write("Please Enter Company Adress: ");
        String address = Console.ReadLine();

        Console.Write("Please Enter the Phone Number: ");
        int phoneNumber = int.Parse(Console.ReadLine());

        Console.Write("Please Enter the Fax Number: ");
        int faxNumber = int.Parse(Console.ReadLine());

        Console.Write("Please Enter the Company's Webiste: ");
        String website = Console.ReadLine();

        Console.Write("Please Enter the Manager's First name: ");
        String managerFName = Console.ReadLine();

        Console.Write("Please Enter the Manager's Last name: ");
        String managerLName = Console.ReadLine();

        Console.Write("Please Enter the Manager Phone Number: ");
        int mgrPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The Company Details are: " + "\n " + "Company Name: " + company + "\n " + "Address: " + address + "\n " + "Phone Number:" + phoneNumber + "\n " + "Fax Number: " + faxNumber + "\n " + "Website: "+ website);
        Console.WriteLine("The Manger's Details are: " + "\n " + "Manager First Name: " + managerFName + "\n " + "Manager Last Name: " + managerLName + "\n " + "Manager Phone Number: "+ mgrPhoneNumber);


    }
}