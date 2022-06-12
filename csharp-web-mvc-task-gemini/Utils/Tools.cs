using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_web_mvc_task_gemini.Utils
{
    public class Tools
    {
    public Tools()
    {

    }
    public static String shortString(String input, int length)
    {
        if (input.Length > length)
        {
            input = input.Substring(0, length) + "...";
        }
        return input;
    }

    }
}
