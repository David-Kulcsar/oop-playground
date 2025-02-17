﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPlayground.App.Classes
{
    public class Employee : User
    {
        public Employee(string firstName, string lastName)
            :base(firstName, lastName)
        {
            Id = Guid.NewGuid();
        }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        public override string GetFullName()
        {
            return Id.ToString() + " " + FirstName + " " + LastName;
        }

        public static string GetSomeRandomString()
        {
            return "String with some value in it";
        }
    }
}
