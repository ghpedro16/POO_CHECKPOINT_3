// See https://aka.ms/new-console-template for more information
Console.WriteLine("Para qual canal você quer enviar mensagem?");
Console.WriteLine("1. WhatsApp");
Console.WriteLine("2. Telegram");
Console.WriteLine("3. Instagram");
Console.WriteLine("4. Facebook");

int canal = 0;
string resposta = Console.ReadLine();
if (!int.TryParse(resposta, out canal))
{
    Console.WriteLine("Opção inválida");
    return;
}


TextMessage messageBase = new TextMessage("Olá");
VideoMessage video = new VideoMessage("Olá");

switch (canal)
{
    case 1:
        var whats = new WhatsApp();
        whats.EnviarMensagem("12345678", messageBase);
        whats.EnviarMensagem("87654321", video);
        break;

    case 2:
        var telegram = new Telegram();
        telegram.EnviarMensagem("99999999", messageBase);
        telegram.EnviarMensagem("88888888", video);
        break;

    case 3:
        var insta = new Instagram();
        insta.EnviarMensagem("usuario_insta", messageBase);
        insta.EnviarMensagem("usuario_insta", video);
        break;

    case 4:
        var face = new Facebook();
        face.EnviarMensagem("usuario_face", messageBase);
        face.EnviarMensagem("usuario_face", video);
        break;

    default:
        Console.WriteLine("Canal inválido");
        break;
}