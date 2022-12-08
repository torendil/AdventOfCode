namespace AdventOfCode.CommunicationDevice
{
    public class DeviceFile
    {
        public string Name { get; }
        public int Size { get; }

        public DeviceFile(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}