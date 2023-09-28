using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AleevRI.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            string[] wordsRemoveLastLiter = words.Select(x => x.Remove(x.Length - 1)).ToArray<string>();
            string strFinal = string.Join(" ", wordsRemoveLastLiter);
            return strFinal;

        }
    }
}
