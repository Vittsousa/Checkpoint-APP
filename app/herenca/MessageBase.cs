public abstract class Messagebase
{
    protected Messagebase(string message)
    {
        Message = message;
        SendAt = DateTime.Now;
    }

    public string Message { get; }
    public DateTime SendAt { get; }
}