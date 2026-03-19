using apbd_tut_03.Equipment;
using apbd_tut_03.SystemUser;

namespace apbd_tut_03;

public class Program
{
    public static void Main(string[] args)
    {
        var user1 = new Employee("John", "Snow");
        var user2 = new Student("Robert", "Stark");

        var camera1 = new Camera("nikon");
        var laptop1 = new Laptop("mac");
        var projector1 = new Projector("cool");
        
        var rs = new RentalService();
        rs.AddUser(user1);
        rs.AddUser(user2);
        
        rs.AddEquipment(camera1);
        rs.AddEquipment(laptop1);
        rs.AddEquipment(projector1);
        
        rs.DisplayAllEquipment();
        rs.DisplayAvailableEquipment();
        
        rs.RentToUser();
        rs.ReturnEquipment();
        
        rs.ChangeEquipmentAvailability();
        
        rs.DisplayUserRentals();
        
        rs.DisplayOverdueRentals();
        
        rs.GenerateShortSummary()
        

    }
}