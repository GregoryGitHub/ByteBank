

namespace ByteBank.Systems
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
        string getName();
        void setName(string name);
    }
}
