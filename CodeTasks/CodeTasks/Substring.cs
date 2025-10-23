using CodeAcaTasks;

namespace CodeAcaTasks
{
    internal class Substring
    {
        public string customSubstring(string input, int startIndex)
        {
            if (input == null)
            {
                return "Input is null.";
            }

            if (startIndex < 0 || startIndex >= input.Length)
            {
                return "Invalid index.";
            }

            string result = "";
            for (int i = startIndex; i < input.Length; i++)
            {
                result += input[i];
            }

            return result;
        }

        public string customSubstring(string input, int startIndex, int length)
        {
            if (input == null)
            {
                return "Input is null.";
            }

            if (startIndex < 0 || startIndex >= input.Length || length < 0 || startIndex + length > input.Length)
            {
                return "Invalid index or length.";
            }

            string result = "";
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += input[i];
            }

            return result;
        }
    }
}



    




