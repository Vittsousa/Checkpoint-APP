public class Instagram 
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o numero {numero}");
    }

    public void EnviarMensagem(string numero, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de video para o numero {numero}");
    }

    public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o numero {numero}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o numero {numero}");
    }

}