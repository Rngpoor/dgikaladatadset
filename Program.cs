// Reza Naghipoor




using digikala_project.locker;
using Digikala1.Model;
using Digikala1.Operations;
using Digikala1.Model;
using Digikala1.Operations;








lockkeyboard yn = new lockkeyboard();
string q;
do
{
    string address = @"C:\digikala\orders.csv";

    DigikalaContext context = new DigikalaContext(address);

    DigikalaOperation op = new DigikalaOperation(context.digikalas);

    lockkeyboard lk = new lockkeyboard();


    Console.WriteLine("What do you want? \n " + " order (PRESS O) \n " +
                      " Customer (PRESS C) \n Item" +
                      "\n Date (PRESS d) \n City (PRESS s)");
    string x = lk.menulocker();


    switch (x)
    {
        case "o" or "O":
            Console.WriteLine("Enter id-order");
            int o = lk.keyboardnumberlocker();

            Console.WriteLine(op.priceSalesByorder(o));

            break;

        case "c" or "C":
            Console.WriteLine("Enter Id-customer");
            int c = lk.keyboardnumberlocker();

            Console.WriteLine(op.SumSalesBycustomer(c));

            break;


        case "i" or "I":
            Console.WriteLine("Enter id-item");
            int i = lk.keyboardnumberlocker();

            Console.WriteLine(op.sumSalesByitem(i));

            break;


        case "d" or "D":
            Console.WriteLine("Enter date ");
            int t = lk.keyboardnumberlocker();

            Console.WriteLine(op.SumSalesByYear(t));

            break;


        case "s" or "S":
            Console.WriteLine("Enter city in persian :");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(op.SumSalescity_name(y));

            break;

        default:
            throw new Exception("Invalid.............");

    }
    Console.WriteLine("Continue ? y/n ");
    q = lk.keyboardYESORNOlocker();

} while (q.ToLower() == "y");

Console.WriteLine("Do you want to search by city? (Y) OR (N)");
string g = yn.keyboardYESORNOlocker();



Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Thanks to see our site....");
Console.ResetColor();