using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        // In-memory list to store tasks temporarily
        private static List<TaskModel> tasks = new List<TaskModel>
        {
            new TaskModel
            {
                Id = 1,
                Title = "Task 1",
                Description = "Description of Task 1",
                IsCompleted = false,
                DueDate = DateTime.Now.AddDays(1),
            },
            new TaskModel
            {
                Id = 2,
                Title = "Task 2",
                Description = "Description of Task 2",
                IsCompleted = true,
                DueDate = DateTime.Now.AddDays(2),
            },
        };

        // GET: api/task
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(tasks); // Returns the list of tasks
        }

        // GET: api/task/{id}
        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                return NotFound(); // If no task with the given ID, return 404
            }
            return Ok(task); // Return the found task
        }

        // POST: api/task
        [HttpPost]
        public IActionResult CreateTask(TaskModel newTask)
        {
            // Generate a new ID
            newTask.Id = tasks.Count + 1;
            tasks.Add(newTask);
            return CreatedAtAction(nameof(GetTaskById), new { id = newTask.Id }, newTask); // Return 201 Created with the new task
        }

        // PUT: api/task/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, TaskModel updatedTask)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                return NotFound(); // If no task with the given ID, return 404
            }

            // Update the task properties
            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.IsCompleted = updatedTask.IsCompleted;
            task.DueDate = updatedTask.DueDate;

            return NoContent(); // Return 204 No Content on successful update
        }

        // DELETE: api/task/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                return NotFound(); // If no task with the given ID, return 404
            }

            tasks.Remove(task);
            return NoContent(); // Return 204 No Content on successful deletion
        }
    }
}
