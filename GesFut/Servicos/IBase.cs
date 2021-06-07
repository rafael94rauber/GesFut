using System;
using System.Collections.Generic;
using System.Text;

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
