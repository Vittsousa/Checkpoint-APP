public class MediaMessage : MessgaeBase
{
    public File file { get; set; }
    MediaMessage(string message) : base(message) { }
}

public class PhotoMessage : MediaMessage
{
    PhotoMessage(string message) : base(message) { }
}

public class VideoMessage : MediaMessage
{
    VideoMessage(string message) : base(message) { }

}