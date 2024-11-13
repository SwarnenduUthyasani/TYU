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

        public MenuItem(long id, string name, float price, bool active, DateOnly dateOfLaunch, string category, bool freeDelivery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.category = category;
            this.freeDelivery = freeDelivery;
        }


        public override bool Equals(object? obj)
        {
            return obj is MenuItem item &&
                   id == item.id;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
