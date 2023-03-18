using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digikala_project
{
    namespace locker
    {
        class lockkeyboard
        {
            public string y;
            private string x;
            private int num;
            public ConsoleKeyInfo Lock;
            public int keyboardnumberlocker()
            {
                while (true)
                {
                    Lock = Console.ReadKey(true);
                    if (char.IsDigit(Lock.KeyChar))
                    {
                        num = num * 10 + (int)char.GetNumericValue(Lock.KeyChar);
                        Console.Write(Lock.KeyChar);
                    }
                    else
                    {
                        Console.Beep();
                    }
                    if (Lock.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
                return num;
            }

            public string keyboardYESORNOlocker()
            {
                do
                {
                    x = Console.ReadKey(true).KeyChar.ToString();

                } while (x.ToLower() != "y" & x.ToLower() != "n");
                return x;
            }
            public string menulocker()
            {
                do
                {
                    y = Console.ReadKey(true).KeyChar.ToString();

                } while (y.ToLower() != "y" & y.ToLower() != "o" & y.ToLower() != "c" & y.ToLower() != "i" & y.ToLower() != "t");
                return y;
            }
        }
    }

}
