using System;

namespace GesFut
{
    public interface IBaseSQL
    {
        public string GetInsert();
        public string GetUpdate();
        public string GetDelete();
        public string GetCampoCodigo();
        public string GetUpdate(int id);
        public string GetDelete(int id);
    }
}
