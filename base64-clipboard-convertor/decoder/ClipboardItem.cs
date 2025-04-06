using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    public class ClipBoardItem
    {
        private string text;
        private string base64;

        public int ID { get; set; }
        public string Text
        {
            get => text;
            set
            {
                text = value;
                base64 = ConvertToBase64(value);
            }
        }

        public string Base64
        {
            get => base64;
            set
            {
                if (IsBase64String(value))
                {
                    base64 = value;
                    text = ConvertToTxt(value);
                }
            }
        }

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

        protected string ConvertToBase64(string plainText)
        {
            try
            {
                byte[] textBytes = Encoding.UTF8.GetBytes(plainText);
                return Convert.ToBase64String(textBytes);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
