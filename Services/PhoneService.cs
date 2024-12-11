using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class PhoneService
{
    private List<Phone> _phones;

    public PhoneService()
    {
        _phones = new List<Phone>();
    }

    public Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();
        _phones.Add(phone);
        
        return phone;
    }

    public Phone GetPhoneById(Guid id)
    {
        foreach (var phone in _phones)
        {
            if (phone.Id == id)
            {
                return phone;
            }
        }
        
        return null;
    }

    public bool UpdatePhone(Phone phone)
    {
        var phoneFromDb = GetPhoneById(phone.Id);

        if (phone.Id == null)
        {
            return false;
        }
        
        var index = _phones.IndexOf(phoneFromDb);
        _phones[index] = phone;
        return true;
        
    }

    public bool DeletePhone(Phone phone)
    {
        var phoneFromDb = GetPhoneById(phone.Id);

        if (phone.Id == null)
        {
            return false;
        }
        
        _phones.Remove(phoneFromDb);
        return true;
    }

    public List<Phone> GetAllPhones()
    {
        return _phones;
    }
    
    
}