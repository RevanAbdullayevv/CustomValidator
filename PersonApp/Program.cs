using CustomValidator;
namespace PersonApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                Person newPerson = new Person
                {
                    Username = "revanabdullayev",
                    Password = "revanabdullayev@gmail.com",
                    Name = "Revan",
                    Surname = "Abdullayev",
                    Age = 20,
                    Birthday = new DateTime(2005, 5, 15)
                };

                if (IsValidPerson(newPerson))
                {
                    Console.WriteLine("obyekt yaradıldı.");
                }
                else
                {
                    Console.WriteLine("Xəta: Verilənlərdə problem var.");
                }
            }
        }
        static bool IsValidPerson(Person p)
        {
            return Validator.ValidateUserName(p.Username) &&
                   Validator.ValidatePassword(p.Password) &&
                   Validator.ValidateName(p.Name) &&
                   Validator.ValidateSurname(p.Surname) &&
                   Validator.ValidateAge(p.Age) &&
                   Validator.ValidateBirthday(p.Birthday);
        }
    }
}

