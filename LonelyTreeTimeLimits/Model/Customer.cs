﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Model
{
    internal class Customer : Entity, ICustomer
    {
        public CustomerType CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Skype { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }

        public Customer(ICustomer iCustomer)
        {
            Id = iCustomer.Id;
            Deleted = iCustomer.Deleted;
            LastUpdated = iCustomer.LastUpdated;

            BirthDate = iCustomer.BirthDate;
            Comment = iCustomer.Comment;
            Country = iCustomer.Country;
            CreatedDate = iCustomer.CreatedDate;
            CustomerType = iCustomer.CustomerType;
            Email = iCustomer.Email;
            FirstName = iCustomer.FirstName;
            LastName = iCustomer.LastName;
            PhoneNumber = iCustomer.PhoneNumber;
            Skype = iCustomer.Skype;
        }

        public Customer()
        { }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
