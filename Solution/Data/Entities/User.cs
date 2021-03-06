﻿namespace Data.Entities
{
    #region Using

    using System;
    using System.Collections.Generic;

    #endregion

    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
