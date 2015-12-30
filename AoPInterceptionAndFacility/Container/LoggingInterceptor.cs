using AoPInterceptionAndFacility.Model;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;

namespace AoPInterceptionAndFacility.Container
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.ReturnType == typeof(Int32))
            {
                Console.WriteLine("GetCategoryId method is called..");
                invocation.Proceed();
            }
            else if (invocation.Method.ReturnType == typeof(string))
            {
                Console.WriteLine("GetCategoryNameById method is called..");
                invocation.Proceed();
            }
            else if (invocation.Method.ReturnType == typeof(List<Category>))
            {
                Console.WriteLine("ListCategory method is called..");
                invocation.Proceed();
            }
            else if (invocation.Method.ReturnType == typeof(Category))
            {
                Console.WriteLine("LoadCategory method is called..");
                invocation.Proceed();
            }
        }
    }
}
