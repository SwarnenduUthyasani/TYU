namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        private long id { get; set; }
        private string name { get; set; }
        private float price { get; set; }
        private Boolean active { get; set; }
        private DateOnly dateOfLaunch { get; set; }
        private string category { get; set; }
        private Boolean freeDelivery { get; set; }

        public MenuItem()
        {
            id = this.id;
            name = this.name;
            price = this.price;
            active = this.active;
            dateOfLaunch = this.dateOfLaunch;
            category = this.category;
            freeDelivery = this.freeDelivery;
        }

        public override string? ToString() //Check later
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is MenuItem item &&
                   id == item.id;
        }
    }
}
