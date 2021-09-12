namespace Botster.Core.Communication
{
    public class Content
    {
        public string Value { get; set; }
        public bool HasValue => string.IsNullOrEmpty(Value);
    }
}