using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    public static class StaticClassExample
    {

        public const string prop1 = "prop1_text";

        public static class AcademicClass
        {
            public const string AlreadyExist = "Exception:2";
        }
            public static class AcademicClass2
        {
            public const string AlreadyExist = "Exception:3";

            public static class MaisUma
            {
                public const string ImAnotherOne = "hahaha";
                public const string HeyhHoo = "hehe";

                public class MaisDuas
                {
                    public const string yy = "yyyy";
                }
            }
            
        }
            
        public static class AcademicClass4
            {
                public const string AlreadyExist = "Exception:4";
            }
            public static class AcademicClass5
            {
                public const string AlreadyExist = "Exception:5";
            }
    }
}