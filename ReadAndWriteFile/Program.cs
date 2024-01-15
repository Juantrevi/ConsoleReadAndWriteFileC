var replacements = new Dictionary<string, string>
{
    { "Ireland", "---IRELAND---" },
    { " it ", " -----IT---- " },
    { " is ", " -----IS---- " }
};

const string fileNameRead = @"C:\Users\juant\OneDrive\Escritorio\Dorset\7 - OOP\ReadAndWriteFile\ReadAndWriteFile\ireland-read.txt";
const string fileNameWrite = @"C:\Users\juant\OneDrive\Escritorio\Dorset\7 - OOP\ReadAndWriteFile\ReadAndWriteFile\ireland-write.txt";

try
{
    var reader = new StreamReader(fileNameRead);
    var writer = new StreamWriter(fileNameWrite, false);
    
    Console.WriteLine();
    Console.WriteLine("--------------------------------- Reading from ireland-read.txt---------------------------------");
    Console.WriteLine();
    
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        Console.WriteLine(line);
        
    foreach (var replacement in replacements)
    {
        line = line.Replace(replacement.Key, replacement.Value);
    }
        writer.WriteLine(line);
    }
    
    reader.Close();
    writer.Close();
    
    var readerWriter = new StreamReader(fileNameWrite);
    
    Console.WriteLine();    
    Console.WriteLine("--------------------------------- Reading from ireland-write.txt---------------------------------");
    Console.WriteLine();
    
    while (!readerWriter.EndOfStream)
    {
        var line = readerWriter.ReadLine();
        Console.WriteLine(line);
    }
    
    readerWriter.Close();
    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finally block");
}