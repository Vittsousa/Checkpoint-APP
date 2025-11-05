using System;

public class VideoMessage : Mensagem
{
    public string CaminhoDoVideo { get; set; }
    public string Formato { get; set; }
    public int DuracaoSegundos { get; set; }

    public VideoMessage(string conteudo, string caminhoDoVideo, string formato, int duracaoSegundos)
        : base(conteudo)
    {
        CaminhoDoVideo = caminhoDoVideo;
        Formato = formato;
        DuracaoSegundos = duracaoSegundos;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[VÍDEO] {Conteudo}");
        Console.WriteLine($"Arquivo: {CaminhoDoVideo}");
        Console.WriteLine($"Formato: {Formato}");
        Console.WriteLine($"Duração: {DuracaoSegundos} segundos");
        Console.WriteLine($"Enviado em: {DataEnvio}");
    }
}