﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WizLib_Model.Models;

namespace WizLib_Model.ViewModels
{
    public class BookVM
    {
        public Book Book { get; set; }
        public IEnumerable<SelectListItem> PublisherList { get; set; }  

    }
}
