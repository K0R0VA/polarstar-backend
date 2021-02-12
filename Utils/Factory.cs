using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Utils
{
    public readonly struct Factory<T>
    {
        public Factory (Func<Task<T>> task, Func<T, ActionResult> resultHandler,
            Func<int, string, ActionResult> errorHandler)
        {
            Task = task;
            ResultHandler = resultHandler;
            ErrorHandler = errorHandler;
        }
        public Func<Task<T>> Task { get; }
        public Func<T, ActionResult> ResultHandler { get; }
        public Func<int, string, ActionResult> ErrorHandler { get; }
    }
}