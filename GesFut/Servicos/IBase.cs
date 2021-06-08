using System;

namespace GesFut
{
    public interface IBaseSQL
    {
        public String GetInsert();
        public String GetUpdate();
        public String GetDelete();
        public String GetCampoCodigo();
    }
}
