﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.DesafioS9.Entities
{
    class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Cliente() { }

        public Cliente(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            BirthDate = birthdate;

        }


    }   
}