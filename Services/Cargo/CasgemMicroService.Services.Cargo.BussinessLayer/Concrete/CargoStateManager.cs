﻿using CasgemMicroService.Services.Cargo.BussinessLayer.Abstract;
using CasgemMicroService.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroService.Services.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Cargo.BussinessLayer.Concrete
{
    public class CargoStateManager : ICargoStateService
    {
        private readonly ICargoStateDal _cargoStateDal;

        public CargoStateManager(ICargoStateDal cargoStateDal)
        {
            _cargoStateDal = cargoStateDal;
        }

        public void Delete(CargoState entity)
        {
            _cargoStateDal.Delete(entity);
        }

        public List<CargoState> GetAll()
        {
            return _cargoStateDal.GetAll();
        }

        public CargoState GetById(int id)
        {
           return _cargoStateDal.GetById(id);
        }

        public void Insert(CargoState entity)
        {
            _cargoStateDal.Insert(entity);
        }

        public void Update(CargoState entity)
        {
            _cargoStateDal.Update(entity);
        }
    }
}
