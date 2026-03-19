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
    // TODO move isAvailable from equipment to method here

    public void RentToUser(SystemUser.SystemUser systemUser, Equipment.Equipment equipment, TimeSpan timeSpan)
    {
        int numOfRentals = Rentals.FindAll((r => r.User == systemUser)).Count();
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
        
    }

    public void DisplayOverdueRentals()
    {
        
    }

    public string GenerateShortSummary()
    {
        return "";
    }
    
}