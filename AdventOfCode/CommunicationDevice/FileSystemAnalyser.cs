namespace AdventOfCode.CommunicationDevice
{
    public class FileSystemAnalyser
    {
        private readonly Folder root = new("/");

        public FileSystemAnalyser(string consoleOutput)
        {
            using var reader = new StringReader(consoleOutput);

            // manage root
            string? line = reader.ReadLine();
            Folder current = root;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("$ cd .."))
                {
                    if(current.Parent == null)
                    {
                        throw new Exception("Should never go higher than root");
                    }
                    current = current.Parent;
                }
                else
                {
                    if (line.StartsWith("$ cd"))
                    {
                        var folderName = line["$ cd ".Length..];
                        current = current.SubFolders.First(sub => sub.Name == folderName);
                    }

                    if (line.StartsWith("$ ls"))
                    {
                        ReadFolderContent(current, reader);
                    }
                }
            }
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

        private Folder? FindSubDir(Folder currentFolder, string folderName)
        {
            if (currentFolder.Name == folderName)
            {
                return currentFolder;
            }

            foreach (var sub in currentFolder.SubFolders)
            {
                var result = FindSubDir(sub, folderName);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        public IEnumerable<Folder> GetFoldersUnder100k(Folder? current = null)
        {
            if(current == null)
            {
                current = root;
            }
            var result = current.SubFolders.Where(sub => sub.Size < 100000);
            foreach(var sub in current.SubFolders)
            {
                result = result.Concat(GetFoldersUnder100k(sub));
            }
            return result;
        }
    }
}