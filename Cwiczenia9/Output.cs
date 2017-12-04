using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenia9
{
    class Output
    {
        private static string fileName = "results.txt";

        public static void ShowDialogBox(String msg)
        {
            MessageBox.Show(msg);
        }

        public static void SaveToFile(String txt)
        {
            FileStream fileStream;
            StreamWriter streamWriter;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Append);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(txt);
                streamWriter.Flush();
            }
            catch (IOException e)
            {
                ShowDialogBox(e.Message);
            }           
        }
    }
}
