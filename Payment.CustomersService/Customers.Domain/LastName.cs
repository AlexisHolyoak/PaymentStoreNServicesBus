﻿using System;
using System.Collections.Generic;
using static System.String;
using UpgFisi.Common.Domain;

namespace Customers.Domain
{
    public class LastName : ValueObject<LastName>
    {
        public virtual string Name { get; private set; }

        public LastName(String _name)
        {
            Name = _name;
        }
        public LastName()
        {            
        }
        public static void CheckValidity(string name)
        {
            if (IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Last Name cannot be empty");
            }

            if (name.Length < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(name), "Last Name cannot be shorter than 10 characters");
            }

            if (name.Length > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(name), "Last Name cannot be longer than 100 characters");
            }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}