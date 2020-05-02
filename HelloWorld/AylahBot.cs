using System;

namespace HelloWorld
{
    public class AylahBot
    {
        public void Start()
        {
            Console.WriteLine("Hello, and welcome to my library.");
            Console.WriteLine("Which type of book would you like to borrow? Fantasy, mythology, or nonfiction?");
            var response = Console.ReadLine();
            if (response.ToLower() == "fantasy")
            {
                TalkFantasy();
            }
            else if (response.ToLower() == "mythology")
            {
                TalkMythology();
            }
            else if (response.ToLower() == "nonfiction")
            {
                TalkNonfiction();
            }
            else
            {
                Console.WriteLine($"Did you say you wanted {response}?");
                Console.WriteLine("Hmm...It doesn't look like I have any books in that catergory. I'm sorry.");
            }
        }

        void TalkFantasy()
        {
            Console.WriteLine("Oh, I love a good fantasy book.");
            Console.WriteLine("Harry Potter, Shadow and Bones, and so many more wonderful books fall in this catergory.");
            Console.WriteLine("Which book would you like to get?");
            var response = Console.ReadLine();
            Console.WriteLine($"Okay! One copy of {response} coming right up.");
        }

        void TalkMythology()
        {
            Console.WriteLine("Mythology is so good. This includes Percy Jackson, Magnus Chase, and so many more.");
            Console.WriteLine("Which book would you like to get?");
            var answer = Console.ReadLine();
            Console.WriteLine($"Okay! One copy of {answer} coming right up.");
        }

        void TalkNonfiction()
        {
            Console.WriteLine("Nonfiction books are great for learning.");
            Console.WriteLine("These books can teach you cool new facts, or tell you captivating true stories.");
            Console.WriteLine("What topic are you looking for?");
            var topic = Console.ReadLine();
            Console.WriteLine($"Okay! One book about {topic} coming right up.");
        }
    }
}