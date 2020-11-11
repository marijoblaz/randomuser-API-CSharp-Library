using Newtonsoft.Json.Linq;

namespace randomuser
{
    public class Results
    {
        public string Gender { get; }
        public Name Name { get;}
        public Location Location { get; }
        public string Email { get; }
        public Login Login { get; }
        public Dob Dob { get; }
        public string Phone { get; }
        public string Cell { get; }
        public Id Id { get; }
        public Picture Picture { get; }
        public string Nat { get; }
        public Results(JToken resultsData)
        {
            if (resultsData is null)
                throw new System.ArgumentNullException(nameof(resultsData));

            Gender = resultsData.SelectToken("gender").ToString();
            Name = new Name(resultsData.SelectToken("name"));
            Location = new Location(resultsData.SelectToken("location"));
            Email = resultsData.SelectToken("email").ToString();
            Login = new Login(resultsData.SelectToken("login"));
            Dob = new Dob(resultsData.SelectToken("dob"));
            Phone = resultsData.SelectToken("phone").ToString();
            Cell = resultsData.SelectToken("cell").ToString();
            Id = new Id(resultsData.SelectToken("id"));
            Picture = new Picture(resultsData.SelectToken("picture"));
            Nat = resultsData.SelectToken("nat").ToString();
        }
        public override string ToString()
        {
            return $"Gender: {Gender}\nName: {Name}\nLocation: {Location}\nEmail: {Email}\n"+
                   $"Login: {Login}\nDob: {Dob}\nPhone: {Phone}\nCell: {Cell}\nId: {Id}\nPicture: {Picture}\n"+
                   $"Nat: {Nat}\n";
        }
    }
}
