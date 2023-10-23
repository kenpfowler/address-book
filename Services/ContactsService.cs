using address_book.Data;
using address_book.Models;
using Microsoft.EntityFrameworkCore;

namespace address_book;

public class ContactsService : IContactsService
{

    private readonly ApplicationDbContext _context;
    private readonly IImageService _imageService;

    public ContactsService(ApplicationDbContext context, IImageService imageService)
    {
        _context = context;
        _imageService = imageService;
    }

    async public Task CreateContact(Contact contact)
    {
        byte[] bytes = await _imageService.ConvertFileToByteArrayAsync(contact.ImageFile);
        contact.ImageData = bytes;
        contact.ImageType = contact.ImageFile.ContentType;
        await _context.Contacts.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

    public Task<Contact> DeleteContact(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> EditContact(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Contact>> GetAllContacts()
    {
        List<Contact> contacts = await _context.Contacts.ToListAsync();
        return contacts;
    }

    public Task<Contact> GetOneContact(int id)
    {
        throw new NotImplementedException();
    }



}
