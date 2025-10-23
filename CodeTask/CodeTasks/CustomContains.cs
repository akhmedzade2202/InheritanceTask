using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcaTasks
{
    internal class CustomContains
    {
        public bool customContains(string input, string search)
        {
            if (input == null || search == null)
            {
                return false;
            }

            string lowerInput = toLowerCase(input);
            string lowerSearch = toLowerCase(search);

            if (lowerSearch.Length == 0)
            {
                return true;
            }

            for (int i = 0; i <= lowerInput.Length - lowerSearch.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < lowerSearch.Length; j++)
                {
                    if (lowerInput[i + j] != lowerSearch[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return true;
                }
            }

            return false;
        }


        public bool customContains(string input, char searchChar)
        {
            if (input == null)
            {
                return false;
            }

            char lowerSearchChar = toLowerChar(searchChar);

            for (int i = 0; i < input.Length; i++)
            {
                char lowerInputChar = toLowerChar(input[i]);

                if (lowerInputChar == lowerSearchChar)
                {
                    return true;
                }
            }

            return false;
        }


        public string toLowerCase(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c + 32);
                }

                result += c;
            }

            return result;
        }



        public char toLowerChar(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c + 32);
            }

            return c;
        }

    }
}