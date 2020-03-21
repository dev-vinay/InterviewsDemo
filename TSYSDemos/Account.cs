namespace TSYSDemos {
    public class Account {
        public int AccountNumber { get; set; }
        public int HolderId { get; set; }
        public string AccountHolderName { get; set; }
        public long OutstandingBalance { get; set; }

        public decimal Balance { get; set; }
    }

    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}