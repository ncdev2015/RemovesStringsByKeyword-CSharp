using System;

namespace removesAStringFromString
{
    class Program
    {
        static string removesStringByKeyword(string toRemove, string input)
        {
            var arrayInput = input.Split(" ");
            var newString = "";

            foreach (var item in arrayInput)
            {
                if (item.Contains(toRemove))
                    continue;

                newString += item + " ";
            }

            return newString.Remove(newString.Length-1);
        }

        static void Main(string[] args)
        {
            string strIn = "This is a sample of string, this is to remove: AnyCharRemoveMeOthreString RemoveMe";
            Console.WriteLine(removesStringByKeyword("RemoveMe", strIn)); // Output: "This is a sample of string, this is to remove:"
        }
    }
}
