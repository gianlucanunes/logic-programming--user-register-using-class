/*
 * 
 * 
 *      Activity using the class concept: user register
 * 
 * 
 */


List<Users> info = new List<Users>();

string optBeg = "Y";


Console.WriteLine("\n----------------------\n|    User Register   |\n----------------------\n");

// While loop to register more than one user
while (optBeg == "Y")
{

// Asking the user to type the info
    _reg:
    Users obj = new Users();
    Console.Write("\nPlease, enter with the info below.\n");
    Console.Write("Name: ");
    obj.name = Console.ReadLine();

    Console.Write("Last Name: ");
    obj.lastname = Console.ReadLine();

    _age:
    Console.Write("Age: ");

    int ag;
    if (int.TryParse(Console.ReadLine(), out ag))
        obj.age = ag;
    else
    {
        Console.WriteLine("\nIncorrect value! Please, try filling it again.\n");
        goto _age;
    }

    _pass:
    Console.Write("Password (6 digits): ");
    obj.password = Console.ReadLine();

    if (obj.password.Length != 6)
    {
        Console.WriteLine("\nThe password you typed does not have 6 digits! Please, try filling it again.\n");
        goto _pass;
    }




    // If everything is alright, add the complete object (name, last name, age, password) to the list called info.
    info.Add(obj);
    Console.WriteLine("\nUser registered successfully!\n");


    // Asks the user if he wants to create a new register. If so, he goes to the beggining, creating a new user type object.
    _addReg:
    Console.WriteLine("\nDo you want to register another user?\n[Y] Yes\n[N] No\n");
    string opc = Console.ReadLine().ToUpper();

    if (opc != "Y" && opc != "N")
    {
        Console.WriteLine("\nERROR: You have selected an incorrect option! Please, try it again.\n");
        goto _addReg;
    }

    else if (opc == "Y")
        goto _reg;

    else
    {
        optBeg = "N";

        // Calculates the total of registers.
        int regTotal = info.Count();

        Console.WriteLine($"\nThe collection has a total of {regTotal} registers.\n");


        // Asks the user if he wants the program to display the info from each register.
        _regList:
        Console.WriteLine("\nDo you want to display the info?\n[Y] Yes \n[N] No");
        string listOpt = Console.ReadLine().ToUpper();

        if (listOpt != "Y" && listOpt != "N")
        {
            Console.WriteLine("\nERROR: You have selected an incorrect option! Please, try it again.");
            goto _regList;
        }

        else if (listOpt == "Y")
        {
            foreach (var item in info)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }

        break;
    }

}

Console.WriteLine("\nPress space to end...");
Console.ReadKey();







