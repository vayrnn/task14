using LibraryA;

namespace LibraryB
{
    public class ServiceB
    {
        public string GetMessage() => Utility.GetMessage() + " via LibraryB";
    }
}
