namespace address_book;

public interface IImageService
{
    public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
    public string ConvertByteArrayToFile(byte[] fileData, string extension);
}
