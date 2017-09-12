using ATtuing.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Configs
{
    class EQEventTaskConfig: EntityTypeConfiguration<EQEventTaskEntity>
    {
        public EQEventTaskConfig()
        {
            ToTable("EQ_USER.T_DATA_EQEVENT_TASK");
            HasKey(e => e.TASKID);
        }
    }
}
