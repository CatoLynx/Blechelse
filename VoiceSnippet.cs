namespace Blechelse
{
    public class VoiceSnippet
    {
        public string FileName { get; set; } = "";
        public string DisplayText { get; set; } = "";
        public bool HasValue { get; set; } = false;

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
