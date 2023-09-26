using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesAPI.Data;
using NotesAPI.Entities;

namespace NotesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly NotesContext context;
        public NotesController(NotesContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Note>> GetNotes()
        {
            return context.Notes.ToList();
        }

        [HttpPost]
        public void AddNote(Note note)
        {
            context.Notes.Add(note);
            context.SaveChanges();
        }

        [HttpDelete]
        public async Task<Note> DeleteCourseAsync(Note note)
        {
            context.Remove(note);
            await context.SaveChangesAsync();
            return note;
        }
    }
}