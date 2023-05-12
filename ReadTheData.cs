using System.Text.Json;
namespace InventoryManagement
{
    public class ReadTheData
    {
        public InventoryDetails Read(string path)
        {

            using (StreamReader file=new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonSerializer.Deserialize<InventoryDetails>(json);

                } catch(Exception e)
                {
                    
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}