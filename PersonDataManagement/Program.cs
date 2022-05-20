using System;
using PersonDataManagement;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("               >>>>>>>>>******** >>> WELCOME IN THE LAMDA EXPRESSION <<< ********<<<<<<<<<");
        PersonManagement person = new PersonManagement();
        bool check = true;
        while (check)
        { 
        Console.WriteLine(" Adding the Data  in The List 1\n Age Less Than 60 Years 2\n Display Average Age 3\n");
            Console.WriteLine("###############Enter the Above option to Excute the Use Cases################");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    person.AddPerson();
                    break;
                case 2:
                    person.GetTopRecords();
                    break;
                case 3:
                    person.AverageAge();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
       
        

    }
}
