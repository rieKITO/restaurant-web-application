using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DishesController : Controller
    {
        private readonly RestaurantDBContext _context;

        public DishesController(RestaurantDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UploadImage(int? id)
        {
            if (id == null || _context.Dishes == null)
            {
                return NotFound();
            }

            var dish = await _context.Dishes
                    .Include(d => d.Products)
                    .Include(d => d.Image)
                    .FirstOrDefaultAsync(d => d.Id == id);

            if (dish != null)
            {
                foreach (var file in Request.Form.Files)
                {
                    Image img = new Image();
                    img.ImageTitle = file.FileName;

                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    img.ImageData = ms.ToArray();

                    ms.Close();
                    ms.Dispose();

                    var image = _context.Images.Add(img);

                    dish.Image = image.Entity;
                    //dish.ImageId = image.Entity.ImageId;

                    await _context.SaveChangesAsync();
                }
                return Redirect(Request.Headers["Referer"].ToString());
            }
            return NotFound();
        }

        // GET: Dishes
        public async Task<IActionResult> Index()
        {
            return _context.Dishes != null ?
                        View(await _context.Dishes.Include(d => d.Products).Include(d => d.Image).ToListAsync()) :
                        Problem("Entity set 'RestaurantContext.Dishes'  is null.");
        }

        // GET: Dishes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null || _context.Dishes == null)
            {
                return NotFound();
            }

            var dish = await _context.Dishes.Include(d => d.Products).Include(d => d.Image)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dish == null)
            {
                return NotFound();
            }

            if (dish?.Image?.ImageData != null)
            {
                string imageBase64Data = Convert.ToBase64String(dish.Image.ImageData);
                string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                ViewBag.ImageDataUrl = imageDataURL;
            }

            return View(dish);
        }

        // GET: Dishes/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dishes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("Id,Name,Weight,RecipeId")] Dish dish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dish);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dish);
        }

        // GET: Dishes/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dishes == null)
            {
                return NotFound();
            }

            var dish = await _context.Dishes.FindAsync(id);
            if (dish == null)
            {
                return NotFound();
            }
            return View(dish);
        }

        // POST: Dishes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Weight,RecipeId")] Dish dish)
        {
            if (id != dish.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dish);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DishExists(dish.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dish);
        }

        // GET: Dishes/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dishes == null)
            {
                return NotFound();
            }

            var dish = await _context.Dishes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dish == null)
            {
                return NotFound();
            }

            return View(dish);
        }

        // POST: Dishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dishes == null)
            {
                return Problem("Entity set 'RestaurantContext.Dishes'  is null.");
            }
            var dish = await _context.Dishes.FindAsync(id);
            if (dish != null)
            {
                _context.Dishes.Remove(dish);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DishExists(int id)
        {
            return (_context.Dishes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
