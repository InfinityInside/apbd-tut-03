using apbd_tut_03.SystemUser;

namespace apbd_tut_03;

public class RentalService
{
    public List<Rental> Rentals = [];
    public List<Equipment.Equipment> Equipments = [];
    public List<SystemUser.SystemUser> Users = [];

    public void AddUser(SystemUser.SystemUser user)
    {
        Users.Add(user);
    }

    public void AddEquipment(Equipment.Equipment equipment)
    {
        Equipments.Add(equipment);
    }

    public void DisplayAllEquipment()
    {
        foreach (var equipment in Equipments)
        {
            equipment.Display();
        }
    }
    
    public void DisplayAvailableEquipment()
    {
        foreach (var equipment in Equipments)
        {
            if (equipment.IsAvailable)
                equipment.Display();
        }
        
    }

    public void RentToUser(SystemUser.SystemUser systemUser, Equipment.Equipment equipment, TimeSpan timeSpan)
    {
        var numOfRentals = Rentals.Count(r => Equals(r.User, systemUser) && r.ReturnDate == null);
        if (numOfRentals >= systemUser.RentalsNumberLimit)
        {
            Console.WriteLine("Limit of the number of rentals exceeded");
            return;
        }

        if (!equipment.IsAvailable)
        {
            Console.WriteLine("The equipment is unavailable");
            return;
        }
        
        
        var rental = new Rental(systemUser, equipment, DateTime.Now, timeSpan);
        equipment.IsAvailable = false;
        Rentals.Add(rental);

    }

    public void ReturnEquipment(Equipment.Equipment equipment)
    {
        var rental = Rentals.FirstOrDefault(r => r.ReturnDate == null && Equals(r.Equipment, equipment));
        if (rental == null)
            return;
        rental.ReturnDate = DateTime.Now;
        if (!rental.WasReturnedOnTime())
        {
            var numOfDays = (rental.ReturnDate - rental.GetReturnOnTimeDate()).Value.Days;
            Console.WriteLine($"The deadline was missed by {numOfDays} days, the penalty fees are: {numOfDays * equipment.PerDayFee}");
        }

        equipment.IsAvailable = true;
    }

    public void ChangeEquipmentAvailability(Equipment.Equipment equipment, bool isAvailable)
    {
        equipment.IsAvailable = isAvailable;
    }

    public void DisplayUserRentals(SystemUser.SystemUser user)
    {
        foreach (var rental in Rentals.Where(r => Equals(r.User, user) && r.ReturnDate == null))
        {
            rental.Display();
        }
    }

    public void DisplayOverdueRentals()
    {
        foreach (var rental in Rentals.Where(r => r.GetReturnOnTimeDate() < DateTime.Now))
        {
            rental.Display();
        }
    }

    public void GenerateShortSummary()
    {
        Console.WriteLine($"Users: {string.Join(", ", Users)}");
        Console.WriteLine($"Equipment: {string.Join(", ", Equipments)}");
        Console.WriteLine($"Rentals: {string.Join(", ", Rentals)}");
        
    }
    
}