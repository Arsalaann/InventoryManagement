namespace InventoryManagement
{
    public class InventoryDetails
    {
        public List<TypesOfRice> typesOfRice=new List<TypesOfRice>();
    }

    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }
}