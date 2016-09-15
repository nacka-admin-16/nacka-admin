namespace OOP.Entities
{
    public class Message
    {
        public string Text { get; set; }

        public string ShowMessage()
        {
            return "Hello Carl! " + Text;
        }
    }
}