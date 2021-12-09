using System;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class VehicleItem
    {
        public enum FuelType
        {
            Бензин,
            Дизель,
            Гібрид,
            Електро,
            Газ
        }

        public enum VehicleType
        {
            Авто,
            Мотоцикл,
            Самокат,
            Велосипед,            
        }

        public int VehicleId { get; set; }
        public string TitleImagePath { get; set; }
        public VehicleType vehicleType { get; set; }
        public FuelType Fuel { get; set; }

        public DateTime DateAdded { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public int Travelled { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKaywords { get; set; }
    }
}