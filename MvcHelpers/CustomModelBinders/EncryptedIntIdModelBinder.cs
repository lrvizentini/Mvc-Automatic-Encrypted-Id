using MvcHelpers.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHelpers.CustomModelBinders
{

    public class EncryptedIntModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            ModelState modelState = new ModelState { Value = valueResult };
            EncryptedInt actualValue = new EncryptedInt();

            try
            {
                var isNullableAndNull = (bindingContext.ModelMetadata.IsNullableValueType && string.IsNullOrEmpty(valueResult.AttemptedValue));

                if (valueResult != null && !isNullableAndNull)
                {
                    int idValue = 0;
                    if (int.TryParse(valueResult.AttemptedValue, out idValue))
                    {
                        actualValue = new EncryptedInt(idValue);
                    }
                    else
                    {
                        actualValue = new EncryptedInt(valueResult.AttemptedValue);
                    }
                }
            }
            catch (FormatException e)
            {
                modelState.Errors.Add(e);
            }

            bindingContext.ModelState.Add(bindingContext.ModelName, modelState);
            return actualValue;
        }
    }

    public class EncryptedLongModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            ModelState modelState = new ModelState { Value = valueResult };
            EncryptedLong actualValue = new EncryptedLong();

            try
            {
                var isNullableAndNull = (bindingContext.ModelMetadata.IsNullableValueType && string.IsNullOrEmpty(valueResult.AttemptedValue));

                if (valueResult != null && !isNullableAndNull)
                {
                    long idValue = 0;
                    if (long.TryParse(valueResult.AttemptedValue, out idValue))
                    {
                        actualValue = new EncryptedLong(idValue);
                    }
                    else
                    {
                        actualValue = new EncryptedLong(valueResult.AttemptedValue);
                    }
                }
            }
            catch (FormatException e)
            {
                modelState.Errors.Add(e);
            }

            bindingContext.ModelState.Add(bindingContext.ModelName, modelState);
            return actualValue;
        }
    }

}