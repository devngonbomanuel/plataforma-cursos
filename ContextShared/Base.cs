using plataformacursos.ContextNotification;

namespace plataformacursos.ContextShared
{
    public abstract class Base : Notificador
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}