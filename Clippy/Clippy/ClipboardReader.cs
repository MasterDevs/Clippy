using System.Windows;

namespace Clippy
{
    public class ClipboardReader : ReadLineTextReader
    {
        private bool _isEof = false;

        public override string ReadLine()
        {
            if (_isEof)
            {
                return null;
            }
            else
            {
                _isEof = true;

                string clip = Clipboard.GetText();
                return clip;
            }
        }
    }
}