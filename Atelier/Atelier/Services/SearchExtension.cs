using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Services
{
    internal static class SearchExtension
    {
        public static string Search(string[] arr, string str)
        {
            string line = "";
            for ( int i = 0; i < arr.Length; i++)
            {
                line = line + arr[i];
            }

            if (line.Contains(str))
            {
                return line;
            }
            else
            {
                return null;
            }
        }
    }
}
