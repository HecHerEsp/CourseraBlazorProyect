using EventEaseApp.Shared;

namespace EventEaseApp.Services
{
    public class EventsService
    {
        private List<EventModel> _events = new()
        {
            new EventModel { Id = 1, Nombre = "Concierto de Primavera", Fecha = new DateTime(2026, 5, 24), Ubicacion = "Auditorio Central" },
            new EventModel { Id = 2, Nombre = "Feria de Tecnología", Fecha = new DateTime(2026, 6, 12), Ubicacion = "Centro de Convenciones" },
            new EventModel { Id = 3, Nombre = "Exposición de Arte", Fecha = new DateTime(2026, 7, 5), Ubicacion = "Galería del Pueblo" }
        };

        public List<EventModel> GetEvents() => _events;

        public EventModel? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

        public void UpdateEvent(EventModel updatedEvent)
        {
            var existing = _events.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (existing != null)
            {
                existing.Nombre = updatedEvent.Nombre;
                existing.Fecha = updatedEvent.Fecha;
                existing.Ubicacion = updatedEvent.Ubicacion;
            }
        }
    }
}
