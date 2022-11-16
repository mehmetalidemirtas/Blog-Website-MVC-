﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repoContact = new Repository<Contact>();
        Repository<Address> repoAdress = new Repository<Address>();
        public int BLLContactAdd(Contact c)
        {
            if(c.Mail==""|| c.Message==""|| c.Name==""||c.Subject==""||c.Surname==""||c.Subject.Length>=51)
            {
                return -1;
            }
            c.ContactStatus=true;
            return repoContact.Insert(c);
        }
        public List<Contact> GetAll()
        {
            return repoContact.List();
        }
        public List<Address> GetAddress()
        {
            return repoAdress.List();
        }
        public Contact GetContactDetails(int id)
        {
            return repoContact.Find(x => x.ContactID == id);
        }
        public int DeleteMessageBLL(int p)
        {
            Contact contact = repoContact.Find(x => x.ContactID == p);
            return repoContact.Delete(contact);
        }
        public List<Contact> ContactByStatusTrue()
        {
            return repoContact.List(x => x.ContactStatus == true);
        }
        public List<Contact> ContactByStatusFalse()
        {
            return repoContact.List(x => x.ContactStatus == false);
        }
        public int StatusChangeToFalseBLL(int id)
        {
            Contact contact = repoContact.Find(x => x.ContactID == id);
            contact.ContactStatus = false;
            return repoContact.Update(contact);
        }


        public List<Address> GetAllAdress()
        {
            return repoAdress.List();
        }
        public int updateAddress(Address p)
        {
            Address address = repoAdress.Find(x => x.AddressID == p.AddressID);
            address.Email = p.Email;
            address.Phone = p.Phone;
            address.FullAddress = p.FullAddress;
            address.AddressURL = p.AddressURL;
            return repoAdress.Update(address);

        }
    }
}
