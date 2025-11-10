public class Facebook
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de texto para o usuário {usuario}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de vídeo para o usuário {usuario}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de foto para o usuário {usuario}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de arquivo para o usuário {usuario}");
    }
}