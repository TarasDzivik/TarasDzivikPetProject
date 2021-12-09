using TarasDzivikPetProject.Domain.Repositories.Abstract;

namespace TarasDzivikPetProject.Domain
{
    public class DataManager    // Клас який централізовано керуватиме нашими репозиторіями
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IVehicleItemsRepository VehicleItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IVehicleItemsRepository vehicleItemsRepository)
        {
            TextFields = textFieldsRepository;
            VehicleItems = vehicleItemsRepository;
        }
    }
}