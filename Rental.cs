namespace apbd_tut_03;


public class Rental
{
    public SystemUser.SystemUser User { get; set; }
    
    public Equipment.Equipment Equipment { get; set; }
    
    public DateTime RentalDate { get; set; }
    
    public TimeSpan RentalTime { get; set; }
    
    public DateTime ReturnDate { get; set; }

    public Rental(SystemUser.SystemUser user, Equipment.Equipment equipment, DateTime rentalDate, TimeSpan rentalTime)
    {
        User = user;
        Equipment = equipment;
        RentalDate = rentalDate;
        RentalTime = rentalTime;
    }


    public DateTime GetReturnOnTimeDate()
    {
        return RentalDate.Add(RentalTime);
    }

    public bool WasReturnedOnTime()
    {
        return ReturnDate < GetReturnOnTimeDate();
    }
    
    
    
    
    
    
}