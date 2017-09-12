using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATtuing.Dto;
using AutoMapper.QueryableExtensions;

namespace ATtuing.Service
{
    public class EQEventService : IEQEventService
    {
        public EQEventDto GetById()
        {
            using (MyDbContext ctx=new MyDbContext())
            {
               return ctx.EQEvents.ProjectTo<EQEventDto>().SingleOrDefault(e=>e.EQId== "20150109121037");
            }
        }
        public EQEventDto GetByIdSql() {
            using (MyDbContext ctx = new MyDbContext())
            {
               var xx= ctx.Database.SqlQuery<Temp>(@"select id, modid from T_DATA_EQMOD WHERE ID IN(select distinct t.mbid
                                  from t_data_eqmod_bookmark t
                                 where t.sqid in
                                       (select t.sqid
                                          from t_data_ext_bookmark t
                                         where t.gzid in
                                               (select t.ruleid from t_data_rule t where t.mxid = {0})))
                                 ", "baeee57e-56e7-4f8a-b579-66e8b2642490").ToList();
                return ctx.EQEvents.ProjectTo<EQEventDto>().SingleOrDefault(e => e.EQId == "20150109121037");
            }
        }
    }
    class Temp {
        public string id { get; set; }
        public decimal modid { get; set; }
    }
}
