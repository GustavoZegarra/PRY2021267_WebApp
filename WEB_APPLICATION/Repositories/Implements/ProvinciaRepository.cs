using WEB_APPLICATION.Models;

namespace WEB_APPLICATION.Repositories.Implements
{
    public class ProvinciaRepository:GenericRepository<Provincia>, IProvinciaRepository
    {
        public ProvinciaRepository(DbApiApplicationContext context):base (context)  {  }


    }
}
