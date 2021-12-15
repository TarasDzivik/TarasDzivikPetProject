using TarasDzivikPetProject.Domain.Repositories.Abstract;

namespace TarasDzivikPetProject.Domain
{
    public class DataManager    // Клас який централізовано керуватиме нашими репозиторіями
    {
        //public IOrderRepository OrderRepository { get; set; }
        public ITextFieldsRepository TextFields { get; set; }
        public IVehicleItemsRepository VehicleItems { get; set; }

        public DataManager(/*IOrderRepository orderRepository,*/ ITextFieldsRepository textFieldsRepository, IVehicleItemsRepository vehicleItemsRepository)
        {
            //OrderRepository = orderRepository;
            TextFields = textFieldsRepository;
            VehicleItems = vehicleItemsRepository;
        }
    }
}