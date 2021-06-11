using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISigmaSystek.Helpers
{
    public class ExceptionHelper
    {
        public static Exception GetException(Exception exc)
        {
            while (exc.InnerException != null)
            {
                exc = exc.InnerException;
            }
            //Prueba de cambio
            //if (exc.Message.Contains("EntityValidationErrors"))
            //{
            //    string errorValidacion = string.Empty;
            //    DbEntityValidationException ex = exc as DbEntityValidationException;
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        errorValidacion += string.Format("'{0}', estado: '{1}'", eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            errorValidacion += string.Format("- '{0}': '{1}'", ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }

            //    exc = new Exception(errorValidacion);
            //}

            return exc;
        }
    }
}