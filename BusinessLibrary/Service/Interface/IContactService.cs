using BusinessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Service.Interface
{
    public interface IContactService
    {
        Task<List<ContactModel>> GetContacts();
        Task<bool> SaveContact(ContactModel contactModel);
        Task<bool> DeleteContact(int contactId);
    }
}
