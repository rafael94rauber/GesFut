using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    public interface IBaseSQL
    {
        public abstract String GetInsert();
        public abstract String GetUpdate();
        public abstract String GetDelete();
    }
}
