namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        public long id { get; private set; }
        public string name { get; private set; }
        public float price { get; private set; }
        public Boolean active { get; private set; }
        public DateOnly dateOfLaunch { get; private set; }
        public string category { get; private set; }
        public Boolean freeDelivery { get; private set; }

        public MenuItem()
        {
            /*id = this.id;
            this.name = name;
            price = this.price;
            active = this.active;
            dateOfLaunch = this.dateOfLaunch;
            category = this.category;
            freeDelivery = this.freeDelivery;*/
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
