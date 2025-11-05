using System;

public class FileMessage : Mensagem
{
    public string NomeArquivo { get; set; }
    public string Formato { get; set; }
    public long TamanhoBytes { get; set; } // opcional, pode ser 0 se não souber

    public FileMessage(string conteudo, string nomeArquivo, string formato, long tamanhoBytes = 0)
        : base(conteudo)
    {
        NomeArquivo = nomeArquivo;
        Formato = formato;
        TamanhoBytes = tamanhoBytes;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[ARQUIVO] {Conteudo}");
        Console.WriteLine($"Arquivo: {NomeArquivo}.{Formato}");
        if (TamanhoBytes > 0)
            Console.WriteLine($"Tamanho: {TamanhoBytes} bytes");
        Console.WriteLine($"Enviado em: {DataEnvio}");
    }
}