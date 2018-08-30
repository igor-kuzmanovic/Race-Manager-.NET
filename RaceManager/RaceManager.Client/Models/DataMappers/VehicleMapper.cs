﻿using RaceManager.Client.Core.DataMappers;
using RaceManager.Client.VehicleService;

namespace RaceManager.Client.Models.DataMappers
{
    class VehicleMapper : DataMapper<Vehicle, VehicleDTO>, IVehicleMapper
    {
        public static VehicleMapper Instance { get; } = new VehicleMapper();

        static VehicleMapper() { }

        private VehicleMapper() { }

        public override Vehicle Map(VehicleDTO vehicleDTO)
        {
            var vehicle = new Vehicle();

            if (vehicleDTO != null)
            {
                vehicle.Id = vehicleDTO.Id;
                vehicle.Manufacturer = vehicleDTO.Manufacturer;
                vehicle.Model = vehicleDTO.Model;
                vehicle.Type = vehicleDTO.Type;
                vehicle.EngineHorsepower = vehicleDTO.EngineHorsepower;
                vehicle.EngineDisplacement = vehicleDTO.EngineDisplacement;
            }

            return vehicle;
        }

        public override VehicleDTO Map(Vehicle vehicle)
        {
            var vehicleDTO = new VehicleDTO();

            if (vehicle != null)
            {
                vehicleDTO.Id = vehicle.Id;
                vehicleDTO.Manufacturer = vehicle.Manufacturer;
                vehicleDTO.Model = vehicle.Model;
                vehicleDTO.Type = vehicle.Type;
                vehicleDTO.EngineHorsepower = vehicle.EngineHorsepower;
                vehicleDTO.EngineDisplacement = vehicle.EngineDisplacement;
            }

            return vehicleDTO;
        }
    }
}