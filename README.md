# TechExerciseCubic
Technical exercise cubic, by mmula

Visual Studio 2019 project, Console application with .NET framework 4.7.2



This application prompts the user to enter coordinates(in 3D) and dimension for two shapes type cube. The application
prints out as a result whether there is collision between both shapes or not, and what is the intersection's volume.

I haven't applied any specific design patern. I've just tried to follow SOLID principles in order to make the code clear and maintainable.
-Single Responsabity principle: 
I think pretty much all classes in the application are in charge of only one task or purpose.

-Open for extension/close for modification printicple:
Having in mind the apliation is about cubes, volumes, dimensions, etc, and also knowing in advance the domamin of this area( where
could be potencially different types of objects, apart from cubes there could be sphere, piramid, etc. Even 2D object (trianges, rectangles,
circles) I've created a hierachy of clases with IShape at the top, followed by Shape3D and ending with Cube. Hence I left the ground
prepared for extending with little inpact in what it is already done.

-I've also avoid to make object dependent on others. So when an object need another one in order to make its job I try to
pass dependencies via constructor(or setter).

-Interface segregation: I've been tempted to implement the jobs of "Detect collition" and "Calculate volume" in the same
interface. However keep them sepatated may help in not polluting the inteface. Right now comes to my mind that in future cases
where the application would need to work with 2D shapes take into account that 2D shapes do not have volume, but they do collite. So
I think it wasn't a bad idea.
