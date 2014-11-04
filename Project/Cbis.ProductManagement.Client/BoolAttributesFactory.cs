using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    public class BoolAttributesFactory
    {
        public InformationData CreateAllergyFreeRoom(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000208, value);
        }

        public InformationData CreateBreakfast(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000606, value);
        }

        public InformationData CreateAlacarte(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000600, value);
        }

        public InformationData CreateBuffe(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000158, value);
        }

        public InformationData CreateSunTerass(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000191, value);
        }

        public InformationData CreateFacilitiesForDisabled(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000036, value);
        }

        public InformationData CreateSkiStorage(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000899, value);
        }

        public InformationData CreateValetParking(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001427, value);
        }

        public InformationData CreateSafetyDepositBoxes(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000632, value);
        }

        public InformationData CreateExpressCheckout(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000640, value);
        }

        public InformationData CreateNonSmokingRoom(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000187, value);
        }

        public InformationData CreateNewspapers(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001628, value);
        }

        public InformationData CreateAllPublicAreasNonSmoking(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001598, value);
        }

        public InformationData CreateElevator(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000038, value);
        }

        public InformationData CreateAircondition(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000624, value);
        }

        public InformationData CreateLuggageRoom(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000752, value);
        }

        public InformationData CreateBar(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000165, value);
        }

        public InformationData Create24HCheckin(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000599, value);
        }

        public InformationData CreateHorsebackRiding(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001567, value);
        }

        public InformationData CreateSkiSchool(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000492, value);
        }

        public InformationData CreateOutdoorPool(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000044, value);
        }

        public InformationData CreateIndoorPool(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000040, value);
        }

        public InformationData CreateSolarium(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000172, value);
        }

        public InformationData CreateGolf(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000545, value);
        }

        public InformationData CreateSquashCourt(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001850, value);
        }

        public InformationData CreateWindsufing(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001893, value);
        }

        public InformationData CreateCasino(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000641, value);
        }

        public InformationData CreateMiniGolf(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000542, value);
        }

        public InformationData CreateCanoe(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000422, value);
        }

        public InformationData CreateTennisCourt(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000047, value);
        }

        public InformationData CreateFishing(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000287, value);
        }

        public InformationData CreateBarbequeuGrills(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001448, value);
        }

        public InformationData CreateTableTennis(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000538, value);
        }

        public InformationData CreateLibrary(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000227, value);
        }

        public InformationData CreateDiving(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000763, value);
        }

        public InformationData CreateGameRoom(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000928, value);
        }

        public InformationData CreateBowling(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000566, value);
        }

        public InformationData CreateSkiingAlpine(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000502, value);
        }

        /// <summary>
        /// Creates an attribute telling if something has a pool table or a billiard table.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns></returns>
        public InformationData CreateBilliards(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000540, value);
        }

        public InformationData CreatePlayground(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000086, value);
        }

        public InformationData CreateHiking(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000767, value);
        }

        public InformationData CreateBike(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000567, value);
        }

        public InformationData CreateMassage(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000050, value);
        }

        public InformationData CreateSauna(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000043, value);
        }

        public InformationData CreateGym(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000270, value);
        }

        public InformationData CreateSpa(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000049, value);
        }

        public InformationData CreateFreeWifi(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001845, value);
        }

        public InformationData CreateNighclub(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001392, value);
        }

        public InformationData CreateTransfer(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000647, value);
        }

        public InformationData CreateBabysittingService(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000755, value);
        }

        public InformationData CreateShoeShineStand(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001411, value);
        }

        public InformationData CreateRoomService(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000041, value);
        }

        public InformationData CreateCurrencyExchange(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000648, value);
        }

        public InformationData CreateCarRental(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000658, value);
        }

        public InformationData CreateDryCleaning(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001426, value);
        }

        public InformationData CreateGiftNewsStand(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001375, value);
        }

        public InformationData CreateHairdresserBarber(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001376, value);
        }

        public InformationData CreateLaundryService(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000035, value);
        }

        public InformationData CreateBicycleRental(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000075, value);
        }

        public InformationData CreateLocationNearAirport(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000247, value);
        }

        public InformationData CreateLocationNearBeach(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000653, value);
        }

        public InformationData CreateLocationNearCity(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000651, value);
        }

        public InformationData CreateLocationNearDownTown(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002045, value);
        }

        public InformationData CreateLocationNearLake(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000537, value);
        }

        public InformationData CreateLocationNearMountain(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000826, value);
        }

        public InformationData CreateLocationNearSuburb(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000914, value);
        }

        public InformationData CreateParkingNearby(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000757, value);
        }

        public InformationData CreateParking(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000039, value);
        }

        public InformationData CreateInternet(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000156, value);
        }

        public InformationData CreateCountrySide(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000832, value);
        }
    
        public InformationData Snackbar(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002267, value);
        }

        public InformationData SoundproofRoom(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002268, value);
        }

        public InformationData Dart(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002269, value);
        }

        public InformationData Karaoke(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002270, value);
        }

        public InformationData Snorkeling(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002271, value);
        }

        public InformationData Cycling(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002272, value);
        }

        public InformationData SpaWellnessCentre(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002070, value);
        }

        public InformationData TransferServiceAdditionalCost(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002273, value);
        }

        public InformationData HoneymoonSuite(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002274, value);
        }

        public InformationData GroceryStore(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1000210, value);
        }

        public InformationData Beachfront(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001569, value);
        }

        public InformationData Oceanfront(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1001568, value);
        }

        public InformationData Luxury(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002275, value);
        }

        public InformationData Resort(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002276, value);
        }

        public InformationData Boutique(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002277, value);
        }

        public InformationData BedAndBreakfast(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002278, value);
        }

        public InformationData GuestHouse(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002279, value);
        }

        public InformationData PrivateBeachArea(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002280, value); 
        }

        public InformationData Budget(bool value)
        {
            return new InformationDataBool(CultureInfo.InvariantCulture, 1002281, value); 
        }
    }
}
