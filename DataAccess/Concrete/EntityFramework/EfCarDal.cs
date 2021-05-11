using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapContext>,ICarDal
    {
       public List<CarDetailDto> GetCarDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors on c.ColorId equals co.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 BrandId = b.Id,
                                 Id = c.Id,
                                 ColorId = co.Id,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
