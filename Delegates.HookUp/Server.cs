namespace Delegates.HookUp
{
    public class Server
    {
        public Server(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }
}
