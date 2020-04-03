namespace Poster
{
    public interface IMessageSender
    {
        void Send<TMessage>(TMessage message);

        void SendInheritance<TMessage>(TMessage message);
    }
}