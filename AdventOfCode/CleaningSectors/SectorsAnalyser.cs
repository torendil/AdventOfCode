namespace AdventOfCode.CleaningSectors
{
    public class SectorsAnalyser
    {
        private List<CleaningTeam> cleaningTeams = new List<CleaningTeam>();

        public SectorsAnalyser(string input)
        {
            using (var reader = new StringReader(input))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var sectors = new List<Sector>();
                    foreach (var elf in line.Split(','))
                    {
                        var textSectors = elf.Split('-');
                        sectors.Add(new Sector(int.Parse(textSectors.First()), int.Parse(textSectors.Last())));
                    }
                    
                    cleaningTeams.Add(new CleaningTeam(sectors));
                }
            }
        }

        public int NumberOfIncludedSectors()
        {
            return cleaningTeams.Count(team => team.HasOneIncludedSector());
        }

        public int NumberOfOverlappingSectors()
        {
            return cleaningTeams.Count(team => team.HasOneOverlappingSector());
        }
    }
}