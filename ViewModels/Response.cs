namespace jp.tamagotchi.rest.ViewModels
{
    public class Response<T>
    {
        public T Data
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public bool Successful
        {
            get;
            set;
        }
    }
}