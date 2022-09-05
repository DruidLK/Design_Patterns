namespace Creationnal_Design_Patterns.CreationnalFoundations.Prototype_Cloning.Entities
{
    public sealed class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationallity { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string School { get; set; }
        public string Gender { get; set; }

        public Human? Clone() =>
            this.MemberwiseClone() as Human;
    }
}
