﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Model;

namespace Application.Controllers
{
    public class SubjectController : BaseController<SubjectController, SubjectModel>
    {
        public SubjectController(IBaseRepo<SubjectModel> repo) : base(repo)
        {

        }
    }
}
