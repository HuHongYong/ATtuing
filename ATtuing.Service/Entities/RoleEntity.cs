﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Entities
{
   public class RoleEntity
    {
        /// <summary>
        /// <summary>
        /// 对应关系
        /// </summary>
        public virtual ICollection<AuthorizeEntity> Authorizes { get; set; } = new List<AuthorizeEntity>();

    }
}