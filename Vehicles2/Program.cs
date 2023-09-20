namespace Vehicles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cars

            PassengerCars passengercar1 = new PassengerCars();

            passengercar1.Make = "volvo";
            passengercar1.Model = "XC90";
            passengercar1.Year = 2009;
            passengercar1.Color = "black";
            passengercar1.SetMaxSpeed(230);
            passengercar1.GetMaxSpeed();
            passengercar1.Doors = 5;
            passengercar1.IsCombi = false;
            passengercar1.Fuel = "diesel";

            LuxuryCars luxurycar1 = new LuxuryCars();

            luxurycar1.Make = "Rolls Royce";
            luxurycar1.Model = "Phantom";
            luxurycar1.Year = 2017;
            luxurycar1.Color = "red";
            luxurycar1.SetMaxSpeed(160);
            luxurycar1.GetMaxSpeed();
            luxurycar1.Doors = 5;
            luxurycar1.IsLetherSeats = true;
            luxurycar1.Fuel = "petrol";

            SportCars sportscar1 = new SportCars();

            sportscar1.Make = "Porsche";
            sportscar1.Model = "911 GT3";
            sportscar1.Year = 2022;
            sportscar1.Color = "green";
            sportscar1.SetMaxSpeed(320);
            sportscar1.GetMaxSpeed();
            sportscar1.Doors = 2;
            sportscar1.Seats = 2;
            sportscar1.IsManual = true;
            sportscar1.Fuel = "petrol";

            //Boats

            Kayaks kayak1 = new Kayaks(true);

            kayak1.Make = "Ocean Kayak";
            kayak1.Model = "Malibu two";
            kayak1.Year = 2019;
            kayak1.Color = "blue";
            kayak1.NumberOfPassengers = 2;
            kayak1.PowerFrom = "paddle";
            kayak1.SetMaxSpeed(8);
            kayak1.GetMaxSpeed();

            MotorBoats motorBoat1 = new MotorBoats(600);

            motorBoat1.Make = "Boston Whaler";
            motorBoat1.Model = "270 Vantage";
            motorBoat1.Year = 2020;
            motorBoat1.Color = "yellow";
            motorBoat1.NumberOfPassengers = 12;
            motorBoat1.PowerFrom = "motor";
            motorBoat1.SetMaxSpeed(90);
            motorBoat1.GetMaxSpeed();

            SailBoats sailBoat1 = new SailBoats(2);

            sailBoat1.Make = "Beneteau";
            sailBoat1.Model = "Oceanis 45";
            sailBoat1.Year = 2023;
            sailBoat1.Color = "brown";
            sailBoat1.NumberOfPassengers = 10;
            sailBoat1.PowerFrom = "wind";
            sailBoat1.SetMaxSpeed(19);
            sailBoat1.GetMaxSpeed();

            // Trains

            Trams trams1 = new Trams("overhead wire system");
                
            trams1.Make = "Bombardier";
            trams1.Model = "Flexity";
            trams1.Year = 1995;
            trams1.Color = "blue";                      
            trams1.SetMaxSpeed(70);
            trams1.GetMaxSpeed();
            trams1.NumberOfCarriage = 4;

            PassengerTrain passengerTrain1 = new PassengerTrain(true);

            passengerTrain1.Make = "Bombardier";
            passengerTrain1.Model = "ZEFIRO";
            passengerTrain1.Year = 2023;
            passengerTrain1.Color = "red";
            passengerTrain1.SetMaxSpeed(320);
            passengerTrain1.GetMaxSpeed();
            passengerTrain1.NumberOfCarriage = 10;

            GoodsTrain goodsTrain1 = new GoodsTrain(false);

            goodsTrain1.Make = "General Electric";
            goodsTrain1.Model = "ES44AC";
            goodsTrain1.Year = 2003;
            goodsTrain1.Color = "brown";
            goodsTrain1.SetMaxSpeed(180);
            goodsTrain1.GetMaxSpeed();
            goodsTrain1.NumberOfCarriage = 15;


            // Print some information about vehicles

            passengercar1.StartVehicle();
            luxurycar1.StartVehicle();
            sportscar1.StartVehicle();
            kayak1.StartVehicle();
            motorBoat1.StartVehicle();
            sailBoat1.StartVehicle();
            trams1.StartVehicle();
            passengercar1.StartVehicle();
            goodsTrain1.StartVehicle();

            Console.ReadKey();
            
        }
    }
}