using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal: EfEntityRepositoryBase<CarImage,ReCapContext>,ICarImageDal
    {
    }
}
