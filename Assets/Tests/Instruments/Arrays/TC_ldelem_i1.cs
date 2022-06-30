﻿using SharpUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Instruments.Arrays
{
    internal class TC_ldelem_i1 : GeneralTestCaseBase
    {

        [UnitTest]
        public void ld_1()
        {
            var arr = new sbyte[] {-1, 1};
            var x = arr[0];
            Assert.Equal(-1, x);
            var y = arr[1];
            Assert.Equal(1, y);

            var x2 = ArrayVerifyUtil.Get(arr, 0);
            Assert.Equal(-1, x2);
            var y2 = ArrayVerifyUtil.Get(arr, 1);
            Assert.Equal(1, y2);
        }

        [UnitTest]
        public void OutOfRange_lower()
        {
            var arr = new sbyte[] { -1, 1 };
            Assert.ExpectException<IndexOutOfRangeException>();
            var s = arr[-1];
            Assert.Fail();
        }

        [UnitTest]
        public void OutOfRange_upper()
        {
            var arr = new sbyte[] { -1, 1 };
            Assert.ExpectException<IndexOutOfRangeException>();
            var s = arr[2];
            Assert.Fail();
        }

        [UnitTest]
        public void NullRef()
        {
            sbyte[] arr = null;
            Assert.ExpectException<NullReferenceException>();
            var s = arr[0];
            Assert.Fail();
        }
    }
}
