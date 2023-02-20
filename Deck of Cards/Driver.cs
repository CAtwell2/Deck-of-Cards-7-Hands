
using CardClass;
namespace Card_Class

{
    class Driver
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Deck deck2 = new Deck();

            Console.WriteLine("The Original Deck of Cards:");
            Console.WriteLine(deck.DealAHand(52));

            deck.Shuffle();

            Console.WriteLine("\nThe Original Deck of Cards After Shuffling:");
            Console.WriteLine(deck.DealAHand(52));

            Console.WriteLine("Two hands of 7 cards from the copied deck:");
            Console.WriteLine(deck2.DealAHand(7));
            Console.WriteLine(deck2.DealAHand(7));

            

        }
    }
}