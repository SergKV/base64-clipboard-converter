using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    public class ClipBoardItem
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Base64 { get; set; }

        public ClipBoardItem(string input)
        {
            if (IsBase64String(input))
            {
                Base64 = input;
                Text = ConvertToTxt(input);
            }
        }

        private bool IsBase64String(string str)
        {
            str = str.Trim();
            return (str.Length % 4 == 0) && System.Text.RegularExpressions.Regex.IsMatch(str, @"^[a-zA-Z0-9\+/=]*$");
        }

        protected string ConvertToTxt(string base64EncodedText)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(base64EncodedText);
                var plainText = Encoding.UTF8.GetString(decodedBytes);
                return plainText;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
