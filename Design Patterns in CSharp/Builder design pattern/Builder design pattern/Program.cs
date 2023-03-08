using Builder_design_pattern.Builders;
using Builder_design_pattern.ConcreteBuilders;
using Builder_design_pattern.Director;

VehicleBuilder builder;

// Create shop with vehicle builders
Shop shop = new Shop();

// Construct and display vehicles
builder = new CarBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new MotorCycleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

// Wait for user
Console.ReadKey();