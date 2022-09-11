namespace Structural_Design_Patterns.StructuralFoundations.Decorator
{
    public sealed class Description
    {
        //Decorators are just a compositional alternative to subclassing onion.
        //The common example from the original book on this topic,
        //that everyone mentions, is with a text processing application.

        //the decorator pattern allows behavior to be added to an individual
        //object either statically or dynamically, without affecting the behavior of other
        //objects from the same class

        // provides an alternative to sublcassing for extending functionality
        // supports the SRP, since functionnality s added
        // to the divided class

        //Example 1: let us assume we have a car, from this car (onion) we want to add extension (decorate the onion)
        //the wheels/weopen/armor changes depending on the added extension

        //20. Decorator:Attach additional responsibilities to an object dynamically.
        //Decorators provide a flexible alternative to subclassing for extending functionality.
    }
}
