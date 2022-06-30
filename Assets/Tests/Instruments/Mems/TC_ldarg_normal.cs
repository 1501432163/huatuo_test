﻿using System;
using SharpUnit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using AOTDefs;

namespace Tests.Instruments.Mems
{
    class TC_ldarg_normal : GeneralTestCaseBase
    {
        private static void s_bool_1(bool a)
        {
            Assert.Equal(true, a);
        }

        [UnitTest]
        public void bool_1()
        {
            s_bool_1(true);
        }

        private static void s_bool_2(bool a)
        {
            Assert.Equal(false, a);
        }

        [UnitTest]
        public void bool_2()
        {
            s_bool_2(false);
        }

        private static void s_byte_1(byte a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void byte_1()
        {
            s_byte_1(1);
        }

        private static void s_sbyte_1(sbyte a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void sbyte_1()
        {
            s_sbyte_1(1);
        }
        private static void s_sbyte_2(sbyte a)
        {
            Assert.Equal(-1, a);
        }

        [UnitTest]
        public void sbyte_2()
        {
            s_sbyte_2(-1);
        }

        private static void s_short_1(short a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void short_1()
        {
            s_short_1(1);
        }

        private static void s_short_2(short a)
        {
            Assert.Equal(-1, a);
        }

        [UnitTest]
        public void short_2()
        {
            s_short_2(-1);
        }

        private static void s_char_1(char a)
        {
            Assert.Equal('a', a);
        }

        [UnitTest]
        public void char_1()
        {
            s_char_1('a');
        }

        private static void s_int_1(int a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void int_1()
        {
            s_int_1(1);
        }

        private static void s_int_2(int a)
        {
            Assert.Equal(-1, a);
        }

        [UnitTest]
        public void int_2()
        {
            s_int_2(-1);
        }

        private static void s_uint_1(uint a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void uint_1()
        {
            s_uint_1(1);
        }


        private static void s_long_1(long a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void long_1()
        {
            s_long_1(1);
        }

        private static void s_long_2(long a)
        {
            Assert.Equal(-1, a);
        }

        [UnitTest]
        public void long_2()
        {
            s_long_2(-1);
        }

        private static void s_ulong_1(ulong a)
        {
            Assert.Equal(1, a);
        }

        [UnitTest]
        public void ulong_1()
        {
            s_ulong_1(1);
        }

        private static void s_float_1(float a)
        {
            Assert.Equal(1f, a);
        }

        [UnitTest]
        public void float_1()
        {
            s_float_1(1f);
        }

        private static void s_double_1(double a)
        {
            Assert.Equal(1.0, a);
        }

        [UnitTest]
        public void double_1()
        {
            s_double_1(1.0);
        }


        private static void s_valuetype_1(ValueTypeSize1 a)
        {
            Assert.Equal(1, a.x1);
        }

        [UnitTest]
        public void valuetype_1()
        {
            s_valuetype_1(new ValueTypeSize1 { x1 = 1 });
        }

        private static void s_valuetype_2(ValueTypeSize2 a)
        {
            Assert.Equal(1, a.x1);
            Assert.Equal(2, a.x2);
        }

        [UnitTest]
        public void valuetype_2()
        {
            s_valuetype_2(new ValueTypeSize2 { x1 = 1, x2 = 2 });
        }


        private static void s_valuetype_3(ValueTypeSize3 a)
        {
            Assert.Equal(1, a.x1);
            Assert.Equal(2, a.x2);
            Assert.Equal(3, a.x3);
        }

        [UnitTest]
        public void valuetype_3()
        {
            s_valuetype_3(new ValueTypeSize3 { x1 = 1, x2 = 2, x3 = 3 });
        }


        private static void s_valuetype_4(ValueTypeSize4 a)
        {
            Assert.Equal(1, a.x1);
        }

        [UnitTest]
        public void valuetype_4()
        {
            s_valuetype_4(new ValueTypeSize4 { x1 = 1 });
        }

        private static void s_valuetype_5(ValueTypeSize5 a)
        {
            Assert.Equal(1, a.x1);
            Assert.Equal(2, a.x2);
            Assert.Equal(3, a.x3);
            Assert.Equal(4, a.x4);
            Assert.Equal(5, a.x5);
        }

        [UnitTest]
        public void valuetype_5()
        {
            s_valuetype_5(new ValueTypeSize5 { x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5 });
        }

        private static void s_valuetype_8(ValueTypeSize8 a)
        {
            Assert.Equal(1, a.x1);
        }

        [UnitTest]
        public void valuetype_8()
        {
            s_valuetype_8(new ValueTypeSize8 { x1 = 1, });
        }

        private static void s_valuetype_9(ValueTypeSize9 a)
        {
            Assert.Equal(1, a.x1);
            Assert.Equal(2, a.x2);
            Assert.Equal(3, a.x3);
            Assert.Equal(4, a.x4);
            Assert.Equal(5, a.x5);
            Assert.Equal(6, a.x6);
            Assert.Equal(7, a.x7);
            Assert.Equal(8, a.x8);
            Assert.Equal(9, a.x9);
        }

        [UnitTest]
        public void valuetype_9()
        {
            s_valuetype_9(new ValueTypeSize9 { x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5, x6 = 6, x7 = 7, x8 = 8, x9 = 9 });
        }

        private static void s_valuetype_16(ValueTypeSize16 a)
        {
            Assert.Equal(1, a.x1);
            Assert.Equal(2, a.x2);
        }

        [UnitTest]
        public void valuetype_16()
        {
            s_valuetype_16(new ValueTypeSize16 { x1 = 1, x2 = 2});
        }

        private static void s_valuetype_20(ValueTypeSize20 a)
        {
            Assert.Equal(1, a.x1);
            Assert.Equal(2, a.x2);
            Assert.Equal(3, a.x3);
            Assert.Equal(4, a.x4);
            Assert.Equal(5, a.x5);
        }

        [UnitTest]
        public void valuetype_20()
        {
            s_valuetype_20(new ValueTypeSize20 { x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5 });
        }

        private static void s_multi_args(bool a1, byte a2, sbyte a3, short a4, ushort a5, char a6, int a7, uint a8, long a9, ulong a10,
            float b1, double b2, object b3)
        {
            Assert.True(a1);
            Assert.Equal(2, a2);
            Assert.Equal(3, a3);
            Assert.Equal(4, a4);
            Assert.Equal(5, a5);
            Assert.Equal('a', a6);
            Assert.Equal(7, a7);
            Assert.Equal(8, a8);
            Assert.Equal(9, a9);
            Assert.Equal(10, a10);
            Assert.Equal(11f, b1);
            Assert.Equal(12.0, b2);
            Assert.Equal("abc", b3);
        }

        [UnitTest]
        public void multi_args()
        {
            s_multi_args(true, 2, 3, 4, 5, 'a', 7, 8, 9, 10, 11f, 12.0, "abc");
        }

        private static void s_multi_args2(ValueTypeSize1 a1, ValueTypeSize2 a2, ValueTypeSize3 a3, ValueTypeSize4 a4, ValueTypeSize5 a5,
            ValueTypeSize8 a8, ValueTypeSize9 a9, ValueTypeSize16 b1, ValueTypeSize20 b2)
        {
            Assert.Equal(1, a1.x1);
            Assert.Equal(2, a2.x1);
            Assert.Equal(3, a3.x1);
            Assert.Equal(4, a4.x1);
            Assert.Equal(5, a5.x1);
            Assert.Equal(8, a8.x1);
            Assert.Equal(9, a9.x1);
            Assert.Equal(16, b1.x1);
            Assert.Equal(20, b2.x1);
        }

        [UnitTest]
        public void multi_args2()
        {
            s_multi_args2(
                new ValueTypeSize1 { x1 = 1},
                new ValueTypeSize2 { x1 = 2},
                new ValueTypeSize3 { x1 = 3},
                new ValueTypeSize4 { x1 = 4},
                new ValueTypeSize5 { x1 = 5},
                new ValueTypeSize8 { x1 = 8},
                new ValueTypeSize9 { x1 = 9},
                new ValueTypeSize16 { x1 = 16},
                new ValueTypeSize20 { x1 = 20}
                );
        }
    }
}
