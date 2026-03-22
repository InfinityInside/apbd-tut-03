using System.Drawing;
using apbd_tut_03.Equipment;
using apbd_tut_03.SystemUser;

namespace apbd_tut_03;

public class Program
{
    public static void Main(string[] args)
    {
        var user1 = new Student("John", "Snow");
        var user2 = new Student("Robert", "Stark");
        var user3 = new Employee("Robert2", "Stark2");

        var camera1 = new Camera("nikon", Color.AliceBlue, 10, true);
        var camera2 = new Camera("otherCamera", Color.Red, 9, true);
        var laptop1 = new Laptop("mac", Color.Black, "M2", "rtx2080");
        var laptop2 = new Laptop("macX", Color.DarkGoldenrod, "MX", "rtx6090");
        var projector1 = new Projector("cool", Color.Gray, 1000, "4:3");
        var projector2 = new Projector("cool2", Color.Gray, 1100, "16:9");
        
        
        var rs = new RentalService();
        rs.AddUser(user1);
        rs.AddUser(user2);
        rs.AddUser(user3);
        
        rs.AddEquipment(camera1);
        rs.AddEquipment(laptop1);
        rs.AddEquipment(projector1);
        rs.AddEquipment(camera2);
        rs.AddEquipment(laptop2);
        rs.AddEquipment(projector2);
        
        rs.DisplayAllEquipment();
        Console.WriteLine("============================================================");
        
        rs.RentToUser(user1, camera1, TimeSpan.FromDays(4)); 
        rs.RentToUser(user2, camera1, TimeSpan.FromDays(4)); // example of unavailable equipment
        rs.RentToUser(user1, camera2, TimeSpan.FromDays(1)); 
        rs.RentToUser(user1, laptop1, TimeSpan.FromDays(4)); // example of rentals number limit
        rs.RentToUser(user2, laptop1, TimeSpan.FromDays(4));
        Console.WriteLine("============================================================");
        
        
        rs.DisplayAvailableEquipment();
        Console.WriteLine("============================================================");
        
        
        rs.RentToUser(user3, laptop2, TimeSpan.FromDays(4));
        rs.RentToUser(user3, projector1, TimeSpan.FromDays(-2)); // For testing purposes
        rs.RentToUser(user3, projector2, TimeSpan.FromDays(-1)); // For testing purposes
        Console.WriteLine("============================================================");


        rs.ReturnEquipment(camera1);
        rs.ReturnEquipment(projector1);
        Console.WriteLine("============================================================");
        
        rs.DisplayUserRentals(user1);
        Console.WriteLine("============================================================");
        
        rs.DisplayOverdueRentals();
        Console.WriteLine("============================================================");

        rs.GenerateShortSummary();
        Console.WriteLine("============================================================");


    }
}