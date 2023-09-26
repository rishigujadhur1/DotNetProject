using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesAPI.Data;
using NotesAPI.Entities; 
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<List<Note>>> GetNotes()
        {
            return await context.Notes.ToListAsync();
        }
          
        [HttpPost]
        public async Task<ActionResult<Note>> AddNote([FromBody] string description)
        {
            Note note = new Note(){
                Description = description
            };
            await context.Notes.AddAsync(note);
            await context.SaveChangesAsync();
            return note;
        }

        [HttpDelete]
        public async Task DeleteNotesAsync([FromBody] int noteId)
        {
            var note = await context.Notes.FindAsync(noteId);
            context.Remove(note);
            await context.SaveChangesAsync(); 
        }
    }
}