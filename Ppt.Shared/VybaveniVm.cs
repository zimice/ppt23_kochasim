namespace Ppt.Shared
{

    public class VybaveniVm
    {
        public string Name { get; set; } = "";
        
        public bool isRevisionNeeded { get; set; }

        public bool isEditable { get; set; }

        public int price { get; set; }

        public Guid Id { get; set; }
        public DateTime BoughtDateTime { get; set; }

        public DateTime LastRevisionDateTime { get; set; }

        public VybaveniVm(string Name, bool isRevisionNeeded, DateTime BoughtDateTime,DateTime LastRevisionDateTime) {
            this.Name = Name;
            this.isRevisionNeeded = isRevisionNeeded;  
            this.BoughtDateTime = BoughtDateTime;
            this.LastRevisionDateTime = LastRevisionDateTime;
            this.Id = Guid.NewGuid();
        }

        public static List<VybaveniVm> VratRandSeznam()
        {
            List<VybaveniVm> list = new List<VybaveniVm>();
            int size = Random.Shared.Next(4, 20);
            var rndboughtDateTime = new DateTime(2010, 1, 1).AddDays(Random.Shared.Next(1, (DateTime.Now - new DateTime(2010, 1, 1)).Days));
            var rndlastRevisionDays = Random.Shared.Next(1, (DateTime.Now - rndboughtDateTime).Days);
            var rndlastRevisionDateTime = rndboughtDateTime.AddDays(rndlastRevisionDays);
            for (int i = 0; i < size; i++) {
                list.Add(new VybaveniVm(Random.Shared.Next(54000, 99999).ToString(), Convert.ToBoolean(Random.Shared.Next(2)), rndboughtDateTime, rndlastRevisionDateTime));
            }
            return list;
        }

    }
}
    
