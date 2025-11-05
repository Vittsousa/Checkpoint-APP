public class WhatsApp
{
public void EnviarMensagem(string numero, TextMessage mensagem)
    {
        Console.WriteLine($"Enviar mensagem de texto para o número {numero}");
    }

        public void EnviarMensagem(string numero, VideoMessage mensagem )
    {
        Console.WriteLine($"Enviar mensagem de video para o número {numero}");
    }

            public void EnviarMensagem(string numero, PhotoMessage mensagem)
    {
        Console.WriteLine($"Enviar mensagem de foto para o número {numero}");
    }

            public void EnviarMensagem(string numero, FileMessage mensagem)
    {
        Console.WriteLine($"Enviar mensagem de arquivo para o número {numero}");
    }

}