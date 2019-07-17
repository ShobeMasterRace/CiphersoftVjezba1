using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ciphersoft_Vjezba
{
    public abstract class BaseModel
    {
        //Base model koji sadrži u sebi ID, posebna clasa zbog ID-a
        [Key]
        public int Id { get; set; }




    }
}
