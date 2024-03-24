var HOME_WORK = "Lesson12Homework.txt";
var appdata = Environment.GetFolderPath(
    Environment.SpecialFolder.ApplicationData);
var contentList = new List<Lesson9.Content>();
using (var reader = new StreamReader(Path.Combine(appdata, HOME_WORK), false))
{
    var filepath = reader.ReadToEnd().Replace("\n", "").Replace("\r", "");
    using (var infoReader = new StreamReader(filepath, false))
    {
        string line = infoReader.ReadLine();
        while (line  != null)
        {
            string[] values = line.Split('\t');
            Lesson9.ContentType type;
            if (values[0] == "File")
            {
                type = Lesson9.ContentType.File;
            }
            else
            {
                type = Lesson9.ContentType.Directory;
            }
            contentList.Add(new Lesson9.Content(type, values[1], DateTime.Parse(values[2])));
            line = infoReader.ReadLine();
        }
    }
}
contentList.Sort((content1, content2) => content1.LastModified.CompareTo(content2.LastModified));
foreach (var content in contentList)
{
    Console.WriteLine($"{content.Name}\t{content.Type}\t{content.LastModified}");
}
