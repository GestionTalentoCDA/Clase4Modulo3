using Clase4Modulo3.Domain.Entities;

namespace Clase4Modulo3.Services.Interfaces
{
    public interface ITareasService
    {
        //Sincrono
        //public List<Tarea> GetTasks();
        //public bool AddTarea(Tarea tasks);

        
        //Asincrono 
        public Task<List<Tarea>> GetTareaAsync();
        public Task<bool> AddTareaAsync(Tarea tasks);
        

    }
}
