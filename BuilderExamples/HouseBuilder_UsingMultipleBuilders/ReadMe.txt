Problem Statement - 
We need to Build a house. House have different parts such as Walls, door, window, roof. 
How can have of different types -  House with Garage, House with Garden, House with Glass Window and Door. etc
One solution is - we can extend the base class and create a set of subclasses to cover all combinations, but at one point this subclasses number can be very large and which is not feasible.
second option is using Copnstructor in the base House class with all possible parameters that control the house object. 
but In most cases most of the parameters will be unused, making the constructor calls pretty ugly. For instance, only a fraction of houses have swimming pools, so the parameters related to swimming pools will be useless nine times out of ten.

What should we do now?

Solution Statement - 
Using Builder design pattern , 
we can extract the object construction code out of its own class and move it to separate objects called builders.
The pattern organizes object construction into a set of steps (buildWalls, buildDoor, etc.). 
To create an object, we execute a series of these steps on a builder object. 
The important part is that we don’t need to call all of the steps. 
We can call only those steps that are necessary for producing a particular configuration of an object.



Example Below - 

Products - RegularHouse, FarmHouse --> Representation

Builder - IRegularHouseBuilder , IFarmHouseBuilder, RegularHouseBuilder, FarmHouseBuilder
create Builder interface for each product and concrete class for each builder interface.

Director - RegularHouseDirector, FarmHouseDirector --> Construction
construct house in director class.




