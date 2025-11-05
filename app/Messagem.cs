using System;

public abstract class Mensagem
{
    public string Conteudo { get; }
    public DateTime DataEnvio { get; }

    public Mensagem(string conteudo)
    {
        Conteudo = conteudo;
        DataEnvio = DateTime.Now;
    }

    public abstract void ExibirDetalhes();
}