namespace DarkstarCrm.Data
{
    public class State : BaseEntity
    {
        public override int Id { get => StateId; set => StateId = value; }

        public int StateId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}