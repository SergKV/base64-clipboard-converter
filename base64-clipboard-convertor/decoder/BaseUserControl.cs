using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace decoder
{
    public class BaseUserControl : UserControl
    {
        protected bool IsBase64String(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length % 4 != 0 || !System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-Z0-9\+/]*={0,2}$"))
            {
                return false;
            }

            try
            {
                Convert.FromBase64String(text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected bool IsPlainText(string str)
        {
            return Regex.IsMatch(str, @"^[\x20-\x7E]*$");
        }

        protected string ConvertToTxt(string base64EncodedText, out string plainText)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(base64EncodedText);
                plainText = Encoding.UTF8.GetString(decodedBytes);
            }
            catch
            {
                plainText = null;
            }
            return plainText;
        }

        protected void ExportAsFile(string text, string fileName)
        {
            StreamWriter sw = new(fileName);

            sw.WriteLine(text);

            sw.Close();
        }
    }
}
