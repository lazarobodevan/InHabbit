namespace Api.Model {
    public class Task {
        private int iD { get; set; }
        private string name { get; set; }
        private string picture { get; set; }
        private PriorityType priority { get; set; }
        private DateOnly date { get;set; }
        private TimeOnly begin { get; set; }
        private TimeOnly end { get; set; }
        private StatusType status { get; set; }
        private int reward { get; set; }
        private DateTime finishDate { get; set; }

    }
}
