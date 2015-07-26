using System.IO;
using System.Text;
using System.Windows;

namespace Clippy
{
    public class ClipboardWriter : TextWriter
    {
        public override Encoding Encoding { get { return Encoding.ASCII; } }

        public override void Write(char value)
        {
            Clipboard.SetText(new string(new char[] { value }));
        }

        public override void Write(string value)
        {
            Clipboard.SetText(value);
        }
    }
}