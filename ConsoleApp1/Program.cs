using System;
using Dawn;
using net.adamec.lib.common.logging;

namespace ConsoleApp1
{
    class Program
    {
        private static ILogger Logger = CommonLogging.CreateLogger("Program");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            M(null);
        }

        public static void M(string a)
        {
            string bb;
           // bb = Guard.Argument(a, nameof(a));
          //  bb = E.L(Logger, Guard.Argument(a, nameof(a)).NotNull());
          //  string bb = Logger.Guard(() => Guard.Argument(a, nameof(a)).NotWhiteSpace().NotNull());
          //  bb = Logger.Guard(()=> Guard.Argument(a, nameof(a)).NotNull(), false);
           // bb = Logger.Guard(a, nameof(a), x => x.NotNull(), false);

            Nullable<int> i=1;
            int? i2=1;
            var r1=i.GetType().IsValueType;
            var r2 = i2.GetType().IsValueType;
        }
    }

    public delegate ref readonly Guard.ArgumentInfo<T> D<T>(in Guard.ArgumentInfo<T> argument);
    public delegate T D2<T>();
    public delegate T D3<T>(in Guard.ArgumentInfo<T> argument);
    public delegate T D4<T>( Guard.ArgumentInfo<T> argument);
    public static class E
    {
        public static T Guard<T>(this ILogger logger, T a, string name, D4<T> f, bool isFatal = true)
        {
            try
            {
               return f.Invoke(Dawn.Guard.Argument(a, nameof(a)));
            }
            catch (Exception ex)
            {
                if (isFatal)
                {
                    logger.Fatal(exception: ex, ex.Message);
                }
                else
                {
                    logger.Error(exception: ex, ex.Message);
                }


                throw;
            }
        }

        public static T Guard3<T>(this ILogger logger,T a,string name, D3<T> f, bool isFatal = true)
        {
            try
            {
                var x = Dawn.Guard.Argument(a, nameof(a));
                return f.Invoke(in x );
            }
            catch (Exception ex)
            {
                if (isFatal)
                {
                    logger.Fatal(exception: ex, ex.Message);
                }
                else
                {
                    logger.Error(exception: ex, ex.Message);
                }


                throw;
            }
        }
        public static  T Guard<T>(this ILogger logger,D2<T> f, bool isFatal = true)
        {
            try
            {
                return  f.Invoke();
            }
            catch (Exception ex)
            {
                if (isFatal)
                {
                    logger.Fatal(exception: ex, ex.Message);
                }
                else
                {
                    logger.Error(exception: ex, ex.Message);
                }


                throw;
            }
        }
        //public static ref readonly Guard.ArgumentInfo<T> L<T>(ILogger logger,in Guard.ArgumentInfo<T> argument)
        public static ref readonly Guard.ArgumentInfo<T> L<T>( ILogger logger, in Guard.ArgumentInfo<T> argument)
        {
            try
            {
                return ref argument;
            }
            catch (Exception ex)
            {
                logger.Fatal(exception:ex, ex.Message);
                throw;
            }
        }

       
    }
}
