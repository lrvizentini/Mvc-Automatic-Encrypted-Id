using MvcHelpers.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyApp.Mvc.Models
{
    public class IndexViewModel
    {
        public EncryptedInt IntIdTest { get; set; }

        public EncryptedLong LongIdTest { get; set; }

    }
}