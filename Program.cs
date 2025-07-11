// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! ");

//direct method execution like any other method
new Country().ExecuteCode();
//direct method execution like any other method
new Category().ExecuteCode();

//calling abstract class method which then internally calls the extending class method, in this case it is Country
new Country().PerformActivity();

//calling abstract class method which then internally calls the extending class method, in this case it is Category
new Category().PerformActivity();


//calling abstract class method which then internally calls the extending class method, in this case it is Location
new Location().PerformActivity();