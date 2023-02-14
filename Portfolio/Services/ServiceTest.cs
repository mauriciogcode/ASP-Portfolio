namespace Portfolio.Services
{
    public class ServiceTest
    {
    }
    public class ServiceUnico
    {
        public ServiceUnico()
        {
            ObtainGuid = Guid.NewGuid();
        }

        public Guid ObtainGuid { get; private set; }
    }

    public class ServiceScope
    {
        public ServiceScope()
        {
            ObtainGuid = Guid.NewGuid();
        }

        public Guid ObtainGuid { get; private set; }
    }

    public class ServiceTransient
    {
        public ServiceTransient()
        {
            ObtainGuid = Guid.NewGuid();
        }

        public Guid ObtainGuid { get; private set; }
    }
}
