namespace AdventOfCode.CommunicationDevice
{
    public class DisplaySimulator
    {
        private const int NumberOfLinesOnDisplay = 6;
        private const int NumberOfPixelsPerLine = 40;
        readonly List<int> registerValues = new();

        public DisplaySimulator(string input)
        {
            using var reader = new StringReader(input);

            string? line;
            int registerValue = 1;

            while ((line = reader.ReadLine()) != null)
            {
                var splitted = line.Split(' ');
                if (splitted[0] == "noop")
                {
                    registerValues.Add(registerValue);
                }
                else
                {
                    registerValues.Add(registerValue);
                    registerValues.Add(registerValue);
                    registerValue += int.Parse(splitted[1]);
                }
            }
        }

        public int GetSignalStrengthAt(int step)
        {
            return registerValues[step - 1] * step;
        }

        public string GetDisplay()
        {
            List<char> display = new();
            for (int lineNumber = 0; lineNumber < NumberOfLinesOnDisplay; lineNumber++)
            {
                for (int pixelIndex = 0; pixelIndex < NumberOfPixelsPerLine; pixelIndex++)
                {
                    var targetRegister = pixelIndex + 1;
                    if (registerValues[pixelIndex + lineNumber * NumberOfPixelsPerLine] > targetRegister - 3 &&
                        registerValues[pixelIndex + lineNumber * NumberOfPixelsPerLine] <= targetRegister)
                    {
                        display.Add('#');
                    }
                    else
                    {
                        display.Add('.');
                    }
                }
                display.Add('\r');
                display.Add('\n');
            }
            return new string(display.ToArray());
        }
    }
}