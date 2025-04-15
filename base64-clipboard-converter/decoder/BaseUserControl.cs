using System.Text.RegularExpressions;

namespace decoder
{
    public class BaseUserControl : UserControl
    {
        protected bool IsBase64String(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length % 4 != 0 || text.Contains(" ") || text.Contains("\t") || text.Contains("\r") || text.Contains("\n"))
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

        protected void ExportAsFile(string text, string fileName)
        {
            StreamWriter sw = new(fileName);

            sw.WriteLine(text);

            sw.Close();
        }
    }
}
