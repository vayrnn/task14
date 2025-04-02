touch ServiceC.cs
code ServiceC.cs

using LibraryA;

namespace LibraryC
{
    public class ServiceC
    {
        public string GetMessage() => Utility.GetMessage() + " via LibraryC";
    }
}
