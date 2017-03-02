
namespace Interview
{
    public class CodeReview
    {
        /// <summary>
        /// This method returns integer parsed from the source. 
        /// If parsing fails it should return zero.
        /// </summary>
        /// <param name="o">Object with data to parse.</param>
        /// <returns>Parsed value</returns>
        public int Parse(object o)
        {
            if (o.GetType() != typeof(int))
            {
                return 0;
            }
            return int.Parse(o.ToString());
        }
        /// <summary>
        /// This method returns concatenated string from the array of the strings.
        /// </summary>
        /// <param name="lines">Array of strings with lines.</param>
        /// <returns>Concatenated string.</returns>
        public string Concat(string[] lines)
        {
            string result = "";

            foreach (string line in lines)
            {
                result += line;
            }

            return result;
        }

    }
}
