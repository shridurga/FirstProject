using System;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("World!");
            sb.AppendLine();
              sb.AppendLine("World!");
               sb.Append("Hello C#");
            sb.Append("sdfghjk");
            Console.WriteLine(sb);

        }
    }
}
