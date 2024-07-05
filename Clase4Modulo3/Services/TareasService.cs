using Clase4Modulo3.Domain.Entities;
using Clase4Modulo3.Exceptions;
using Clase4Modulo3.Repository;
using Clase4Modulo3.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clase4Modulo3.Services
{
    public class TareasService : ITareasService
    {
        private readonly ToDoListDBContext _context;
        public TareasService(ToDoListDBContext context)
        {
            _context = context;

            
        }
        //Asincrono
        
            
        public async Task<List<Tarea>> GetTareaAsync()
        {
            //hilo principal
            //Nombre de metodo + Async
            throw new ValidationNegocioException();
            var result =  await _context.Tarea.ToListAsync();  //2do plano //10s
            
            return result;
        }
        public async Task<bool> AddTareaAsync(Tarea tasks)
        {

            throw new ValidationNegocioException();
            await _context.Tarea.AddAsync(tasks);
                await _context.SaveChangesAsync();
                return true;
        }

    

        //Sincrono
        //public List<Tarea> GetTasks()
        //{
        //    return _context.Tarea.ToList();
        //}

        //public bool AddTarea(Tarea newTask)
        //{
        //    _context.Tarea.Add(newTask);
        //    _context.SaveChanges();
        //    return true;
        //}

    }
}
