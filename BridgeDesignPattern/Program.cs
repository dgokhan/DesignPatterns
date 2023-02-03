using BridgeDesignPattern.Engines;
using BridgeDesignPattern.Interfaces;
using BridgeDesignPattern.Brands;
using BridgeDesignPattern.Brands.Base;

IEngine dieselEngine = new DieselEngine();
IEngine petrolEngine = new PetrolEngine();

// Start Ford with Diesel Engine
Car fordWithDiesel = new Ford(dieselEngine);
fordWithDiesel.Start();

// Start Ford with Petrol Engine
Car fordWithPetrol = new Ford(petrolEngine);
fordWithPetrol.Start();

// Start Ford with Diesel Engine
Car toyotaWithDiesel = new Toyota(dieselEngine);
toyotaWithDiesel.Start();
 
