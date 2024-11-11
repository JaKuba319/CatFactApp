namespace CatFactApp.Services
{
    public class FileService : IFileService
    {
        public async Task Write(string path, string content)
        {
            using StreamWriter writer = File.AppendText(path);
            await writer.WriteLineAsync(content);

        }
    }
}
