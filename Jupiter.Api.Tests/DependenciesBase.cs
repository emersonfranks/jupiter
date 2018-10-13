using AutoFixture;

namespace Jupiter.Api.Tests
{
    public abstract class DependenciesBase<T>
    {
        private static readonly Fixture Fixture = new Fixture();

        public abstract T Create();
    }
}
