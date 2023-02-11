using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i =0; i< numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        public static string RandomSuit()
        {
            int value = random.Next(1,5);
            if (value == 1) return "Pik";
            else if (value == 2) return "Kier";
            else if (value == 3) return "Trefl";
            else return "Karo";           
        }
        public static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "As";
            else if (value == 11) return "Walet";
            else if (value == 12) return "Dama";
            else if (value == 13) return "Krol";
            else return value.ToString();
        }
    }
}
