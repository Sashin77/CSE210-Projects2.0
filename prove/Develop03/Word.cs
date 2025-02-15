namespace ScriptureMemorizer.Models
{
    public class Word
    {
        public string Text { get; set; }
        private bool _isHidden;

        public Word(string text)
        {
            Text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public void Reveal()
        {
            _isHidden = false;
        }

        public override string ToString()
        {
            return _isHidden ? "_____" : Text;
        }
    }
}
