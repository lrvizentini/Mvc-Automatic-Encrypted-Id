using MvcHelpers.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcHelpers.CustomModelBinders
{
    public class EncryptedBindingExtension
    {
        public static void UseCustomBinders()
        {
            ModelBinders.Binders.Add(typeof(EncryptedInt), new EncryptedIntModelBinder());
            ModelBinders.Binders.Add(typeof(EncryptedLong), new EncryptedIntModelBinder());
        }
    }
}
