namespace ICG_Test2.Part2___CodingExercises.Item1;

public class LogAnalyzer
{
    public static void Analyze()
    {
        string filePath = "A:\\src\\Rider\\ICG-Test2\\ICG-Test2\\Part2 - CodingExercises\\Item1\\access.log";

        int infoCount = 0;
        int warnCount = 0;
        int errorCount = 0;

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            foreach (var line in File.ReadLines(filePath)) 
            {
                if (!line.Contains(" "))
                    continue;

                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 2)
                    continue;

                string level = parts[1];

                switch (level)
                {
                    case "INFO":
                        infoCount++;
                        break;
                    case "WARN":
                        warnCount++;
                        break;
                    case "ERROR":
                        errorCount++;
                        break;
                }
            }

            Console.WriteLine("Log Level Summary:");
            Console.WriteLine($"- INFO: {infoCount}");
            Console.WriteLine($"- WARN: {warnCount}");
            Console.WriteLine($"- ERROR: {errorCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }
}