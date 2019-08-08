using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionaryLiabrary.BusinessLogic
{
    class DictionaryToString
    {
        /// <summary>
        /// parse a string,string dictionary into a string in proper format
        /// </summary>
        /// <param name="input">the dictionary that being parsed</param>
        /// <param name="spliter">the char used to divide each key and value</param>
        /// <returns></returns>
        public static string Parse(Dictionary<string, string> input, char spliter)
        {
            string parsedInput = "";
            StringBuilder builder = new StringBuilder();
            foreach (var keypair in input)
            {
                builder.Append($"{keypair.Key}{spliter}{keypair.Value}{spliter}");
            }
            parsedInput = builder.ToString();
            parsedInput = parsedInput.TrimEnd(spliter);
            return parsedInput;
        }
    }
}
