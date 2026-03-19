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

    public void RentToUser()
    {
        
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