using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal  _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            //_rentalDal.Add(rental);
            //return new SuccessResult(Messages.Success);
            var result = _rentalDal.GetAll(c => (c.CarId == rental.CarId) && !(c.RentDate == null && c.ReturnDate == null) && (c.ReturnDate == null)).ToList();
            if (result.Count == 0)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);

            }
            else
            {
                return new ErrorResult(Messages.RentalFailures);
            }
        }

        public IResult Delete(Rental rental)
        {
            if (rental.Id < 5000)
            {
                _rentalDal.Delete(rental);
                Console.WriteLine((Messages.RentalDeleted));
            }
            
                return new ErrorResult(Messages.RentalFailures);
            
            
            
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Success);
        }

        public IDataResult<Rental> GetRental(DateTime returnDate)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.ReturnDate == returnDate), Messages.Success);
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.CarId == id), Messages.Success);
        }
    }
}
