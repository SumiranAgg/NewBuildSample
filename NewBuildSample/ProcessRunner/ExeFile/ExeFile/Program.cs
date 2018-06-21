using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace ExeFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Argus: {0}", args.Length);
            if (args.Length > 0)
            {
                for (int index = 0; index < args.Length; index++)
                {
                    Console.WriteLine("Argument {0}=\"{1}\"", index + 1, args[index]);
                }                
            }
            Console.WriteLine("Current working folder: {0}", System.IO.Directory.GetCurrentDirectory());

            Console.WriteLine("GetEnvironmentVariables: ");

            Dictionary<String, String> env = new Dictionary<string, string>();

            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            {
                env.Add((String)de.Key, (String)de.Value);
            }
            foreach (var item in env.OrderBy(x => x.Key))
            {
                Console.WriteLine("  {0}={1}", item.Key, item.Value);
            }
        }
    }
}
