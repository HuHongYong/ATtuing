using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ATtuing.Service.Entities;

namespace ATtuing.Service.ModelConfig
{
    public class EQEventConfig: EntityTypeConfiguration<EQEventEntity>
    {
        public EQEventConfig()
        {
            ToTable("EQ_USER.T_DATA_EQEVENT");
            HasKey(e=>e.EQID);
        }
    }
}