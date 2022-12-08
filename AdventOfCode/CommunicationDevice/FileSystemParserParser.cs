namespace AdventOfCode.CommunicationDevice
{
    internal class FileSystemParser
    {
        internal Folder Root { get; } = new("/");

        public FileSystemParser(string input)
        {
            Parse(input);
        }

        public void Parse(string input)
        {
            using var reader = new StringReader(input);

            // manage root
            string? line = reader.ReadLine();
            Folder current = Root;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("$ cd .."))
                {
                    current = GetParent(current);
                }
                else
                {
                    if (line.StartsWith("$ cd"))
                    {
                        current = AccessChildThroughCommand(line, current);
                    }

                    if (line.StartsWith("$ ls"))
                    {
                        ReadFolderContent(current, reader);
                    }
                }
            }
        }

        private static Folder GetParent(Folder current)
        {
            if (current.Parent == null)
            {
                throw new Exception("Should never go higher than root");
            }
            return current.Parent;
        }

        private static Folder AccessChildThroughCommand(string line, Folder current)
        {
            var folderName = line["$ cd ".Length..];
            return current.SubFolders.First(sub => sub.Name == folderName);
        }

        private static void ReadFolderContent(Folder current, StringReader reader)
        {
            while (reader.Peek() != '$' && reader.Peek() != -1)
            {
                string? line = reader.ReadLine();
                if (line == null)
                {
                    throw new Exception("Line should never be null here");
                }
                if (line.StartsWith("dir "))
                {
                    current.SubFolders.Add(new Folder(line["dir ".Length..], current));
                }
                else
                {
                    var fileDef = line.Split(' ');
                    current.Files.Add(new DeviceFile(fileDef[1], int.Parse(fileDef[0])));
                }
            }
        }
    }
}
