using System;

/* This program stores and displays passenger information for a galactic travel agency, 
   updates the passenger's age, and demonstrates basic type conversions. */

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    string passengerName = "IK439";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    Console.WriteLine($"passengerName: {passengerName}");
    Console.WriteLine($"passengerAge: {passengerAge}");
    Console.WriteLine($"ticketType: {ticketType}");
    Console.WriteLine($"preferredPlanet: {preferredPlanet}");

    Console.WriteLine();

    // Update the passenger's age
    passengerAge += 1;
    Console.WriteLine($"passengerAge (updated): {passengerAge}");

    Console.WriteLine();

    // Explicit conversion example
    double passengerAgeDouble = (double) passengerAge;
    Console.WriteLine($"passengerAgeDouble: {passengerAgeDouble}");

    // Implicit conversion example
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine($"passengerAgeDouble2: {passengerAgeDouble2}");

    // Explicit conversion example using helper method
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine($"passengerAgeString: {passengerAgeString}");
  }
}