using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.controllers
{
    public class CommentsController : Controller
    {
        private readonly PetContext _context;

        public CommentsController(PetContext context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> Index()
        {
            var petContext = _context.comments.Include(c => c.animal);
            return View(await petContext.ToListAsync());
        }

       

        // GET: Comments/Create
        public IActionResult Create()
        {
            List<Animal> cate = new List<Animal>();
            cate = _context.animals.ToList();
            ViewBag.Listofanimals = cate;


           // ViewData["AnimalId"] = new SelectList(_context.animals, "AnimalId", "AnimalId");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,Comment,AnimalId")] Comments comments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.animals, "AnimalId", "AnimalId", comments.AnimalId);
            return View(comments);
        }

      

       
        private bool CommentsExists(int id)
        {
            return _context.comments.Any(e => e.CommentId == id);
        }
    }
}
