namespace FirstApi.Entities
{
    public abstract class Device
    {
        protected bool IsConnected()
        {
            return true;
        }

        public abstract string GetModel();
    }
}
