using System;
using HySON;
using NUnit.Framework;
using HySON = HySON.HySON;

namespace hySON
{
    [TestFixture]
    class HySONTest
    {
        [Test]
        public void Test1()
        {
            String jsonString = "{ \"value\" : 10 }";

            Test1Class t = global::HySON.HySON.parse<Test1Class>(jsonString, typeof(Test1Class));
            Assert.AreEqual(10, t.value);
        }

        [Test]
        public void Test2()
        {

        }

        [Test]
        public void Test3()
        {
            String jsonString = "{ \"temp\" : { \"value\" : 10 } }";
            Test3Class t = global::HySON.HySON.parse<Test3Class>(jsonString, typeof(Test3Class));

            Assert.AreEqual(10, t.temp.value);
        }

        [Test]
        public void Test4()
        {
            String jsonString = "{ \"temps\" : [ { \"value\" : 10 } ]}";
            Test4Class t = global::HySON.HySON.parse<Test4Class>(jsonString, typeof(Test4Class));

            Assert.NotNull(t);
            Assert.NotNull(t.temps);
            Assert.AreEqual(1, t.temps.Length);
            Assert.NotNull(t.temps[0]);
            Assert.AreEqual(10, t.temps[0].value);
        }

        [Test]
        public void Test5()
        {
            String jsonString = "{ \"temps\" : [ { \"value\" : 10 }, { \"value\" : 100 } ] }";
            Test5Class t = global::HySON.HySON.parse<Test5Class>(jsonString, typeof(Test5Class));
            
            Assert.NotNull(t);
            Assert.NotNull(t.temps);
            Assert.AreEqual(2, t.temps.Count);
            
            Assert.NotNull(t.temps[0]);
            Assert.AreEqual(10, t.temps[0].value);
            
            Assert.NotNull(t.temps[1]);
            Assert.AreEqual(100, t.temps[1].value);
        }

        [Test]
        public void Test6()
        {
            String jsonString = "{ \"member1\" : [ { \"temp\" : { \"value\" : 0 } }, { \"temp\" : { \"value\" : 100 } } ] }";
            Test6Class t = global::HySON.HySON.parse<Test6Class>(jsonString, typeof(Test6Class));
            
            Assert.NotNull(t);
            Assert.NotNull(t.member1);
            Assert.AreEqual(2, t.member1.Count);
            
            Assert.NotNull(t.member1[0]);
            Assert.NotNull(t.member1[0].temp);
            Assert.AreEqual(0, t.member1[0].temp.value);
            
            Assert.NotNull(t.member1[1]);
            Assert.NotNull(t.member1[1].temp);
            Assert.AreEqual(100, t.member1[1].temp.value);
        }

        [Test]
        public void Test7()
        {
            String jsonString = "{\"a\": 10, \"b\" : \"횟횟\", \"c\" : [2, 3, 4], \"d\": [5, 6], \"temps\":[{\"value\": 20}]}";
            Test7Class t = global::HySON.HySON.parse<Test7Class>(jsonString, typeof(Test7Class));
            
            Assert.NotNull(t);
            Assert.AreEqual(10, t.a);
            Assert.AreEqual("횟횟", t.b);
            
            Assert.NotNull(t.c);
            Assert.AreEqual(3, t.c.Count);
            Assert.AreEqual(2, t.c[0]);
            Assert.AreEqual(3, t.c[1]);
            Assert.AreEqual(4, t.c[2]);
            
            Assert.NotNull(t.d);
            Assert.AreEqual(2, t.d.Length);
            Assert.AreEqual(5, t.d[0]);
            Assert.AreEqual(6, t.d[1]);
            
            Assert.NotNull(t.temps);
            Assert.AreEqual(1, t.temps.Count);
            Assert.NotNull(t.temps[0]);
            Assert.AreEqual(20, t.temps[0].value);
        }

    }
}
