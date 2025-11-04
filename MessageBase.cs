public abstract class MessageBase{

    protected MessageBase(string message){
        Message = message;
        SendAt = DateTime.now;
    }

    public string Message {get;}
    
    public DateTime SendAt {get;}
}