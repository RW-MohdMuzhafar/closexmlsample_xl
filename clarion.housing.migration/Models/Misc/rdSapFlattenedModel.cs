using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Misc
{
    public class FullRdSapFlattenedModel
    {
        // --- CORE DATABASE & ADDRESS INFO ---
        [ExcelHeader("Info for database")] public string? DatabaseInfo { get; set; }
        [ExcelHeader("rdSAPDataID")] public string? RdSapDataId { get; set; }
        [ExcelHeader("Address.Id")] public string? AddressId { get; set; }
        [ExcelHeader("Address.UPRN")] public string? Uprn { get; set; }
        [ExcelHeader("Address.AddressLine1")] public string? Address1 { get; set; }
        [ExcelHeader("Address.AddressLine2")] public string? Address2 { get; set; }
        [ExcelHeader("Address.PostTown")] public string? PostTown { get; set; }
        [ExcelHeader("Address.Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Address.OrganisationReference")] public string? OrgRef { get; set; }

        // --- CALCULATION RESULTS ---
        [ExcelHeader("SAPFromXml")] public double? SapScore { get; set; }
        [ExcelHeader("EIFromXml")] public double? EiScore { get; set; }
        [ExcelHeader("CO2FromXml")] public double? Co2Emissions { get; set; }
        [ExcelHeader("HeatingCostCurrent")] public decimal? HeatingCost { get; set; }
        [ExcelHeader("HotWaterCostCurrent")] public decimal? HotWaterCost { get; set; }
        [ExcelHeader("InspectionDate")] public DateTime? InspectionDate { get; set; }

        // --- PROPERTY ATTRIBUTES ---
        [ExcelHeader("PropertyType")] public string? PropertyType { get; set; }
        [ExcelHeader("BuiltForm")] public string? BuiltForm { get; set; }
        [ExcelHeader("Tenure")] public string? Tenure { get; set; }
        [ExcelHeader("HabitableRoomCount")] public int? HabitableRooms { get; set; }
        [ExcelHeader("HeatedRoomCount")] public int? HeatedRooms { get; set; }
        [ExcelHeader("MainsGas")] public string? HasMainsGas { get; set; }

        // --- BUILDING PART 0 (Main Structure) ---
        [ExcelHeader("rdSAPBuildingParts[0].ConstructionAgeBand")] public string? Part0AgeBand { get; set; }
        [ExcelHeader("rdSAPBuildingParts[0].WallConstruction")] public string? Part0WallType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[0].WallInsulationType")] public string? Part0WallInsulation { get; set; }
        [ExcelHeader("rdSAPBuildingParts[0].RoofConstruction")] public string? Part0RoofType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[0].RoofInsulationLocation")] public string? Part0RoofInsulationPos { get; set; }
        [ExcelHeader("rdSAPBuildingParts[0].FloorConstruction")] public string? Part0FloorType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[0].rdSAPFloorDimensions[0].TotalFloorArea")] public double? Part0FloorArea { get; set; }

        // --- BUILDING PART 1 (Extension 1) ---
        [ExcelHeader("rdSAPBuildingParts[1].ConstructionAgeBand")] public string? Part1AgeBand { get; set; }
        [ExcelHeader("rdSAPBuildingParts[1].WallConstruction")] public string? Part1WallType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[1].WallInsulationType")] public string? Part1WallInsulation { get; set; }
        [ExcelHeader("rdSAPBuildingParts[1].rdSAPFloorDimensions[0].TotalFloorArea")] public double? Part1FloorArea { get; set; }

        // --- BUILDING PART 2 (Extension 2) ---
        [ExcelHeader("rdSAPBuildingParts[2].ConstructionAgeBand")] public string? Part2AgeBand { get; set; }
        [ExcelHeader("rdSAPBuildingParts[2].WallConstruction")] public string? Part2WallType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[2].rdSAPFloorDimensions[0].TotalFloorArea")] public double? Part2FloorArea { get; set; }

        // --- BUILDING PART 3 (Extension 3) ---
        [ExcelHeader("rdSAPBuildingParts[3].ConstructionAgeBand")] public string? Part3AgeBand { get; set; }
        [ExcelHeader("rdSAPBuildingParts[3].WallConstruction")] public string? Part3WallType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[3].rdSAPFloorDimensions[0].TotalFloorArea")] public double? Part3FloorArea { get; set; }

        // --- BUILDING PART 4 (Extension 4) ---
        [ExcelHeader("rdSAPBuildingParts[4].ConstructionAgeBand")] public string? Part4AgeBand { get; set; }
        [ExcelHeader("rdSAPBuildingParts[4].WallConstruction")] public string? Part4WallType { get; set; }
        [ExcelHeader("rdSAPBuildingParts[4].rdSAPFloorDimensions[0].TotalFloorArea")] public double? Part4FloorArea { get; set; }

        // --- HEATING & CONTROLS ---
        [ExcelHeader("WaterHeatingFuel")] public string? WaterHeatingFuel { get; set; }
        [ExcelHeader("SecondaryHeatingType")] public string? SecondaryHeatingType { get; set; }
        [ExcelHeader("CylinderSize")] public string? HotWaterCylinderSize { get; set; }
        [ExcelHeader("CylinderInsulationThickness")] public string? CylinderInsulation { get; set; }

        // --- RENEWABLES & MISC ---
        [ExcelHeader("PVConnection")] public string? SolarPvConnection { get; set; }
        [ExcelHeader("SolarWaterHeating")] public string? HasSolarThermal { get; set; }
        [ExcelHeader("WindTurbinesCount")] public int? WindTurbineCount { get; set; }
        [ExcelHeader("MeterType")] public string? ElectricityMeterType { get; set; }
    }
}
