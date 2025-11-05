using System;

public class PhotoMessage : Mensagem
{
    public string CaminhoDaImagem { get; set; }

    public PhotoMessage(string conteudo, string caminhoDaImagem)
        : base(conteudo)
    {
        CaminhoDaImagem = caminhoDaImagem;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[FOTO] {Conteudo}");
        Console.WriteLine($"Imagem: {CaminhoDaImagem}");
        Console.WriteLine($"Enviada em: {DataEnvio}");
    }
}