namespace BusinessLogic.ImageProcessing;

public class ImageProcessor : IImageProcessor
{
    public async Task<string?> GetImageAsBase64StringAsync()
    {
        MemoryStream stream = new();

        try
        {
            await using FileStream fs = File.OpenRead(Environment.CurrentDirectory + "/Assets/icon.webp");

            await fs.CopyToAsync(stream);

            byte[] imageBytes = stream.ToArray();

            return Convert.ToBase64String(imageBytes);
        }
        catch
        {
            return null;
        }
    }
}