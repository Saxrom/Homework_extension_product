using System;
namespace Extension_task1
{
    static class Extension
    {
        public static void CustomContain(this string sentence,string search)
        {
            bool result = false;
            for (int i = 0; i < sentence.Length - search.Length + 1; i++)
            {
                string newSentence = sentence.Substring(i, search.Length);


                if (newSentence.ToLower() == search.ToLower())
                {
                    result = true;
                    break;
                }


            }
            Console.WriteLine($"{(result == true ? "True" : "False")}");
        }
    }
}
