using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Contacts
{
    public static List<Contact> contacts = new List<Contact>() { new Contact("bitzosm@mcmaster.ca"), new Contact("stargirl@gmail.com") };

    public static bool ContainsContact(Contact contact) {
        foreach (Contact i in contacts) {
            if (i.Equals(contact)) {
                return true;
            }
        }
        return false;
    }
}

public class Contact
{
    public string email = "";

    public Contact(string email) {
        this.email = email;
    }

    public override string ToString() {
        return email; 
    }

    public bool Equals(Contact other) {
        return (other.email == email);
    }
    public bool isValid() {
        try {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        } catch {
            return false;
        }
    }
}
