using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using address_book.Data;
using address_book.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace address_book.Controllers;
public class ContactsController : Controller
{
    private readonly ContactsService _service;

    private readonly ILogger<ContactsController> _logger;

    public ContactsController(ILogger<ContactsController> logger, ContactsService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    async public Task<IActionResult> Index()
    {
        List<Contact> contacts = await _service.GetAllContacts();
        return View(contacts);
    }

    [HttpGet]
    public IActionResult CreateContact()
    {
        Contact contact = new();
        return View(contact);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    async public Task<IActionResult> Create(Contact contact)
    {
        await _service.CreateContact(contact);
        Contact newContact = new();
        return View("CreateContact", newContact);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
