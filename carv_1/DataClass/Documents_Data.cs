using ModelsClass.Data;
using ModelsClass.MethodParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataClass
{
    public class Documents_Data
    {
        private AppContext _context;
        public Documents_Data()
        {
            _context = new AppContext();
        }

        public IdTypesOut GetDocuments()
        {
            IdTypesOut output = new IdTypesOut() { Result = ModelsClass.Common.Result.error };
            output.IdTypes = new List<IdType>();
            try
            {
                var idDocs = _context.IdentificationTypes.Select(m => m).ToList();

                idDocs.ForEach(delegate (IdentificationType ids)
                {
                    output.IdTypes.Add(new IdType()
                    {
                        Code = ids.Code,
                        Id = ids.Id,
                        IdentificationName = ids.IdentificationName
                    });
                });

                if(output.IdTypes.Count > 0)
                {
                    output.Result = ModelsClass.Common.Result.success;
                }
                else
                {
                    output.Result = ModelsClass.Common.Result.notFound;
                    output.Message = "No hay tipos de documentos cargados en la base de datos";
                }
            }
            catch (Exception ex)
            {
                output.Message = ex.Message;
            }
            return output;
        }
    }
}
