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
    public class EfCargoDetailDal : GenericRepository<CargoDetail>,ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext context):base(context) 
        { 

        }
        
    }
}
