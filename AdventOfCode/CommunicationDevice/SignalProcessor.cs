namespace AdventOfCode.CommunicationDevice;

public class SignalProcessor
{
    private const int startOfPacketBufferSize = 4;
    private const int startOfMessagesBufferSize = 14;
    private readonly string feed;

    public SignalProcessor(string feed)
    {
        this.feed = feed;
    }

    private int GetMarkerLocation(int bufferSize)
    {
        using var reader = new StringReader(feed);

        var buffer = new Queue<char>(bufferSize + 1);
        int currentCharAsInt;

        int position = 0;

        while ((currentCharAsInt = reader.Read()) != -1)
        {
            position++;
            ChangeBuffer(buffer, currentCharAsInt, bufferSize);
            
            if (buffer.Distinct().Count() == bufferSize)
            {
                return position;
            }
        }

        return -1;
    }

    private static void ChangeBuffer(Queue<char> buffer, int currentCharAsInt, int bufferSize)
    {
        buffer.Enqueue((char)currentCharAsInt);
        if (buffer.Count > bufferSize)
        {
            buffer.Dequeue();
        }
    }

    public int GetStartOfPacketMarkerLocation()
    {
        return GetMarkerLocation(startOfPacketBufferSize);
    }

    public int GetStartOfMessageMarkerLocation()
    {
        return GetMarkerLocation(startOfMessagesBufferSize);
    }
}