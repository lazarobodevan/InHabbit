namespace Api.Model
{
    public class User{
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private DateOnly birthdate { get; set; }
        private string picture { get; set; }
        private List<User> friends { get; set; }
        private List<Task> tasks { get;}
        private Rabbit rabbit { get;}

    }
}