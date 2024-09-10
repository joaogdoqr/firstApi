namespace FirstApi.Entities
{
    public class Smartphone : Device
    {
        public override string GetModel()
        {
            var isConnected = IsConnected();

            if (isConnected)
                return "Apple";

            return "Unknow";
        }
    }
}
