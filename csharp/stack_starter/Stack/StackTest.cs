using NUnit.Framework;
using System;
using System.Collections;

namespace csharp
{
    public class Stack
    {
        public static bool isEmpty (System.Collections.Stack st)
        {
            return (st.Count == 0);
        }

        public static int size(System.Collections.Stack st)
        {
            return st.Count;
        }

        public static void push(ref System.Collections.Stack st, int x)
        {
            st.Push(x);
        }

        public static void pop(ref System.Collections.Stack st)
        {
            st.Pop();
        }

        public static object peek(System.Collections.Stack st)
        {
            return st.Peek();
        }
    }

    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Empty_Stack_IsEmpty()
        {
            System.Collections.Stack st = new System.Collections.Stack();

            Assert.IsTrue(Stack.isEmpty(st));
        }

        [Test]
        public void Stack_ReturnsCount()
        {
            System.Collections.Stack st = new System.Collections.Stack();
            var rand = new Random();
            int count = rand.Next(0, 5);

            for (int i = 0; i < count; i++)
            {
                Stack.push(ref st, i);
            }

            Assert.AreEqual(count,Stack.size(st));
        }

        [Test]
        public void Stack_Push_Adds5Items()
        {
            System.Collections.Stack st = new System.Collections.Stack();

            Stack.push(ref st, 0);

            for (int i = 0; i < 5; i++)
            {
                Stack.push(ref st, i);
            }

            Assert.AreEqual(6, Stack.size(st));
        }

        [Test]
        public void Stack_Pop_RemovesItem()
        {
            System.Collections.Stack st = new System.Collections.Stack();

            for (int i = 0; i < 5; i++)
            {
                Stack.push(ref st, i);
            }

            Stack.pop(ref st);

            Assert.AreEqual(4, Stack.size(st));
        }

        [Test]
        public void Stack_Peek_GetsItem()
        {
            System.Collections.Stack st = new System.Collections.Stack();

            Stack.push(ref st, 0);

            for (int i = 0; i < 5; i++)
            {
                Stack.push(ref st, i);
            }

            Stack.peek(st);

            Assert.AreEqual(4, Stack.peek(st));
        }
    }
}
