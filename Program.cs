using System.Drawing;
using apbd_tut_03.Equipment;
using apbd_tut_03.SystemUser;

namespace apbd_tut_03;

public class Program
{
    public static void Main(string[] args)
    {
        var user1 = new Employee("John", "Snow");
        var user2 = new Student("Robert", "Stark");

        var camera1 = new Camera("nikon", Color.AliceBlue, 10, true);
        var laptop1 = new Laptop("mac", Color.Black, "M2", "rtx2080");
        var projector1 = new Projector("cool", Color.Gray, 1000, "16:9");
        
        
        var rs = new RentalService();
        rs.AddUser(user1);
        rs.AddUser(user2);
        
        rs.AddEquipment(camera1);
        rs.AddEquipment(laptop1);
        rs.AddEquipment(projector1);
        
        rs.DisplayAllEquipment();
        rs.DisplayAvailableEquipment();
        
        rs.RentToUser(user1, camera1, TimeSpan.FromDays(4)); // check limits
        rs.RentToUser(user2, camera1, TimeSpan.FromDays(4));
        rs.RentToUser(user2, laptop1, TimeSpan.Zero);
        rs.ReturnEquipment();
        
        rs.ChangeEquipmentAvailability();
        
        rs.DisplayUserRentals(user1);
        
        rs.DisplayOverdueRentals();

        rs.GenerateShortSummary();


    }
}