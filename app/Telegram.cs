using System;

public class Telegram
{
    public void EnviarMensagemPorNumero(string numero, Mensagem mensagem)
    {
        Console.WriteLine($"[TELEGRAM - Número] Enviando mensagem para o número: {numero}");
        mensagem.ExibirDetalhes();
        Console.WriteLine("-------------------------------------");
    }

    public void EnviarMensagemPorUsuario(string usuario, Mensagem mensagem)
    {
        Console.WriteLine($"[TELEGRAM - Usuário] Enviando mensagem para o usuário: @{usuario}");
        mensagem.ExibirDetalhes();
        Console.WriteLine("-------------------------------------");
    }
}