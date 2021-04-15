using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name: ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsLowerThan(FirstName, 3, "Name.FirstName", "Primeiro nome deve conter pelo menos 3 caracteres")
                .IsGreaterThan(FirstName, 40, "Name.FirstName", "Primeiro nome não deve conter mais de 40 caracteres")
                .IsLowerThan(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .IsGreaterThan(LastName, 40, "Name.FirstName", "Sobrenome não deve conter mais de 40 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
