using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FE {

    public static class Math {

        public static int RoundTowardsZero(float value){
            return ((int)(value * (value < 0 ? -1 : 1))) * (value < 0 ? -1 : 1);
        }

    }

}
