using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI
{
    public class SetupService
    {
        public static void Init(eRestoranContext rS2Context)
        {
            rS2Context.Database.Migrate();
        }
    }
}
