using System;
using System.Text;

namespace lexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLimit = Convert.ToInt32(Console.ReadLine());
            int stringCharLimit = 1000;
            if(inputLimit < 1 && inputLimit > 10000)
            {
                return;
            }
            string[] inputs = new string[inputLimit];
            for (int i=0; i< inputLimit; i++)
            {
                inputs[i] = Console.ReadLine();
                if(inputs[i].Length> stringCharLimit)
                {
                    inputs[i]=inputs[i].Substring(0, stringCharLimit);
                }
            }
            Array.Sort(inputs);
            StringBuilder s = new StringBuilder();
            foreach (string sortedString in inputs)
            {
                s.Append(sortedString).Append("\n");
            }
            Console.Write(s.ToString());
            Console.ReadLine();
        }
    }
}
