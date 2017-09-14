using ATtuing.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Configs
{
    class AuthorizeConfig:EntityTypeConfiguration<AuthorizeEntity>
    {
        public AuthorizeConfig() {
            this.ToTable("EQ_USER.T_PC_AUTHORIZE");
            HasKey(a => a.ID);
        }
    }
}
