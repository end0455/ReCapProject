﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, Description="Peugeot 301", ModelYear=2020},
                new Car {CarId = 2, BrandId = 2, ColorId = 5, DailyPrice = 500, Description="Renault Symbol", ModelYear=2017},
                new Car {CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 2000, Description="Hyundai I10", ModelYear=2021},
                new Car {CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = 300, Description="Opel Corsa", ModelYear=2010},
                new Car {CarId = 5, BrandId = 4, ColorId = 1, DailyPrice = 600, Description="Renault Clio", ModelYear=2018},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId, int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId && p.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
