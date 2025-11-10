public class Instagram
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de texto para o usuário {usuario}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de vídeo para o usuário {usuario}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de foto para o usuário {usuario}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de arquivo para o usuário {usuario}");
    }
}