
using Lesson9;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;

const string ARCHIVE_NAME = "data.zip";
const string EXTRACT_NAME = "extraction";
const string FILE_NAME = "FILE";
const string INFO = "info.csv";
const string HOME_WORK = "Lesson12Homework.txt";

var directory = Directory.CreateDirectory("i_will_be_archive");
File.Delete(Path.Combine(directory.FullName, FILE_NAME));
File.WriteAllText(FILE_NAME, "Hello, World!");
File.Move(FILE_NAME, Path.Combine(directory.FullName, FILE_NAME));
File.Delete(ARCHIVE_NAME);
ZipFile.CreateFromDirectory(directory.FullName, ARCHIVE_NAME);
if (Directory.Exists(EXTRACT_NAME))
{
    Directory.Delete(EXTRACT_NAME,true);
}
var directoryInfo = Directory.CreateDirectory(EXTRACT_NAME);
ZipFile.ExtractToDirectory(ARCHIVE_NAME, EXTRACT_NAME);
var files = directoryInfo.GetFiles();
var directories = directoryInfo.GetDirectories();
var contentList = new List<Content>();
foreach (var d in directories)
{
    var content = new Content(ContentType.Directory, d.Name, d.CreationTime);
    contentList.Add(content);
}
foreach (var file in files)
{
    var content = new Content(ContentType.File, file.Name, file.CreationTime);
    contentList.Add(content);
}

using (var writer= new StreamWriter(INFO, false))
{
    foreach (var content in contentList)
    {
        writer.WriteLine($"{content.Type}\t{content.Name}\t{content.LastModified}");
    }
}
if (Directory.Exists(EXTRACT_NAME))
{
    Directory.Delete(EXTRACT_NAME,true);
}
var appdata = Environment.GetFolderPath(
    Environment.SpecialFolder.ApplicationData);
using (var writer = new StreamWriter(Path.Combine(appdata , HOME_WORK), false))
{
    var pathToInfo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),INFO);
    writer.WriteLine(pathToInfo);
}