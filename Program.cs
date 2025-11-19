
{
    //Laver vægt på motoren konstant
    const decimal maxkgpermotor = 5.6m; 
    
    //Her udfylder brugeren data 
    Console.WriteLine("How many motors are carrying packages?");
    int.TryParse(Console.ReadLine(), out var motors);
    
    Console.WriteLine("How many kg of packages do we expect?");
    decimal.TryParse(Console.ReadLine(), out var kg);
    
    //Vægt pr. motor 
    var weightPerMotor = kg / motors;
    
    //Udskrivning af resultat
    if (weightPerMotor <= maxkgpermotor)
        Console.WriteLine("Yes! The Conveyor belt can carry the packages");
    else 
        Console.WriteLine("No! The Conveyor belt can carry the packages");
    
}