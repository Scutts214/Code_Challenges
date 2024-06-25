Console.WriteLine("Calculate Trip Distance");
Console.Write("Begining Odometer: ");
int startOdom = Convert.ToInt32(Console.ReadLine());
Console.Write("End Odometer: ");
int endOdom = Convert.ToInt32(Console.ReadLine());

var distanceTraveled = endOdom - startOdom;
Console.WriteLine($"Total Miles Traveled: {distanceTraveled}");
