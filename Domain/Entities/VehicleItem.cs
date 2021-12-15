using System;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class VehicleItem
    {
        public int VehicleId { get; set; }
        public string TitleImagePath { get; set; }
        public string VehicleType { get; set; }
        public string Fuel { get; set; }

        public DateTime DateAdded { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public int Travelled { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //public int CurrentOrderId { get; set; }
        //public Order Order { get; set; }
    }
}