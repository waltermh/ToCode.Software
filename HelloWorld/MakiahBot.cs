using System;

namespace HelloWorld
{
    public class MakiahBot
    {
        public void Start()
        {
            Console.WriteLine("Do you eat pickles");
            var response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                TalkToThePickleEater();
            }
            else if (response.ToLower() == "maybe")
            {
                AnswerMaybe();
            }
        }

        
        void TalkToThePickleEater ()
        {
            Console.WriteLine("You like pickles?");
            Console.WriteLine("I do not eat pickles, I am a computer! But that might be nice.");
            
        
        }
        
        void AnswerMaybe()
        {
            Console.WriteLine("");
        }
    }
}