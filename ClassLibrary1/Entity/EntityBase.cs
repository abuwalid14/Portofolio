using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Entity
{
    public class EntityBase
    {
        public Guid Id { get; set; }
    }
   public  class Owner : EntityBase
    {
        public string Fullname { get; set; }
        public string Profil { get; set; }

        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }
    public class Portofolio: EntityBase
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

    }

}
