using System;
using static TarasDzivikPetProject.Domain.Entities.VehicleItem;

namespace TarasDzivikPetProject.Models
{
    public class RentPrise
    {
        public double Prise(VehicleType type) =>
            type switch
            {
                VehicleType.Авто => 11.99,
                VehicleType.Мотоцикл => 9.99,
                VehicleType.Самокат => 6.99,
                VehicleType.Велосипед => 5.99,
                _ => throw new ArgumentException(message:
                    "Такий транспортний засіб поки що не доступний",
                    paramName: nameof(type))
            };
    }
}