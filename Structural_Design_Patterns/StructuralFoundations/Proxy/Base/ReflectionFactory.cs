namespace Structural_Design_Patterns.StructuralFoundations.Proxy.Base
{
    public static class ReflectionFactory
    {
        public static T Get<T>(Func<T, bool> predicate) where T : class =>
             typeof(T)
            .Assembly
            .GetTypes()
            .Where(type => type.GetInterfaces().Contains(typeof(T)))
            .Select(type => Activator.CreateInstance(type) as T)
            .SingleOrDefault(predicate);

    }
}
