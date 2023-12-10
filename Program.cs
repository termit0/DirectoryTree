if (args.Length != 1)
{
    Console.WriteLine("Usage: DirectoryTree <path>");
    return;
}

var path = args[0];

if (!Directory.Exists(path))
{
    Console.WriteLine($"The path {path} does not exist.");
    return;
}

PrintDirectory(path, "");
return;

static void PrintDirectory(string directoryPath, string indent)
{
    var files = Directory.GetFiles(directoryPath);
    var directories = Directory.GetDirectories(directoryPath);

    for (var i = 0; i < directories.Length; i++)
    {
        var isLastDirectory = i == directories.Length - 1 && files.Length == 0;
        Console.WriteLine($"{indent}├── {Path.GetFileName(directories[i])}/");
        PrintDirectory(directories[i], indent + (isLastDirectory ? "    " : "│   "));
    }

    foreach (var t in files)
    {
        Console.WriteLine($"{indent}├── {Path.GetFileName(t)}");
    }
}