using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Utils
{
    public static class ControllerErrorHandler
    {

        public static async Task<ActionResult<T>> TryDatabaseTask<T>(
            ControllerBase controller,
            Func<Task<T>> task,
            int statusCode = 500,
            string message = "Database is dead") => await TryByController(task, controller, statusCode, message);
        
        public static async Task<ActionResult<T>> TryDatabaseTask<T>(
            Factory<T> factory,
            int statusCode = 500,
            string message = "Database is dead") => await TryByFactory(factory, statusCode, message);
        
        private static async Task<ActionResult<T>> TryByFactory<T>(Factory<T> factory, int statusCode, string message)
        {
            try
            {
                var result = await factory.Task.Invoke();
                return factory.ResultHandler(result);
            }
            catch (Exception)
            {
                return factory.ErrorHandler(statusCode, message);
            }
        }
        private static async Task<ActionResult<T>> TryByController<T>(Func<Task<T>> task, ControllerBase controller, int statusCode, string message)
        {
            try
            {
                var result = await task.Invoke();
                return controller.Ok(result);
            }
            catch (Exception)
            {
                return controller.StatusCode(statusCode, message);
            }
        }
    }
}