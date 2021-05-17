using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAllRentals();
        IDataResult<List<Rental>> GetRentalsByCarId(int id);
        IDataResult<Rental> GetRental(DateTime returnDate);

    }
}
