using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektovanjePoSlojevimaStudijeApp.BusinessLayer
{
    public class OperationManager
    {
        #region Singleton
        private OperationManager()
        { }

        private volatile static OperationManager singleton;
        private static object syncObj = new object();

        public static OperationManager Singleton
        {
            get
            {
                if(OperationManager.singleton == null)
                {
                    lock(syncObj)
                    {
                        if (OperationManager.singleton == null)
                            OperationManager.singleton = new OperationManager();
                    }
                }
                return OperationManager.singleton;
            }
        }
        #endregion

        public OperationResult executeOp(Operation op)
        {
            try
            {
                return op.execute();
            }
            catch(Exception ex)
            {
                OperationResult obj = new OperationResult();
                obj.Status = false;
#if (DEBUG)
                // U debug modu se prikazuje poruka iz izuzetka,
                // koju treba da vidi programer ili onaj ko testira softver,
                // a nikako je ne treba prikazivati korisniku softvera.
                obj.Message = ex.Message;
#else
                // U release modu se prikazuje poruka za korisnika softvera
                obj.Message = "Greška: Operacija nije uspela, možda zbog toga što su podaci u međuvremenu promenjeni!";
#endif
                return obj;
            }
        }
    }
}
