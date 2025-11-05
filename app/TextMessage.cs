using System;

public class TextMessage : Mensagem
{
    public TextMessage(string conteudo) : base(conteudo)
    {
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[Texto] {Conteudo} - Enviado em {DataEnvio}");
    }
}