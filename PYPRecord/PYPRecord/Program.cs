#region Record
//var class1 = new Class1();
//class1.Id = 1;
//class1.Name = "ad";

//Console.WriteLine(class1.Name);
//class1.Name = "Soyad";

//Console.WriteLine(class1.Name);

//var class2 = new Class1 { Id = 1, Name = "ad" };





//var record1 = new Record1 { Id=1,Name = "ad",Surname="Eliyev"};
//var record2 = new Record1 { Id = 1, Name = "ad" ,Surname ="Eliyev"};

////var record3 = new Record1 { Id = record2.Id, Name = record2.Name, Surname = "Veliyev" };

//var record4 = record2 with { Surname = "Balayev" };



//Console.WriteLine(class1 == class2);
//Console.WriteLine(ReferenceEquals(record2 , record1));

//Console.WriteLine(class1);
//Console.WriteLine(record1);


//public class Class1
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}



//public record Record1
//{
//    public int Id { get; init; }
//    public string Name { get; init; }
//    public string Surname { get; init; }
//}

//public record Record2(int Id,string Name,string Surname);
#endregion
#region ClassTask


#region ClassTask 2

//CustomRecord customRecord = new CustomRecord(1, "Veli");

////customRecord.Id = 5;
//Console.WriteLine(customRecord);


//public class CustomRecord
//{
//    //public int Id { get; init; }
//    //public string Name { get; init; }
//    public int Id { get; }
//    public string Name { get; }

//    public CustomRecord()
//    {

//    }
//    public CustomRecord(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }


//    public override string ToString()
//    {
//        return $"Recorname = {GetType().Name} --Id = {Id} -- Name = {Name}";
//    }
//}
#endregion


#endregion

using PYPRecord;

Room room1 = new Room("100", 10, 5);
//Console.WriteLine(Room.Counter);
Room room2 = new Room("200", 10, 5);
Room room3 = new Room("300", 10, 5);
//Console.WriteLine(Room.Counter);

Hotel hotel1 = new Hotel("Sun");
Hotel hotel2 = new Hotel("Moon");

hotel1.AddRoom(room1);
hotel1.AddRoom(room2);
hotel2.AddRoom(room3);

foreach (var item in hotel1.GetRooms())
{
    Console.WriteLine(item);
}


try
{
    hotel1.MakeReservation(25);

}
catch(NotAvailableException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}