﻿using System;

namespace SF.Modul_14_3_3
{
    /// <summary>
    /// Класс Контакт
    /// </summary>
    public class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
