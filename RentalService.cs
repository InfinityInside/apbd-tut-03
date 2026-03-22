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
        var numOfRentals = Rentals.Count(r => Equals(r.User, systemUser) && r.ReturnDate != null);
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
        Rentals.Add(rental);

    }

    public void ReturnEquipment()
    {
        
        
    }

    public void ChangeEquipmentAvailability()
    {
        
    }

    public void DisplayUserRentals(SystemUser.SystemUser user)
    {
        foreach (var rental in Rentals.Where(r => Equals(r.User, user) && r.ReturnDate != null))
        {
            rental.Display();
        }
    }

    public void DisplayOverdueRentals()
    {
        
    }

    public string GenerateShortSummary()
    {
        return "";
    }
    
}