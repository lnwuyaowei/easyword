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
    public class 系统公告Controller : Controller
    {
        private readonly mydb _context;

        public 系统公告Controller(mydb context)
        {
            _context = context;
        }

        // GET: 系统公告
        public async Task<IActionResult> Index()
        {
            return View(await _context.系统公告.ToListAsync());
        }

        // GET: 系统公告/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 系统公告 = await _context.系统公告
                .SingleOrDefaultAsync(m => m.公告编号 == id);
            if (系统公告 == null)
            {
                return NotFound();
            }

            return View(系统公告);
        }

        // GET: 系统公告/Create
        public IActionResult Create()
        {
            //设置默认值
            系统公告 xtgg = new 系统公告();
            xtgg.发布时间 = DateTime.Now;
            return View(xtgg);
        }

        // POST: 系统公告/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("公告编号,公告标题,标题色彩,公告内容,发布时间,发布人编号,发布人姓名")] 系统公告 系统公告)
        {
            if (ModelState.IsValid)
            {
                _context.Add(系统公告);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(系统公告);
        }

        // GET: 系统公告/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 系统公告 = await _context.系统公告.SingleOrDefaultAsync(m => m.公告编号 == id);
            if (系统公告 == null)
            {
                return NotFound();
            }
            return View(系统公告);
        }

        // POST: 系统公告/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("公告编号,公告标题,标题色彩,公告内容,发布时间,发布人编号,发布人姓名")] 系统公告 系统公告)
        {
            if (id != 系统公告.公告编号)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(系统公告);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!系统公告Exists(系统公告.公告编号))
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
            return View(系统公告);
        }

        // GET: 系统公告/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 系统公告 = await _context.系统公告
                .SingleOrDefaultAsync(m => m.公告编号 == id);
            if (系统公告 == null)
            {
                return NotFound();
            }

            return View(系统公告);
        }

        // POST: 系统公告/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 系统公告 = await _context.系统公告.SingleOrDefaultAsync(m => m.公告编号 == id);
            _context.系统公告.Remove(系统公告);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 系统公告Exists(int id)
        {
            return _context.系统公告.Any(e => e.公告编号 == id);
        }
    }
}
