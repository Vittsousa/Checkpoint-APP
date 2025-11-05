using System;

public class Instagram
{
    public void EnviarMensagem(string usuario, Mensagem mensagem)
    {
        Console.WriteLine($"[INSTAGRAM] Enviando mensagem para o usuário: @{usuario}");
        mensagem.ExibirDetalhes();
        Console.WriteLine("-------------------------------------");
    }
}