using TarasDzivikPetProject.Domain.Repositories.Abstract;

namespace TarasDzivikPetProject.Domain
{
    public class DataManager    // Клас який централізовано керуватиме нашими репозиторіями
    {
        public ICustomerRepository CustomerRepository { get; set; }
        public ITextFieldsRepository TextFields { get; set; }
        public IVehicleItemsRepository VehicleItems { get; set; }

        public DataManager(ICustomerRepository customerRepository, ITextFieldsRepository textFieldsRepository, IVehicleItemsRepository vehicleItemsRepository)
        {
            CustomerRepository = customerRepository;
            TextFields = textFieldsRepository;
            VehicleItems = vehicleItemsRepository;
        }
    }
}