

using Tutorial4.DataBase;

namespace Tutorial4;

public class Visits
{
  
    public Animal Animal { get; set; }
    public DateTime DateTime { get; set; }
    public int Price { get; set; }
    public string Desription { get; set;}
    
    public Visits(Animal animal, DateTime dateTime, int price, string desription)
    {
        Animal = animal;
        DateTime = dateTime;
        Price = price;
        Desription = desription;
        //VisitsList.Add(this);
    }
    
    public static List<Visits> VisitsList = new List<Visits>()
    {
        new Visits(StaticData.animals[0], DateTime.Today.AddDays(1), 50, "Routine check-up"),
        new Visits(StaticData.animals[1], DateTime.Today.AddDays(2), 30, "Vaccination"),
        new Visits(StaticData.animals[2], DateTime.Today.AddDays(3), 40, "General Consultation"),
        new Visits(StaticData.animals[3], DateTime.Today.AddDays(4), 100, "Dental cleaning"),
        new Visits(StaticData.animals[4], DateTime.Today.AddDays(5), 20, "Nail trimming"),
        new Visits(StaticData.animals[5], DateTime.Today.AddDays(6), 50, "Routine check-up"),
        new Visits(StaticData.animals[6], DateTime.Today.AddDays(7), 30, "Vaccination"),
        new Visits(StaticData.animals[7], DateTime.Today.AddDays(8), 40, "General Consultation"),
        new Visits(StaticData.animals[8], DateTime.Today.AddDays(9), 100, "Dental cleaning"),
        new Visits(StaticData.animals[9], DateTime.Today.AddDays(10), 20, "Nail trimming"),
        new Visits(StaticData.animals[10], DateTime.Today.AddDays(11), 50, "Routine check-up"),
        new Visits(StaticData.animals[11], DateTime.Today.AddDays(12), 30, "Vaccination")

    };
    
}