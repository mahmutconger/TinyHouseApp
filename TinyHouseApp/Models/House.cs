﻿namespace TinyHouseApp.Models
{
    public class House
    {
        public int HouseID { get; set; }
        public int OwnerID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public string Location { get; set; }
        public bool IsActive { get; set; }

    }
}
