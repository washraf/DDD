﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Security;

namespace Site.DomainEntities.Model
{
    public class User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; protected set; }
        public string LoginId { protected set; get; }
        protected string PasswordStored
        {
            get;
            set;
        }

        public void SetPassword(string nPassword)
        {
            PasswordStored = Hashing.CreateMD5(nPassword);
        }
        public bool IsCorrectPassword(string password)
        {
            return Hashing.CreateMD5(PasswordStored).Equals(PasswordStored);
        }
        public virtual ICollection<SystemPrivilage> CurrentPrivilages { set; get; }

        //public string Name { set; get; }
        //public string Email { set; get; }
        //public DateTime BirthDate { get; set; }
        //public string Phone { get; set; }
        //public string Address { get; set; }

    }
}
