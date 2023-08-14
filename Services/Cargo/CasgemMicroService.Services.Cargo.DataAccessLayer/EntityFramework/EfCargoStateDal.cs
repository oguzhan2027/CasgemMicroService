using CasgemMicroService.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroService.Services.Cargo.DataAccessLayer.Context;
using CasgemMicroService.Services.Cargo.DataAccessLayer.Repository;
using CasgemMicroService.Services.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoStateDal : GenericRepository<CargoState>,ICargoStateDal
    {
        public EfCargoStateDal(CargoContext context) : base(context)
        { 

        }
        
    }
}
