using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WOPR_Systems
{
    public class Deck
    {
        private List<Card> Cards;

        public class CardPlayer
        {
            private List<Card> Cards;
            private Deck Parent;

            public CardPlayer(int initialHandSize, Deck deck)
            {
                Parent = deck;
                Cards = new List<Card>(initialHandSize);

                for (int i = 0; i < initialHandSize; i++)
                {
                    deck.Draw(this);
                }
            }

            public List<Card> CardList
            {
                get { return this.Cards; }
            }

            public Deck ParentDeck
            {
                get { return this.Parent; }
            }

            public int CalculateSum()
            {
                int total = 0;
                int acesCount = 0;
                foreach (Card card in this.CardList)
                {
                    if (card.CardValue == "A")
                    {
                        acesCount++;
                    }
                    else if (card.CardValue == "K" || card.CardValue == "Q" || card.CardValue == "J")
                    {
                        total += 10;
                    }
                    else
                    {
                        total += Int32.Parse(card.CardValue);
                    }
                }

                if (total+acesCount <= 21)
                {
                    return total + acesCount; //...perfectly valid hand
                }
                else if (total > 21 && acesCount == 0)
                {
                    return total; //...player has bust and lost
                }
                else
                {
                    int acesScore = total + (11 * acesCount);
                    while (acesCount > 0)
                    {
                        acesCount -= 1;
                        acesScore -= 10;
                        if (acesScore <= 21)
                        {
                            return acesScore; //...perfectly valid hand
                        }
                    }

                    return (total + (11 * acesCount)); //...player has bust and lost
                }
            }
        }

        public class Card
        {
            private string Suit;
            private string SuitName;
            private string Value;
            private bool Facedown;
            private string Image;
            private string[] ImageArray;
            private string Space;

            public Card(string suit, string value, bool facedown = false)
            {
                Value = value;

                if (value == "10")
                {
                    Space = "";
                }
                else
                {
                    Space = " ";
                }

                Facedown = facedown;

                if (suit == "Diamonds")
                {
                    Suit = "♦";
                }
                else if (suit == "Clubs")
                {
                    Suit = "♣";
                }
                else if (suit == "Hearts")
                {
                    Suit = "♥";
                }
                else if (suit == "Spades")
                {
                    Suit = "♠";
                }
                else
                {
                    throw new ArgumentException("Suit must be one of 4 values; 'Diamonds', 'Clubs', 'Hearts', 'Spades'");
                }

                SuitName = suit;

                CreateImage();
            }

            private void CreateImage()
            {
                string image;
                string[] imageArray = new string[10];

                if (Facedown == false)
                {
                    image = "┌─────────────┐\n" +
                           $"│{Value + Space}           │\n" +
                            "│             │\n" +
                            "│             │\n" +
                           $"│      {Suit}      │\n" +
                           $"│      {Suit}      │\n" +
                            "│             │\n" +
                            "│             │\n" +
                           $"│           {Space + Value}│\n" +
                            "└─────────────┘";

                    imageArray[0] = "┌─────────────┐\n";
                    imageArray[1] = $"│{Value + Space}           │\n";
                    imageArray[2] = "│             │\n";
                    imageArray[3] = "│             │\n";
                    imageArray[4] = $"│      {Suit}      │\n";
                    imageArray[5] = $"│      {Suit}      │\n";
                    imageArray[6] = "│             │\n";
                    imageArray[7] = "│             │\n";
                    imageArray[8] = $"│           {Space + Value}│\n";
                    imageArray[9] = "└─────────────┘";
                }
                else
                {
                    image = "┌─────────────┐\n" +
                            "│░ ░ ░ ░ ░ ░ ░│\n" +
                            "│ ░ ░ ░ ░ ░ ░ │\n" +
                            "│░ ░ ░ ░ ░ ░ ░│\n" +
                            "│ ░ ░ ░ ░ ░ ░ │\n" +
                            "│░ ░ ░ ░ ░ ░ ░│\n" +
                            "│ ░ ░ ░ ░ ░ ░ │\n" +
                            "│░ ░ ░ ░ ░ ░ ░│\n" +
                            "│ ░ ░ ░ ░ ░ ░ │\n" +
                            "└─────────────┘";

                    imageArray[0] = "┌─────────────┐\n";
                    imageArray[1] = "│░ ░ ░ ░ ░ ░ ░│\n";
                    imageArray[2] = "│ ░ ░ ░ ░ ░ ░ │\n";
                    imageArray[3] = "│░ ░ ░ ░ ░ ░ ░│\n";
                    imageArray[4] = "│ ░ ░ ░ ░ ░ ░ │\n";
                    imageArray[5] = "│░ ░ ░ ░ ░ ░ ░│\n";
                    imageArray[6] = "│ ░ ░ ░ ░ ░ ░ │\n";
                    imageArray[7] = "│░ ░ ░ ░ ░ ░ ░│\n";
                    imageArray[8] = "│ ░ ░ ░ ░ ░ ░ │\n";
                    imageArray[9] = "└─────────────┘";
                }

                Image = image;
                ImageArray = imageArray;
            }

            public void Draw(bool newRow = false)
            {
                CreateImage();

                if (newRow)
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                }

                if ((Console.CursorTop - 9 >= 0))
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 9);
                    int left = Console.GetCursorPosition().Left;
                    int top = Console.GetCursorPosition().Top;

                    for (int i = 0; i < ImageArray.Length; i++)
                    {
                        Console.SetCursorPosition(left, top);

                        Console.Write(ImageArray[i]);

                        top += 1;
                    }
                }
                else
                {
                    for (int i = 0; i < ImageArray.Length; i++)
                    {
                        Console.Write(ImageArray[i]);
                    }
                }
            }

            public void Flip()
            {
                Facedown = !Facedown;
                CreateImage();
            }

            public string CardSuit
            {
                get { return SuitName; }
            }

            public string CardValue
            {
                get { return Value; }
            }

            public bool isFacedown
            {
                get { return Facedown; }
            }
        }

        public Deck(bool shuffled = false)
        {
            string[] suits = new string[52];
            string[] values = new string[52];
            string[] valuesList =
            {
                    "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
            };
            List<Card> cards = new List<Card>();

            for (int i = 0; i < suits.Length; i++)
            {
                if (i < 13)
                {
                    suits[i] = "Diamonds";
                }
                else if (i < 26 && i >= 13)
                {
                    suits[i] = "Clubs";
                }
                else if (i < 39 && i >= 26)
                {
                    suits[i] = "Hearts";
                }
                else if (i < 52 && i >= 39)
                {
                    suits[i] = "Spades";
                }
            } //Make ordered suits list (1st parallel array)

            int indexer = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 13 == 0)
                {
                    indexer = 0;
                }

                values[i] = valuesList[indexer];

                indexer++;
            } //Make ordered values list (2nd parallel array)

            for (int i = 0; i < 52; i++)
            {
                Card card = new Card(suits[i], values[i]);
                cards.Add(card);
            } //Make ordered deck of cards with the parallel arrays.

            if (shuffled)
            {
                Cards = cards;
                Shuffle();
                Shuffle();
                Shuffle();
                Shuffle();
                Shuffle();
            }
            else
            {
                Cards = cards;
            }
        }

        public void Shuffle()
        {
            int n = CardList.Count;
            Random rng = new Random();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = CardList[k];
                CardList[k] = CardList[n];
                CardList[n] = value;
            }
        }

        public void Draw(CardPlayer recipient)
        {
            recipient.CardList.Add(recipient.ParentDeck.CardList.ElementAt(0));
            recipient.ParentDeck.CardList.RemoveAt(0);
        }

        public List<Card> CardList
        {
            get { return this.Cards; }
        }
    }
}
