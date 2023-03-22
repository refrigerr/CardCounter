using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CardCounter
{
    
    internal class CardManager
    {
        private List<Card> cards = new List<Card>();
        private Stack<Card> stack = new Stack<Card>();
        private int[] cardTracker;
        private int cardCount = 0;
        private int decksNumber;
        public CardManager(int decksNumber) {
            this.decksNumber = decksNumber;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < decksNumber; j++)
                {
                    cards.Add(new Card(i + 2, "pik"));
                    cards.Add(new Card(i + 2, "kier"));
                    cards.Add(new Card(i + 2, "karo"));
                    cards.Add(new Card(i + 2, "trefl"));
                }
                
            }
            cardTracker = new int[52*decksNumber];
            for (int i = 0;i < cardTracker.Length;i++)
            {
                cardTracker[i] = 0;
            }
        }

        public List<Card> getCards() { return cards;}
        public Stack<Card> getStack() {  return stack;}
        public Card getCard(int number, string type)
        {
            foreach (Card card in cards)
            {
                if(card.getNumber()==number&& card.getType().Equals(type))
                    return card;
            }
            return null;
        }
        //disgusting methods
        public static int getNumberFromString(string number)
        {
            switch (number)
            {
                case "2": return 2;
                case "3": return 3;
                case "4": return 4;
                case "5": return 5;  
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "10": return 10;
                case "J": return 11;
                case "Q": return 12;
                case "K": return 13;
                case "A": return 14;
                default: return -1;
            }
        }
        public static string getStringFromNumber(int number)
        {
            if (number < 11)
                return number.ToString();
            else
            {
                switch (number)
                {
                    case 11: return "J";
                    case 12: return "Q";  
                    case 13: return "K";
                    case 14: return "A";
                    default: return "ERROR";
                }
            }
        }
        public static int getNumberFromType(string type)
        {
            switch (type)
            {
                case "kier":return 1;
                case "karo":return 2;    
                case "trefl": return 3;  
                default: return 0;
            }
        }

        public int getCardTracking(int number)
        {
            
            return cardTracker[number];
        }
        public void putCardTracking(int number)
        {
            cardTracker[number]+=1;
            
        }
        public void popCardTracking(int number)
        {
            cardTracker[number] -= 1;

        }
        public void changeCardCount(int number)
        {
            cardCount += number;
        }
        public int getCardCount()
        {
            return cardCount;
        }
        public int getDecksNumber()
        {
            return decksNumber;
        }

    }
}
