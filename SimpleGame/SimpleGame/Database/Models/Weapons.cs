using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Database.Models
{
    abstract class Weapons
    {
        public abstract void Shoot();

        public abstract void Reload();

        public abstract void Kit();

    }
}
