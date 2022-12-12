using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    sealed public class DalList : IDal
    {
        public IStudent Student => new Student();

        public ICourse Course => new Course();

        public IGrade Grade => new GradeInCourse();
    }
}
