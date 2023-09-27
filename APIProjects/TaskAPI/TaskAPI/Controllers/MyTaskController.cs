using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Data;
using TaskAPI.Entities;

namespace TaskAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyTaskController : ControllerBase
    {
        private readonly MyTaskContext context;
        public MyTaskController(MyTaskContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<MyTask>> GetMyTasks() => context.MyTasks.ToList();

        [HttpPost]
        public void AddNote(MyTask myTask)
        { context.MyTasks.Add(myTask); context.SaveChanges(); }
    }
}