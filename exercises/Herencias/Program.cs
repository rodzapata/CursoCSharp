
using Herencias;

var equipments = new List<Equipment>{
    new AirConditioner(),
    new Refrigerator()
};


foreach (var equipment in equipments)
{
    equipment.PerformMaintenance();
}