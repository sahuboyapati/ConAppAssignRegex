using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConAppAssignRegex
{
    public class Program
    {
        int count;
        string mail;
        string mobile;
        public void Count()
        {
            Console.WriteLine("enter a text to count number of words in it is:");
            string text = Console.ReadLine();
            int count = Regex.Matches(text, @"\b\w+\b").Count;
            Console.WriteLine("total words in the text is " + count);
        }
        public void Email()
        {
            Console.WriteLine("enter email");
            mail = Console.ReadLine();
            string pattern = @"[a-z0-9]+@[a-z0-9]+\.[a-z]{2,4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("valid email");
            }
            else
            {
                Console.WriteLine("invaild email");
            }
        }
        public void Mobile()
        {
            Console.WriteLine("enter mobile number");
            mobile = Console.ReadLine();
            string pattern1 = @"^\d{10}$";
            Regex regex1 = new Regex(pattern1);
            if (regex1.IsMatch(mobile))
            {
                Console.WriteLine("valid phone number");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }

        public void CustomRegexSearch()
        {
            Console.WriteLine("enter your custom regex:");
            string customregex = Console.ReadLine();
            string pattern3 = @"\d+";
            Regex regex = new Regex(pattern3);
            if (regex.IsMatch(customregex))
            {
                Console.WriteLine($"Found:{customregex}");
            }
            else
            {
                Console.WriteLine($"not found:{customregex}");
            }
        }
        public void display()
        {
            Console.WriteLine("The data given is as Follows:");
            Console.WriteLine($"Total {count} words in the sentence/paragraph which you entered is ");
            Console.WriteLine($"You entere '{mail}' this as your email");
            Console.WriteLine($"You entere this '{mobile}' as your mobile number");

        }

        static void Main(string[] args)
        {

            Program counting = new Program();
            counting.Count();

            Program email = new Program();
            email.Email();

            Program number = new Program();
            number.Mobile();


            Program custom = new Program();
            custom.CustomRegexSearch();


            Program displaying = new Program();
            displaying.display();
            Console.ReadKey();

        }
    }
}