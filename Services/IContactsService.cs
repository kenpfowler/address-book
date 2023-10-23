using address_book.Models;

namespace address_book;

public interface IContactsService
{
    Task<List<Contact>> GetAllContacts();
    Task<Contact> GetOneContact(int id);
    Task<Contact> EditContact(int id);
    Task<Contact> DeleteContact(int id);
    Task CreateContact(Contact contact);
}
