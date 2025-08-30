namespace WorkerService
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public string GetName(int id)
        {
            switch (id)
            {
                case 0:
                    Name = "me";
                    break;
                case 1:
                    Name = "you";
                    break;
                default:
                    break;
            }
            return Name;
        }
    }
}
