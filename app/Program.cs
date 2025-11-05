using System;

Console.WriteLine("=== ENVIO DE MENSAGENS ===");
Console.WriteLine("Escolha o canal:");
Console.WriteLine("1. WhatsApp");
Console.WriteLine("2. Telegram");
Console.WriteLine("3. Instagram");
Console.WriteLine("4. Facebook");
Console.Write("Opção: ");
string respostaCanal = Console.ReadLine();

if (!int.TryParse(respostaCanal, out int canal))
{
    Console.WriteLine("Canal inválido!");
    return;
}

Console.WriteLine("\nEscolha o tipo de mensagem:");
Console.WriteLine("1. Texto");
Console.WriteLine("2. Foto");
Console.WriteLine("3. Vídeo");
Console.WriteLine("4. Arquivo");
Console.Write("Opção: ");
string respostaTipo = Console.ReadLine();

if (!int.TryParse(respostaTipo, out int tipo))
{
    Console.WriteLine("Tipo inválido!");
    return;
}

// Cria o tipo de mensagem conforme escolha
Mensagem mensagem = tipo switch
{
    1 => new TextMessage("Olá! Essa é uma mensagem de texto."),
    2 => new PhotoMessage("Aqui está uma foto!", "imagem.png"),
    3 => new VideoMessage("Assista este vídeo!", "video.mp4", "mp4", 30),
    4 => new FileMessage("Segue o arquivo solicitado.", "documento", "pdf", 1024),
    _ => null
};

if (mensagem == null)
{
    Console.WriteLine("Tipo de mensagem inválido!");
    return;
}

Console.WriteLine("\n--- Enviando mensagem ---");

switch (canal)
{
    case 1:
        var whats = new WhatsApp();
        whats.EnviarMensagem("11999999999", (dynamic)mensagem);
        break;

    case 2:
        var telegram = new Telegram();
        // Telegram pode enviar por número OU usuário
        telegram.EnviarMensagemPorUsuario("@Vitoria_Sousa", mensagem);
        break;

    case 3:
        var insta = new Instagram();
        insta.EnviarMensagem("@Vitoria_Sousa", mensagem);
        break;

    case 4:
        var face = new Facebook();
        face.EnviarMensagem("@Vitoria_Sousa", mensagem);
        break;

    default:
        Console.WriteLine("Canal inválido!");
        break;
}
