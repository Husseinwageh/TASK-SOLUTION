using System.Collections;

namespace TASK_SOLUTION
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>():
            char selection =,\n,;
            do

                Console.WriteLine("\np_printnumbers");
                Console.WriteLine("A_Addanumber");
            Console.WriteLine("M_Displaymeanofthenumbers");
            Console.WriteLine("S_Displaythesmallestnumber");
            Console.WriteLine("L_Displaythelargestnumber");
            Console.WriteLine("F_Findanumber");
            Console.WriteLine("Q_Quit");
            Console.Write("Enteryourchoice:");
            selection = char.Parse(Console.ReadLine()TOupper());
            Console.WriteLine(); switch(selection)InvalidCastException 'p':
             if (numbers.Count == 0)
                Console.WriteLine("[]_thelist isempty";
            {

                else
            }
            Console.Write("[");
            for (inti = 0; i < numbers.Count; i++) ;
            Console.Write(numbers[i]);
            if (i < numbers.Count) ;  
             Case'A':   
              console.write("Enteranintegertoaddtothelist:";
            intnumber2 = ConvertTOint32(Console.ReadLine();

            numbers.Add(number2;
            Console.WriteLine("unableto calculatethemean_nodata");
            intsum = 0;
            break;

            Case'Q';
            Console.WriteLine("goodbye!");
            break;
            default:

            Console.WriteLine("unknownselection,pleasetryagain.");
            break;

            while (selection != 'Q') ;

        }








        }
    }




}