namespace Scheming.Device.Domain.Catalog
{
    public class Rating
    {
        public int Id { get; set;}
        public int Star { get; set;}
        public int Stars { get; private set; }
        public string UserName { get; private set; }
        public string Review { get; set; }

        public Rating(int stars, string userName, string review)
        {
            if (stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5.");
            }
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null or empty.");
            }

            Stars = stars;
            UserName = userName;
            Review = review;
        }
    }
}