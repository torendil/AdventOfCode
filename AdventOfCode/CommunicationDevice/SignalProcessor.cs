namespace AdventOfCode
{
    public class SignalProcessor
    {
        private const int bufferSize = 4;
        private readonly string feed;

        public SignalProcessor(string feed)
        {
            this.feed = feed;
        }

        public int GetMarkerLocation()
        {
            using var reader = new StringReader(feed);

            var buffer = new Queue<char>(bufferSize + 1);
            int currentCharAsInt;

            int position = 0;

            while ((currentCharAsInt = reader.Read()) != -1)
            {
                position++;
                ChangeBuffer(buffer, currentCharAsInt);
                
                if (buffer.Distinct().Count() == 4)
                {
                    return position;
                }
            }

            return -1;
        }

        private static void ChangeBuffer(Queue<char> buffer, int currentCharAsInt)
        {
            buffer.Enqueue((char)currentCharAsInt);
            if (buffer.Count > bufferSize)
            {
                buffer.Dequeue();
            }
        }
    }
}