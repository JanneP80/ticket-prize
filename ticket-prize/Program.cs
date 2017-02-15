using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_prize // typo: *price
{
    class Program
    {
        static void Main(string[] args)
        {
            float ticket_price = 16;
            int age = 0;
            string areyou;
            string student;
            string mtk;

            string message = string.Empty;
            Console.WriteLine("Input your information: ");
            // ikä
            Console.Write("Your age: ");
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (!result) // incorrect input
            {
                message = "Input is NOT a number.";
            }


            // laske alennus, vain yksi myönnetään, ellei ole Mtk:n jäsen ja opiskelija
            // ikä
            if (age < 7)
            {

                message = string.Format("Lipun hinta: {0}", ticket_price * 0);
            }
            else if (age > 64 | age < 16)
            {

                message = string.Format("Lipun hinta: {0}", ticket_price * 0.5);
            }
            else
            {
                // oletko varusmies
                Console.Write("Are you a conscript? (yes/no): ");
                areyou = Console.ReadLine();
                if (areyou.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    message = string.Format("Lipun hinta: {0}", ticket_price * 0.5); // varusmieshinta
                }
                else if (areyou.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    // 
                    // oletko opiskelija
                    Console.Write("Are you a student? (yes/no): ");
                    student = Console.ReadLine();
                    if (student.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.Write("Are you a member of Mtk? (yes/no): "); // oletko mtk:n jäsen
                        mtk = Console.ReadLine();
                        if (mtk.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                        {
                            message = string.Format("Lipun hinta: {0}", ticket_price - ticket_price * 0.45 - (ticket_price * 0.45) * 0.15); // student AND mtk price

                        }
                        else
                        {
                            message = string.Format("Lipun hinta: {0}", ticket_price - ticket_price * 0.45); // student price
                        }                                                                             


                    }                  
             
                        else if (student.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                        {
                        Console.Write("Are you a member of Mtk? (yes/no): "); // oletko mtk:n jäsen
                        mtk = Console.ReadLine();
                        if (mtk.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                        {
                            message = string.Format("Lipun hinta: {0}", ticket_price - ticket_price * 0.15); // 
                        }

                    }
                    
                   
                    }
                
                else
                {
                // normal price
                message = string.Format("Lipun hinta: {0}", ticket_price);
            }
            }

            // ilmoita lipun hinta

            Console.WriteLine(message);
            Console.ReadKey();

        }
    }
}
