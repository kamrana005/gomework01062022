using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string snt ="Today is the best day in my life";
            string snt1 = "It is the last day of me in here";
            string c = (string)snt.Clone();
            Console.WriteLine(c);



            string sentence = "Today is the best day in my life";
            string sentence1 = "It is the last day of me in here";
            Console.WriteLine(string.Concat(sentence, sentence1));

            string sentence2 = "Today is the best day in my life";
            string sentence3 = "It is the last day of me in here";
            Console.WriteLine(sentence3.Contains(sentence1));



            string sentence6 = "Today  best ";
            string sen = string.Copy(sentence6);
            Console.WriteLine(sen);

            string sentence8 = "Today";
            string sentence7 = " day ";
            Console.WriteLine(sentence8.Equals(sentence7));

            string sentence9 = "Today ";
            
                Console.WriteLine(sentence9.IndexOf('y'));


            string sent8 = "Today";
            string sent7 = " day ";
            Console.WriteLine(sent7.Insert(3, "Today"));

            string sent11 = "best";
            
            Console.WriteLine(sent11.Replace("st","worst"));



            string sent13 = "wonderful";
            Console.WriteLine(sent13.Substring(3));


            string sent14 = "         wonderful          ";
            Console.WriteLine(sent14.Trim());

            string sent15 = "         wonderful          ";
            Console.WriteLine(sent15.TrimEnd());


            string sent16 = "         wonderful          ";
            Console.WriteLine(sent16.TrimStart());

            string snt9 = "Today is the best day in my life";
            Console.WriteLine(snt9.Length);

            string snt11 = "Today is the best day in my life";
            Console.WriteLine(snt11.Remove(16));


            string snt12 = "Todayisthebestday in my life";
            Console.WriteLine(snt12.Substring(4,19));



            string snt13 = "Today is the best day in my life";
            Console.WriteLine(snt13.Remove(0, snt13.Length / 2));


            string snt14 = "Todayisthebestday in my life";
            for(int i = 0; i < snt14.Length; i++)

             Console.WriteLine(snt14.Substring(i,1));



            string snt15 = "Todayisthebestday in my life";
            Console.WriteLine(snt15.ToCharArray());


            






        }
    }
}
