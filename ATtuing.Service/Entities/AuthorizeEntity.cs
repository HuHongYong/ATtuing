﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Entities
{
    public  class AuthorizeEntity
    {
        /// <summary>

        public virtual ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
    }
}