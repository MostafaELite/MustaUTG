using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGenerator.TestingAssemebely
{
    public class DummyClass
    {
        public int  DummyMethod(Exception qs, int y , int v)
        {
            try
            {                
                if ( y > 5)
                    Console.WriteLine("c");
                return 2;
            }
            catch (NullReferenceException e) { }
            catch (ArgumentException e) { }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            SecondDummyClass s = new SecondDummyClass();
            s.m();
            return 5;

        }

    }
}
