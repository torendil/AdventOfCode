namespace AdventOfCode.CommunicationDevice
{
    public class FileSystemAnalyser
    {
        private readonly Folder root;

        public FileSystemAnalyser(string consoleOutput)
        {
            var parser = new FileSystemParser(consoleOutput);
            root = parser.Root;
        }

        public IEnumerable<Folder> GetFoldersUnder100k(Folder? current = null)
        {
            current ??= root;
            var result = current.SubFolders.Where(sub => sub.Size < 100000);
            foreach(var sub in current.SubFolders)
            {
                result = result.Concat(GetFoldersUnder100k(sub));
            }
            return result;
        }

        public Folder? GetSmallestFolderOver(int aim, Folder? current = null)
        {
            current ??= root;
            var result = current.SubFolders.Where(sub => sub.Size > aim);
            foreach (var sub in result)
            {
                var smallestInSub = GetSmallestFolderOver(aim, sub);
                if (smallestInSub != null)
                {
                    result = result.Append(smallestInSub);
                }
            }
            return result.OrderBy(folder => folder.Size).FirstOrDefault();
        }

        public int GetTotalSize()
        {
            return root.Size;
        }
    }
}