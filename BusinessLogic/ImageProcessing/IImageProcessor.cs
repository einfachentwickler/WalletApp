namespace BusinessLogic.ImageProcessing;

public interface IImageProcessor
{
    public Task<string?> GetImageAsBase64StringAsync();
}