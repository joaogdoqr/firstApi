namespace FirstApi.Entities
{
    public class Laptop : Device
    {
        public override string GetModel()
        {
            var isConnected = IsConnected();

            if (isConnected)
                return "Macbook";

            return "Unknow";
        }
    }
}
