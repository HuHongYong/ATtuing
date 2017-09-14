using ATtuing.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Configs
{
   public class RoleConfig: EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfig() {
            this.ToTable("EQ_USER.T_PC_ROLE");
            HasKey(a => a.ID);
            HasMany(r => r.Authorizes).WithMany(a => a.Roles).Map(m => m.ToTable("T_PC_ROLEAUTHORIZE", "EQ_USER").MapLeftKey("ROLEID").MapRightKey("AUTHORIZEID"));
        }
    }
}
