﻿using simpl_ToDoList.Data.Context.Contrat;
using simpl_ToDoList.Data.Repository.Contrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Repository
{
    public class TachesRepository: ITachesRepository
    {
        private readonly Isimpl_ToDoListDBContect _DbContext;
        public TachesRepository(Isimpl_ToDoListDBContect Dbcontext)
        {
            _DbContext = Dbcontext;
        }
    }
}
