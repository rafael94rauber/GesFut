using System;
using System.Collections.Generic;
using System.Text;

namespace GesFut
{
    public interface IBaseSQL
    {
        public abstract string GetInsert();
        public abstract string GetUpdate();
        public abstract string GetDelete();
    }
}
