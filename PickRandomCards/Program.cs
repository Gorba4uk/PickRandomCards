using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            run();
        }

        static void run()
        {
            string[] cards = CardPicker.PickSomeCards(5);
            for(int i =0; i<cards.Length; i++)
            {
                Console.WriteLine(cards[i]);
            }
        }
    }
}
