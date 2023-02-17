﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WiziLib_DataAccess.Data;
using WizLib_Model.Models;

namespace WizLib.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objList = _db.Categories.ToList();
            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            Category obj = new Category();
            if(id == null)
            {
                return View(obj);
            }
            //this for edit
            obj = _db.Categories.FirstOrDefault(u => u.Category_Id == id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
