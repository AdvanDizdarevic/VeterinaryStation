using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeterinaryStation.Helper
{
    
        public interface IEntity
        {
            int Id { get; set; }
            bool IsDeleted { get; set; }

        }
    
}