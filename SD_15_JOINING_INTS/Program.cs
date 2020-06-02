using System;
using System.Text;

namespace SD_15_JOINING_INTS
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\n\n");
            Console.WriteLine(new string('#', 40));
            Console.WriteLine("\t\t\tMIN MAX PROGRAM");
            Console.WriteLine(new string('#', 40));


            if (args.Length == 0)
            {
                Console.WriteLine("\tThere were no args given.");
                Console.WriteLine("\n");
                Console.WriteLine("\tEnd of program.");
                Environment.Exit(0);
            }


            uint[] argsAsUints = new uint[args.Length];
            int DroppedCounter = 0;
            for (uint i = 0; i < args.Length; i++)
            {
                if (uint.TryParse(args[i], out uint parseOK))
                {
                    argsAsUints[i] = parseOK;
                }
                else
                {
                    DroppedCounter++;
                }
            }
            Array.Resize(ref argsAsUints, (argsAsUints.Length - DroppedCounter));
            Array.Sort(argsAsUints);

            uint[] _copy = new uint[argsAsUints.Length];


            argsAsUints.CopyTo(_copy, 0);
            string _min = MIN_V_2(_copy);
            try
            {
                Convert.ToUInt32(_min);
            }
            catch (Exception)
            {
                _min = "greater than uint.MaxValue";
            }
            finally
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\tMin numeric created of given numbers is {0}", _min);
            }


            argsAsUints.CopyTo(_copy, 0);
            string _max = MAX_V_2(_copy);
            try
            {
                Convert.ToUInt32(_max);
            }
            catch (Exception)
            {
                _max = "greater than uint.MaxValue";
            }
            finally
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\tMax numeric created of given numbers is {0}", _max);
            }


            Console.WriteLine("\n\n");
            Console.WriteLine(new string('#', 40));
            Console.WriteLine("\t\t\t End of program.");
            Console.WriteLine(new string('#', 40));

        }


        public static string MIN_V_2(uint[] argsAsuints)
        {
            StringBuilder _min = new StringBuilder();
            for (uint external = 0; external < argsAsuints.Length; external++)
            {
                uint minValue = uint.MaxValue;
                uint cutIndexOf = 0;

                for (uint i = 0; i < argsAsuints.Length; i++)
                {
                    if (argsAsuints[i] != UInt32.MaxValue)
                    {
                        uint _temp = GetLeftmostDigit(argsAsuints[i]);
                        if (_temp < minValue)
                        {
                            minValue = _temp;
                            cutIndexOf = i;
                        }
                    }
                }
                minValue = argsAsuints[cutIndexOf];
                argsAsuints[cutIndexOf] = uint.MaxValue;
                _min.Append(minValue);
            }


            return _min.ToString();
        }


        public static uint GetLeftmostDigit(uint nb)
        {
            while (nb >= 10)
                nb /= 10;
            return nb;
        }


        public static string MAX_V_2(uint[] argsAsuints)
        {
            StringBuilder _max = new StringBuilder();
            for (uint external = 0; external < argsAsuints.Length; external++)
            {
                uint maxValue = 0;
                uint cutIndex = 0;

                for (uint i = 0; i < argsAsuints.Length; i++)
                {
                    uint _temp = GetLeftmostDigit(argsAsuints[i]);
                    if (_temp > maxValue)
                    {
                        maxValue = _temp;
                        cutIndex = i;
                    }
                }
                maxValue = argsAsuints[cutIndex];
                argsAsuints[cutIndex] = 0;
                _max.Append(maxValue);
            }


            return _max.ToString();
        }


    }
}
