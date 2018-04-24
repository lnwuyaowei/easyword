using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EasyWord.Models;

namespace EasyWord.Views
{
    public class 汉字38万词海Controller : Controller
    {
        private readonly mydb _context;

        public 汉字38万词海Controller(mydb context)
        {
            _context = context;
        }

        // GET: 汉字38万词海
        public async Task<IActionResult> Index()
        {
            return View(await _context.汉字38万词海.Take(15).ToListAsync());
        }

        // GET: 汉字38万词海/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 汉字38万词海 = await _context.汉字38万词海
                .SingleOrDefaultAsync(m => m.Id == id);
            if (汉字38万词海 == null)
            {
                return NotFound();
            }

            return View(汉字38万词海);
        }

        // GET: 汉字38万词海/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: 汉字38万词海/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Words,解释,WordsReverse,押韵,押韵字使用频率")] 汉字38万词海 汉字38万词海)
        {
            if (ModelState.IsValid)
            {
                _context.Add(汉字38万词海);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(汉字38万词海);
        }

        // GET: 汉字38万词海/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 汉字38万词海 = await _context.汉字38万词海.SingleOrDefaultAsync(m => m.Id == id);
            if (汉字38万词海 == null)
            {
                return NotFound();
            }
            return View(汉字38万词海);
        }

        // POST: 汉字38万词海/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Words,解释,WordsReverse,押韵,押韵字使用频率")] 汉字38万词海 汉字38万词海)
        {
            if (id != 汉字38万词海.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(汉字38万词海);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!汉字38万词海Exists(汉字38万词海.Id))
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
            return View(汉字38万词海);
        }

        // GET: 汉字38万词海/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 汉字38万词海 = await _context.汉字38万词海
                .SingleOrDefaultAsync(m => m.Id == id);
            if (汉字38万词海 == null)
            {
                return NotFound();
            }

            return View(汉字38万词海);
        }

        // POST: 汉字38万词海/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 汉字38万词海 = await _context.汉字38万词海.SingleOrDefaultAsync(m => m.Id == id);
            _context.汉字38万词海.Remove(汉字38万词海);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 汉字38万词海Exists(int id)
        {
            return _context.汉字38万词海.Any(e => e.Id == id);
        }
    }
}
