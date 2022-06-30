﻿using SharpUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Instruments.Arrays
{
    internal class TC_stelem_i8 : GeneralTestCaseBase
    {

        [UnitTest]
        public void st_1()
        {
            var arr = new long[2];
            arr[0] = -1;
            arr[1] = 1;

            var x = arr[0];
            Assert.Equal(-1, x);
            var y = arr[1];
            Assert.Equal(1, y);
        }

        [UnitTest]
        public void OutOfRange_lower()
        {
            var arr = new long[2];
            Assert.ExpectException<IndexOutOfRangeException>();
            arr[-1] = 1;
            Assert.Fail();
        }

        [UnitTest]
        public void OutOfRange_upper()
        {
            var arr = new long[2];
            Assert.ExpectException<IndexOutOfRangeException>();
            arr[2] = 1;
            Assert.Fail();
        }

        [UnitTest]
        public void NullRef()
        {
            long[] arr = null;
            Assert.ExpectException<NullReferenceException>();
            arr[0] = 1;
            Assert.Fail();
        }
    }
}
