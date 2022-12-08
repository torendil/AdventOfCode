namespace AdventOfCode.CommunicationDevice
{
    public class Folder
    {
        public int Size
        {
            get
            {
                return Files.Sum(file => file.Size) + SubFolders.Sum(sub => sub.Size);
            }
        }
        public string Name { get; }

        public List<Folder> SubFolders { get; } = new();
        public List<DeviceFile> Files { get; } = new();
        public Folder? Parent { get; }

        public Folder(string fileName, Folder? parent = null)
        {
            Name = fileName;
            Parent = parent;
        }
    }
}