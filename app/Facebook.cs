using System;

public class Facebook
{
    public void EnviarMensagem(string usuario, Mensagem mensagem)
    {
        Console.WriteLine($"[FACEBOOK] Enviando mensagem para o usuário: @{usuario}");
        mensagem.ExibirDetalhes();
        Console.WriteLine("-------------------------------------");
    }
}