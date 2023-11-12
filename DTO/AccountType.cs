namespace DTO
{
    public class AccountType
    {
        public int ID { get; set; }
        public string TypeName { get; set; }

        public AccountType() { }

        public AccountType(int id, string typeName)
        {
            this.ID = id;
            this.TypeName = typeName;
        }
    }
}