﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demoweb.Pages
{
    public class historyModel : PageModel
    {
        public void OnGet()
        {
            throw new Exception("Custom Exception occurred here");
        }
    }
}