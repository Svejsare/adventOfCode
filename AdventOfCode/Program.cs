using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {

            //LuckaEtt();
            //LuckaTvå();
            //LuckaTvåTvå();
            //LuckaTre();
            //LuckaTreTre();
            //LuckaFyra();
            //LuckaFyraFyra();
            LuckaFem();

            //Console.WriteLine(sum);
        }


        public static void LuckaFem()
        {

            var result = CalcLuckaFem();

            Console.WriteLine("Result: " + result);

        }


        public static int CalcLuckaFem()
        {
            int[] ints = new int[678] { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 1101, 40, 27, 224, 101, -67, 224, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 2, 224, 1, 224, 223, 223, 1101, 33, 38, 225, 1102, 84, 60, 225, 1101, 65, 62, 225, 1002, 36, 13, 224, 1001, 224, -494, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 3, 224, 1, 223, 224, 223, 1102, 86, 5, 224, 101, -430, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 6, 224, 224, 1, 223, 224, 223, 1102, 23, 50, 225, 1001, 44, 10, 224, 101, -72, 224, 224, 4, 224, 102, 8, 223, 223, 101, 1, 224, 224, 1, 224, 223, 223, 102, 47, 217, 224, 1001, 224, -2303, 224, 4, 224, 102, 8, 223, 223, 101, 2, 224, 224, 1, 223, 224, 223, 1102, 71, 84, 225, 101, 91, 40, 224, 1001, 224, -151, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 5, 224, 1, 223, 224, 223, 1101, 87, 91, 225, 1102, 71, 19, 225, 1, 92, 140, 224, 101, -134, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 1, 224, 224, 1, 224, 223, 223, 2, 170, 165, 224, 1001, 224, -1653, 224, 4, 224, 1002, 223, 8, 223, 101, 5, 224, 224, 1, 223, 224, 223, 1101, 49, 32, 225, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 1107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 329, 101, 1, 223, 223, 8, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 344, 101, 1, 223, 223, 1007, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 359, 101, 1, 223, 223, 8, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 374, 101, 1, 223, 223, 1107, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 389, 1001, 223, 1, 223, 108, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 404, 1001, 223, 1, 223, 108, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 419, 101, 1, 223, 223, 107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 434, 101, 1, 223, 223, 108, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 449, 1001, 223, 1, 223, 8, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 464, 101, 1, 223, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 479, 1001, 223, 1, 223, 1108, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 494, 101, 1, 223, 223, 7, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 509, 101, 1, 223, 223, 1007, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 524, 101, 1, 223, 223, 7, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 539, 101, 1, 223, 223, 1107, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 554, 101, 1, 223, 223, 107, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 569, 101, 1, 223, 223, 107, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 584, 101, 1, 223, 223, 1108, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 599, 1001, 223, 1, 223, 1008, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 614, 101, 1, 223, 223, 7, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 629, 101, 1, 223, 223, 1008, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 644, 101, 1, 223, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 659, 1001, 223, 1, 223, 1008, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 674, 1001, 223, 1, 223, 4, 223, 99, 226 };

            var input = 1;
            var step = 4;

            for (var i = 0; i < ints.Length; i += step)
            {
                var asString = ints[i].ToString();
                step = asString.Length - 1;
                var code = Int32.Parse(asString.Substring(asString.Length - 1));
                var param1 = Int32.Parse(asString.Substring(asString.Length - 3, 1));
                var param2 = Int32.Parse(asString.Substring(asString.Length - 4, 1));
                var param3 = Int32.Parse(asString.Substring(asString.Length - 5, 1));

                switch (code)
                {
                    case 1:
                        var par1 = 0;
                        var par2 = 0;
                        switch (param1)
                        {
                            case 0:
                                par1 = ints[ints[i + 1]];
                                break;
                            case 1:
                                par1 = ints[i + 1];
                                break;
                        }
                        switch (param2)
                        {
                            case 0:
                                par2 = ints[ints[i + 2]];
                                break;
                            case 1:
                                par2 = ints[i + 2];
                                break;
                        }
                        ints[ints[i + 3]] = par1 + par2;
                        break;
                    case 2:
                        par1 = 0;
                        par2 = 0;
                        switch (param1)
                        {
                            case 0:
                                par1 = ints[ints[i + 1]];
                                break;
                            case 1:
                                par1 = ints[i + 1];
                                break;
                        }
                        switch (param2)
                        {
                            case 0:
                                par2 = ints[ints[i + 2]];
                                break;
                            case 1:
                                par2 = ints[i + 2];
                                break;
                        }
                        ints[ints[i + 3]] = par1 * par2;
                        break;
                    case 3:
                        ints[i + 1] = 1;
                        break;
                    case 4:
                        Console.WriteLine(ints[i + 1]);
                        break;
                    case 99:
                        //Console.WriteLine("Hit 99");
                        i += 1;
                        continue;
                    default:
                        break;

                }
            }

            return ints[0];

        }

        public static void LuckaFyraFyra()
        {
            var min = 234208;
            var max = 765869;

            var validInputs = 0;

            for (var i = min; i <= max; i++)
            {
                List<int> arr = new List<int>();
                var str = i.ToString();

                for (var p = 0; p < str.Length; p++)
                {
                    arr.Add(Int32.Parse(str[p].ToString()));
                }

                //Console.WriteLine(arr);
                int previous = 0;

                var s = 0;

                while (s < arr.Count)
                {
                    //Console.WriteLine(previous);
                    var isLower = false;
                    if ((s + 1) < arr.Count)
                    {
                        for (var v = 0; v < arr.Count; v++)
                        {
                            if ((v + 1) < arr.Count && arr[v] > arr[v + 1])
                            {
                                isLower = true;
                            }
                        }
                        if (isLower)
                        {
                            previous = arr[s];
                            s = 99999;
                            continue;
                        }
                    }


                    var group = arr.GroupBy(x => x);

                    if (group.Any(g => g.Count() == 2))
                    {
                        validInputs++;
                        previous = arr[s];
                        s = 99999;
                        continue;
                    }

                    //if (arr[s] == previous)
                    //{
                    //    var g = arr.GroupBy(x => x).ToList();
                    //    if (s < arr.Count && s < 5 && arr[s] != arr[s + 1])
                    //    {
                    //        validInputs++;
                    //        previous = arr[s];
                    //        s = 99999;
                    //        continue;
                    //    }
                    //}
                    previous = arr[s];
                    s++;
                }
            }

            Console.WriteLine(validInputs);

        }

        public static void LuckaFyra()
        {
            var min = 234208;
            var max = 765869;

            var validInputs = 0;

            for (var i = min; i <= max; i++)
            {
                var str = i.ToString();
                char[] arr = str.ToCharArray(0, 6);
                //Console.WriteLine(arr);
                char previous = new Char();

                var s = 0;

                while (s < arr.Length)
                {
                    //Console.WriteLine(previous);
                    var isLower = false;
                    if ((s + 1) < arr.Length)
                    {
                        for (var v = 0; v < arr.Length; v++)
                        {
                            if ((v + 1) < arr.Length && (int)arr[v] > arr[v + 1])
                            {
                                isLower = true;
                            }
                        }
                        if (isLower)
                        {
                            previous = arr[s];
                            s = 99999;
                            continue;
                        }
                    }
                    if (arr[s] == previous)
                    {
                        validInputs++;
                        previous = arr[s];
                        s = 99999;
                        continue;
                    }
                    previous = arr[s];
                    s++;
                }
            }

            Console.WriteLine(validInputs);

        }

        public static void LuckaTreTre()
        {
            string[,] matrix = new string[20000, 20000];

            var currentX = 10000;
            var currentY = 10000;

            string[] input1 = new string[301] { "R998", "U547", "L703", "D251", "L776", "U837", "R100", "U240", "R197", "D216", "L220", "U606", "L437", "U56", "R940", "U800", "L968", "D464", "L870", "D797", "L545", "D824", "R790", "U5", "R347", "D794", "R204", "U538", "L247", "U385", "L103", "D260", "L590", "U813", "L549", "U309", "L550", "U321", "R862", "D686", "R368", "D991", "R451", "D836", "R264", "D138", "L292", "D319", "L784", "D369", "R849", "U865", "R776", "D726", "R223", "D118", "L790", "D208", "L836", "D592", "R310", "D36", "R991", "U674", "L205", "U407", "R422", "U350", "L126", "D320", "L239", "U353", "L509", "U48", "R521", "D544", "L157", "D551", "R614", "D493", "R407", "D965", "R498", "U248", "R826", "U573", "L782", "D589", "R616", "D992", "L806", "D745", "R28", "U142", "L333", "D849", "L858", "D617", "R167", "U341", "R46", "U940", "L615", "D997", "L447", "D604", "R148", "U561", "R925", "D673", "R441", "U200", "R458", "U193", "L805", "D723", "L208", "U600", "L926", "U614", "R660", "D183", "L408", "D834", "R248", "U354", "L110", "U391", "L37", "U599", "L287", "U28", "R859", "D936", "L404", "D952", "R11", "U20", "R708", "U218", "L800", "U750", "R936", "D213", "R6", "D844", "R728", "D391", "R114", "U406", "R390", "U791", "L199", "D397", "R476", "D583", "R99", "U419", "R575", "D836", "L896", "U780", "L77", "U964", "R441", "U723", "R248", "D170", "R527", "D94", "L39", "U645", "L338", "D728", "R503", "U641", "L358", "D287", "R171", "U368", "R176", "D986", "R821", "U912", "L231", "D206", "L451", "U900", "L35", "D490", "R190", "D180", "L937", "D500", "R157", "U989", "L336", "U202", "R178", "U52", "R931", "U306", "L85", "D866", "R756", "U715", "L521", "D977", "R936", "U4", "R207", "D384", "L785", "U138", "L682", "U488", "L537", "U250", "L877", "D446", "R849", "U35", "R258", "U784", "R263", "D494", "L324", "U601", "R302", "U473", "L737", "D143", "R184", "D967", "R95", "U51", "L713", "U733", "R297", "U740", "R677", "D715", "R750", "U143", "L980", "U260", "R915", "D535", "R202", "U460", "R365", "U956", "L73", "U441", "R182", "D982", "L869", "D755", "L837", "D933", "L856", "D341", "R189", "D519", "L387", "D144", "R575", "U682", "R317", "U838", "R154", "D201", "R237", "D410", "L43", "U853", "L495", "U983", "L953", "U220", "R697", "D592", "R355", "U377", "R792", "U824", "L441", "U783", "R258", "D955", "R451", "D178", "L151", "D435", "L232", "U923", "L663", "U283", "L92", "D229", "R514" };
            string[] input2 = new string[301] { "L995", "U122", "R472", "U470", "R725", "U906", "L83", "U672", "R448", "U781", "L997", "U107", "R66", "D966", "L780", "D181", "L662", "U158", "R804", "D837", "L237", "U164", "L98", "U582", "R925", "D806", "L153", "D843", "R601", "U941", "L968", "D528", "R482", "D586", "R15", "U370", "L592", "U836", "R828", "U676", "R606", "D20", "R841", "U117", "L262", "U377", "R375", "U503", "R166", "D398", "R161", "D9", "R140", "D188", "R895", "D226", "R77", "U28", "L727", "D72", "L51", "U425", "R370", "D377", "L801", "D525", "R102", "D568", "L416", "D300", "R415", "U199", "R941", "U211", "R285", "U719", "L259", "U872", "L959", "U350", "L196", "D830", "R515", "U899", "R298", "U875", "R946", "U797", "R108", "U461", "R999", "D49", "L369", "D472", "R83", "D265", "L825", "D163", "R162", "U906", "L816", "D241", "L587", "D801", "R601", "D630", "R937", "U954", "L379", "D347", "R831", "D337", "L192", "D649", "L853", "U270", "R162", "D892", "L26", "D663", "L276", "U891", "R843", "U67", "R225", "D88", "R686", "U662", "R794", "D814", "L200", "D887", "R567", "U363", "L863", "U16", "R975", "D470", "R714", "U771", "L267", "D402", "R75", "U98", "L686", "U565", "R584", "D402", "L824", "D927", "R71", "U39", "L174", "D494", "L358", "D626", "R616", "D369", "R471", "U881", "L428", "U53", "R862", "U749", "L847", "D944", "L887", "D695", "R442", "U870", "L993", "U315", "L878", "U100", "L480", "D354", "L12", "D533", "L236", "D364", "R450", "U679", "L926", "D391", "R313", "D953", "L560", "D740", "L974", "D119", "L370", "U404", "R339", "U233", "R901", "U514", "R584", "D495", "R308", "U170", "R759", "U592", "R388", "U396", "R477", "U670", "R906", "D687", "L874", "U352", "R124", "U700", "R289", "D524", "L93", "D817", "R408", "D776", "L235", "D928", "L534", "D296", "R116", "U995", "L63", "D903", "R758", "U881", "L530", "U498", "R573", "D626", "L26", "U269", "R237", "U287", "L840", "D603", "R948", "D567", "R89", "U552", "L299", "D774", "R863", "D182", "R773", "D108", "L137", "U88", "L731", "U793", "L267", "U902", "L41", "U258", "L156", "U361", "R389", "D839", "L976", "U960", "L342", "D489", "R816", "U391", "L393", "U601", "R255", "D629", "R832", "U877", "L34", "D373", "L809", "D679", "L104", "U901", "R157", "U468", "R143", "U896", "L637", "D577", "L545", "D486", "L970", "D130", "L305", "D909", "R984", "D500", "L935", "U949", "R525", "D547", "L786", "U106", "L269", "D511", "L919" };

            for (var i = 0; i < input1.Length; i++)
            {
                var steps = Int32.Parse(input1[i].Substring(1));
                var direction = input1[i].Substring(0, 1);

                switch (direction)
                {
                    case "R":
                        var r = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[r + s, currentY] = "1";
                            currentX++;
                        }
                        break;
                    case "L":
                        var l = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[l - s, currentY] = "1";
                            currentX--;
                        }
                        break;
                    case "U":
                        var u = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[currentX, u + s] = "1";
                            currentY++;
                        }
                        break;
                    case "D":
                        var d = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[currentX, d - s] = "1";
                            currentY--;
                        }
                        break;
                    default:
                        break;
                }
            }

            currentX = 10000;
            currentY = 10000;

            var nrOfSteps2 = new List<ValueTuple<int, int, int>>();
            var step = 0;

            for (var i = 0; i < input2.Length; i++)
            {
                var steps = Int32.Parse(input2[i].Substring(1));
                var direction = input2[i].Substring(0, 1);

                switch (direction)
                {
                    case "R":
                        var r = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[r + s, currentY] == "1")
                            {
                                matrix[r + s, currentY] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX + 1;
                                t.Item2 = currentY - 1;
                                t.Item3 = step;
                                nrOfSteps2.Add(t);
                            }
                            currentX++;
                        }
                        break;
                    case "L":
                        var l = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[l - s, currentY] == "1")
                            {
                                matrix[l - s, currentY] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX + 1;
                                t.Item2 = currentY - 1;
                                t.Item3 = step;
                                nrOfSteps2.Add(t);
                            }
                            currentX--;
                        }
                        break;
                    case "U":
                        var u = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[currentX, u + s] == "1")
                            {
                                matrix[currentX, u + s] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX + 1;
                                t.Item2 = currentY - 1;
                                t.Item3 = step;
                                nrOfSteps2.Add(t);
                            }
                            currentY++;
                        }
                        break;
                    case "D":
                        var d = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[currentX, d - s] == "1")
                            {
                                matrix[currentX, d - s] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX + 1;
                                t.Item2 = currentY - 1;
                                t.Item3 = step;
                                nrOfSteps2.Add(t);
                            }
                            currentY--;
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var steps in nrOfSteps2)
            {
                Console.WriteLine("Steps:" + steps);
            }


            Console.WriteLine("---------------------------------------");

            matrix = new string[20000, 20000];

            currentX = 10000;
            currentY = 10000;

            input1 = new string[301] { "R998", "U547", "L703", "D251", "L776", "U837", "R100", "U240", "R197", "D216", "L220", "U606", "L437", "U56", "R940", "U800", "L968", "D464", "L870", "D797", "L545", "D824", "R790", "U5", "R347", "D794", "R204", "U538", "L247", "U385", "L103", "D260", "L590", "U813", "L549", "U309", "L550", "U321", "R862", "D686", "R368", "D991", "R451", "D836", "R264", "D138", "L292", "D319", "L784", "D369", "R849", "U865", "R776", "D726", "R223", "D118", "L790", "D208", "L836", "D592", "R310", "D36", "R991", "U674", "L205", "U407", "R422", "U350", "L126", "D320", "L239", "U353", "L509", "U48", "R521", "D544", "L157", "D551", "R614", "D493", "R407", "D965", "R498", "U248", "R826", "U573", "L782", "D589", "R616", "D992", "L806", "D745", "R28", "U142", "L333", "D849", "L858", "D617", "R167", "U341", "R46", "U940", "L615", "D997", "L447", "D604", "R148", "U561", "R925", "D673", "R441", "U200", "R458", "U193", "L805", "D723", "L208", "U600", "L926", "U614", "R660", "D183", "L408", "D834", "R248", "U354", "L110", "U391", "L37", "U599", "L287", "U28", "R859", "D936", "L404", "D952", "R11", "U20", "R708", "U218", "L800", "U750", "R936", "D213", "R6", "D844", "R728", "D391", "R114", "U406", "R390", "U791", "L199", "D397", "R476", "D583", "R99", "U419", "R575", "D836", "L896", "U780", "L77", "U964", "R441", "U723", "R248", "D170", "R527", "D94", "L39", "U645", "L338", "D728", "R503", "U641", "L358", "D287", "R171", "U368", "R176", "D986", "R821", "U912", "L231", "D206", "L451", "U900", "L35", "D490", "R190", "D180", "L937", "D500", "R157", "U989", "L336", "U202", "R178", "U52", "R931", "U306", "L85", "D866", "R756", "U715", "L521", "D977", "R936", "U4", "R207", "D384", "L785", "U138", "L682", "U488", "L537", "U250", "L877", "D446", "R849", "U35", "R258", "U784", "R263", "D494", "L324", "U601", "R302", "U473", "L737", "D143", "R184", "D967", "R95", "U51", "L713", "U733", "R297", "U740", "R677", "D715", "R750", "U143", "L980", "U260", "R915", "D535", "R202", "U460", "R365", "U956", "L73", "U441", "R182", "D982", "L869", "D755", "L837", "D933", "L856", "D341", "R189", "D519", "L387", "D144", "R575", "U682", "R317", "U838", "R154", "D201", "R237", "D410", "L43", "U853", "L495", "U983", "L953", "U220", "R697", "D592", "R355", "U377", "R792", "U824", "L441", "U783", "R258", "D955", "R451", "D178", "L151", "D435", "L232", "U923", "L663", "U283", "L92", "D229", "R514" };
            input2 = new string[301] { "L995", "U122", "R472", "U470", "R725", "U906", "L83", "U672", "R448", "U781", "L997", "U107", "R66", "D966", "L780", "D181", "L662", "U158", "R804", "D837", "L237", "U164", "L98", "U582", "R925", "D806", "L153", "D843", "R601", "U941", "L968", "D528", "R482", "D586", "R15", "U370", "L592", "U836", "R828", "U676", "R606", "D20", "R841", "U117", "L262", "U377", "R375", "U503", "R166", "D398", "R161", "D9", "R140", "D188", "R895", "D226", "R77", "U28", "L727", "D72", "L51", "U425", "R370", "D377", "L801", "D525", "R102", "D568", "L416", "D300", "R415", "U199", "R941", "U211", "R285", "U719", "L259", "U872", "L959", "U350", "L196", "D830", "R515", "U899", "R298", "U875", "R946", "U797", "R108", "U461", "R999", "D49", "L369", "D472", "R83", "D265", "L825", "D163", "R162", "U906", "L816", "D241", "L587", "D801", "R601", "D630", "R937", "U954", "L379", "D347", "R831", "D337", "L192", "D649", "L853", "U270", "R162", "D892", "L26", "D663", "L276", "U891", "R843", "U67", "R225", "D88", "R686", "U662", "R794", "D814", "L200", "D887", "R567", "U363", "L863", "U16", "R975", "D470", "R714", "U771", "L267", "D402", "R75", "U98", "L686", "U565", "R584", "D402", "L824", "D927", "R71", "U39", "L174", "D494", "L358", "D626", "R616", "D369", "R471", "U881", "L428", "U53", "R862", "U749", "L847", "D944", "L887", "D695", "R442", "U870", "L993", "U315", "L878", "U100", "L480", "D354", "L12", "D533", "L236", "D364", "R450", "U679", "L926", "D391", "R313", "D953", "L560", "D740", "L974", "D119", "L370", "U404", "R339", "U233", "R901", "U514", "R584", "D495", "R308", "U170", "R759", "U592", "R388", "U396", "R477", "U670", "R906", "D687", "L874", "U352", "R124", "U700", "R289", "D524", "L93", "D817", "R408", "D776", "L235", "D928", "L534", "D296", "R116", "U995", "L63", "D903", "R758", "U881", "L530", "U498", "R573", "D626", "L26", "U269", "R237", "U287", "L840", "D603", "R948", "D567", "R89", "U552", "L299", "D774", "R863", "D182", "R773", "D108", "L137", "U88", "L731", "U793", "L267", "U902", "L41", "U258", "L156", "U361", "R389", "D839", "L976", "U960", "L342", "D489", "R816", "U391", "L393", "U601", "R255", "D629", "R832", "U877", "L34", "D373", "L809", "D679", "L104", "U901", "R157", "U468", "R143", "U896", "L637", "D577", "L545", "D486", "L970", "D130", "L305", "D909", "R984", "D500", "L935", "U949", "R525", "D547", "L786", "U106", "L269", "D511", "L919" };

            for (var i = 0; i < input2.Length; i++)
            {
                var steps = Int32.Parse(input2[i].Substring(1));
                var direction = input2[i].Substring(0, 1);

                switch (direction)
                {
                    case "R":
                        var r = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[r + s, currentY] = "1";
                            currentX++;
                        }
                        break;
                    case "L":
                        var l = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[l - s, currentY] = "1";
                            currentX--;
                        }
                        break;
                    case "U":
                        var u = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[currentX, u + s] = "1";
                            currentY++;
                        }
                        break;
                    case "D":
                        var d = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[currentX, d - s] = "1";
                            currentY--;
                        }
                        break;
                    default:
                        break;
                }
            }

            currentX = 10000;
            currentY = 10000;

            var nrOfSteps = new List<ValueTuple<int, int, int>>();
            step = 0;

            for (var i = 0; i < input1.Length; i++)
            {
                var steps = Int32.Parse(input1[i].Substring(1));
                var direction = input1[i].Substring(0, 1);

                switch (direction)
                {
                    case "R":
                        var r = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[r + s, currentY] == "1")
                            {
                                matrix[r + s, currentY] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX;
                                t.Item2 = currentY;
                                t.Item3 = step;
                                nrOfSteps.Add(t);
                            }
                            currentX++;
                        }
                        break;
                    case "L":
                        var l = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[l - s, currentY] == "1")
                            {
                                matrix[l - s, currentY] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX;
                                t.Item2 = currentY;
                                t.Item3 = step;
                                nrOfSteps.Add(t);
                            }
                            currentX--;
                        }
                        break;
                    case "U":
                        var u = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[currentX, u + s] == "1")
                            {
                                matrix[currentX, u + s] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX;
                                t.Item2 = currentY;
                                t.Item3 = step;
                                nrOfSteps.Add(t);
                            }
                            currentY++;
                        }
                        break;
                    case "D":
                        var d = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            step++;
                            if (matrix[currentX, d - s] == "1")
                            {
                                matrix[currentX, d - s] = "X";
                                var t = new ValueTuple<int, int, int>();
                                t.Item1 = currentX;
                                t.Item2 = currentY;
                                t.Item3 = step;
                                nrOfSteps.Add(t);
                            }
                            currentY--;
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var steps in nrOfSteps)
            {
                Console.WriteLine("Steps:" + steps);
            }

            Console.WriteLine("--------------------------------------------------------------------------------");


            foreach (var a in nrOfSteps)
            {
                foreach (var b in nrOfSteps2)
                {
                    if (a.Item1 == b.Item1 && a.Item2 == b.Item2)
                    {
                        Console.WriteLine(a.Item3 + b.Item3);
                    }

                }
            }


        }

        public static void LuckaTre()
        {
            string[,] matrix = new string[20000, 20000];

            var currentX = 10000;
            var currentY = 10000;

            string[] input1 = new string[301] { "R998", "U547", "L703", "D251", "L776", "U837", "R100", "U240", "R197", "D216", "L220", "U606", "L437", "U56", "R940", "U800", "L968", "D464", "L870", "D797", "L545", "D824", "R790", "U5", "R347", "D794", "R204", "U538", "L247", "U385", "L103", "D260", "L590", "U813", "L549", "U309", "L550", "U321", "R862", "D686", "R368", "D991", "R451", "D836", "R264", "D138", "L292", "D319", "L784", "D369", "R849", "U865", "R776", "D726", "R223", "D118", "L790", "D208", "L836", "D592", "R310", "D36", "R991", "U674", "L205", "U407", "R422", "U350", "L126", "D320", "L239", "U353", "L509", "U48", "R521", "D544", "L157", "D551", "R614", "D493", "R407", "D965", "R498", "U248", "R826", "U573", "L782", "D589", "R616", "D992", "L806", "D745", "R28", "U142", "L333", "D849", "L858", "D617", "R167", "U341", "R46", "U940", "L615", "D997", "L447", "D604", "R148", "U561", "R925", "D673", "R441", "U200", "R458", "U193", "L805", "D723", "L208", "U600", "L926", "U614", "R660", "D183", "L408", "D834", "R248", "U354", "L110", "U391", "L37", "U599", "L287", "U28", "R859", "D936", "L404", "D952", "R11", "U20", "R708", "U218", "L800", "U750", "R936", "D213", "R6", "D844", "R728", "D391", "R114", "U406", "R390", "U791", "L199", "D397", "R476", "D583", "R99", "U419", "R575", "D836", "L896", "U780", "L77", "U964", "R441", "U723", "R248", "D170", "R527", "D94", "L39", "U645", "L338", "D728", "R503", "U641", "L358", "D287", "R171", "U368", "R176", "D986", "R821", "U912", "L231", "D206", "L451", "U900", "L35", "D490", "R190", "D180", "L937", "D500", "R157", "U989", "L336", "U202", "R178", "U52", "R931", "U306", "L85", "D866", "R756", "U715", "L521", "D977", "R936", "U4", "R207", "D384", "L785", "U138", "L682", "U488", "L537", "U250", "L877", "D446", "R849", "U35", "R258", "U784", "R263", "D494", "L324", "U601", "R302", "U473", "L737", "D143", "R184", "D967", "R95", "U51", "L713", "U733", "R297", "U740", "R677", "D715", "R750", "U143", "L980", "U260", "R915", "D535", "R202", "U460", "R365", "U956", "L73", "U441", "R182", "D982", "L869", "D755", "L837", "D933", "L856", "D341", "R189", "D519", "L387", "D144", "R575", "U682", "R317", "U838", "R154", "D201", "R237", "D410", "L43", "U853", "L495", "U983", "L953", "U220", "R697", "D592", "R355", "U377", "R792", "U824", "L441", "U783", "R258", "D955", "R451", "D178", "L151", "D435", "L232", "U923", "L663", "U283", "L92", "D229", "R514" };
            string[] input2 = new string[301] { "L995", "U122", "R472", "U470", "R725", "U906", "L83", "U672", "R448", "U781", "L997", "U107", "R66", "D966", "L780", "D181", "L662", "U158", "R804", "D837", "L237", "U164", "L98", "U582", "R925", "D806", "L153", "D843", "R601", "U941", "L968", "D528", "R482", "D586", "R15", "U370", "L592", "U836", "R828", "U676", "R606", "D20", "R841", "U117", "L262", "U377", "R375", "U503", "R166", "D398", "R161", "D9", "R140", "D188", "R895", "D226", "R77", "U28", "L727", "D72", "L51", "U425", "R370", "D377", "L801", "D525", "R102", "D568", "L416", "D300", "R415", "U199", "R941", "U211", "R285", "U719", "L259", "U872", "L959", "U350", "L196", "D830", "R515", "U899", "R298", "U875", "R946", "U797", "R108", "U461", "R999", "D49", "L369", "D472", "R83", "D265", "L825", "D163", "R162", "U906", "L816", "D241", "L587", "D801", "R601", "D630", "R937", "U954", "L379", "D347", "R831", "D337", "L192", "D649", "L853", "U270", "R162", "D892", "L26", "D663", "L276", "U891", "R843", "U67", "R225", "D88", "R686", "U662", "R794", "D814", "L200", "D887", "R567", "U363", "L863", "U16", "R975", "D470", "R714", "U771", "L267", "D402", "R75", "U98", "L686", "U565", "R584", "D402", "L824", "D927", "R71", "U39", "L174", "D494", "L358", "D626", "R616", "D369", "R471", "U881", "L428", "U53", "R862", "U749", "L847", "D944", "L887", "D695", "R442", "U870", "L993", "U315", "L878", "U100", "L480", "D354", "L12", "D533", "L236", "D364", "R450", "U679", "L926", "D391", "R313", "D953", "L560", "D740", "L974", "D119", "L370", "U404", "R339", "U233", "R901", "U514", "R584", "D495", "R308", "U170", "R759", "U592", "R388", "U396", "R477", "U670", "R906", "D687", "L874", "U352", "R124", "U700", "R289", "D524", "L93", "D817", "R408", "D776", "L235", "D928", "L534", "D296", "R116", "U995", "L63", "D903", "R758", "U881", "L530", "U498", "R573", "D626", "L26", "U269", "R237", "U287", "L840", "D603", "R948", "D567", "R89", "U552", "L299", "D774", "R863", "D182", "R773", "D108", "L137", "U88", "L731", "U793", "L267", "U902", "L41", "U258", "L156", "U361", "R389", "D839", "L976", "U960", "L342", "D489", "R816", "U391", "L393", "U601", "R255", "D629", "R832", "U877", "L34", "D373", "L809", "D679", "L104", "U901", "R157", "U468", "R143", "U896", "L637", "D577", "L545", "D486", "L970", "D130", "L305", "D909", "R984", "D500", "L935", "U949", "R525", "D547", "L786", "U106", "L269", "D511", "L919" };

            for (var i = 0; i < input1.Length; i++)
            {
                var steps = Int32.Parse(input1[i].Substring(1));
                var direction = input1[i].Substring(0, 1);

                switch (direction)
                {
                    case "R":
                        var r = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[r + s, currentY] = "1";
                            currentX++;
                        }
                        break;
                    case "L":
                        var l = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[l - s, currentY] = "1";
                            currentX--;
                        }
                        break;
                    case "U":
                        var u = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[currentX, u + s] = "1";
                            currentY++;
                        }
                        break;
                    case "D":
                        var d = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            matrix[currentX, d - s] = "1";
                            currentY--;
                        }
                        break;
                    default:
                        break;
                }
            }

            currentX = 10000;
            currentY = 10000;

            for (var i = 0; i < input2.Length; i++)
            {
                var steps = Int32.Parse(input2[i].Substring(1));
                var direction = input2[i].Substring(0, 1);

                switch (direction)
                {
                    case "R":
                        var r = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            if (matrix[r + s, currentY] == "1")
                            {
                                matrix[r + s, currentY] = "X";

                            }
                            currentX++;
                        }
                        break;
                    case "L":
                        var l = currentX;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            if (matrix[l - s, currentY] == "1")
                            {
                                matrix[l - s, currentY] = "X";
                            }
                            currentX--;
                        }
                        break;
                    case "U":
                        var u = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            if (matrix[currentX, u + s] == "1")
                            {
                                matrix[currentX, u + s] = "X";
                            }
                            currentY++;
                        }
                        break;
                    case "D":
                        var d = currentY;
                        for (var s = 1; s < steps + 1; s++)
                        {
                            if (matrix[currentX, d - s] == "1")
                            {
                                matrix[currentX, d - s] = "X";
                            }
                            currentY--;
                        }
                        break;
                    default:
                        break;
                }
            }

            List<int> distances = new List<int>();

            for (var i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (var s = 0; s < matrix.GetLength(1) - 1; s++)
                {
                    if (matrix[i, s] != null && matrix[i, s] == "X")
                    {
                        distances.Add(Math.Abs(10000 - i) + Math.Abs(10000 - s));
                    }
                }
            }

            distances.Sort();
            foreach (var a in distances)
            {
                Console.WriteLine(a);
            }

        }

        public static void LuckaTvå()
        {
            int[] ints = new int[113] { 1, 12, 2, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 1, 19, 6, 23, 2, 23, 13, 27, 1, 27, 5, 31, 2, 31, 10, 35, 1, 9, 35, 39, 1, 39, 9, 43, 2, 9, 43, 47, 1, 5, 47, 51, 2, 13, 51, 55, 1, 55, 9, 59, 2, 6, 59, 63, 1, 63, 5, 67, 1, 10, 67, 71, 1, 71, 10, 75, 2, 75, 13, 79, 2, 79, 13, 83, 1, 5, 83, 87, 1, 87, 6, 91, 2, 91, 13, 95, 1, 5, 95, 99, 1, 99, 2, 103, 1, 103, 6, 0, 99, 2, 14, 0, 0 };

            for (var i = 0; i < ints.Length; i += 4)
            {
                switch (ints[i])
                {
                    case 1:
                        ints[ints[i + 3]] = ints[ints[i + 1]] + ints[ints[i + 2]];
                        break;
                    case 2:
                        ints[ints[i + 3]] = ints[ints[i + 1]] * ints[ints[i + 2]];
                        break;
                    case 99:
                        //Console.WriteLine("Hit 99");
                        i += 1;
                        continue;
                    default:
                        break;

                }
            }


            Console.WriteLine(ints[0]);

        }


        public static void LuckaTvåTvå()
        {
            int result = 0;
            int noun = 0;
            int verb = 0;
            Random r = new Random();
            while (result != 19690720)
            {
                noun = r.Next(0, 99);
                verb = r.Next(0, 99);
                result = CalcLuckaTvåTvå(noun, verb);
            }



            Console.WriteLine("Result: " + result + ", Noun: " + noun + ", Verb: " + verb);

        }


        public static int CalcLuckaTvåTvå(int noun, int verb)
        {
            int[] ints = new int[113] { 1, noun, verb, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 1, 19, 6, 23, 2, 23, 13, 27, 1, 27, 5, 31, 2, 31, 10, 35, 1, 9, 35, 39, 1, 39, 9, 43, 2, 9, 43, 47, 1, 5, 47, 51, 2, 13, 51, 55, 1, 55, 9, 59, 2, 6, 59, 63, 1, 63, 5, 67, 1, 10, 67, 71, 1, 71, 10, 75, 2, 75, 13, 79, 2, 79, 13, 83, 1, 5, 83, 87, 1, 87, 6, 91, 2, 91, 13, 95, 1, 5, 95, 99, 1, 99, 2, 103, 1, 103, 6, 0, 99, 2, 14, 0, 0 };

            for (var i = 0; i < ints.Length; i += 4)
            {
                switch (ints[i])
                {
                    case 1:
                        ints[ints[i + 3]] = ints[ints[i + 1]] + ints[ints[i + 2]];
                        break;
                    case 2:
                        ints[ints[i + 3]] = ints[ints[i + 1]] * ints[ints[i + 2]];
                        break;
                    case 99:
                        //Console.WriteLine("Hit 99");
                        i += 1;
                        continue;
                    default:
                        break;

                }
            }

            return ints[0];

        }

        public static void LuckaEtt()
        {
            decimal[] masses = new decimal[100] { 129192, 58561, 57267, 95382, 84995, 127372, 93598, 97264, 138550, 79327, 135661, 139468, 108860, 149642, 72123, 128333, 69002, 98450, 86267, 70171, 101333, 79822, 142539, 142743, 51371, 111381, 62073, 72210, 125168, 135952, 131060, 121842, 88234, 146774, 136571, 126719, 50644, 75696, 51195, 77171, 118052, 83691, 133779, 149814, 64847, 110697, 92695, 59453, 139517, 129487, 79271, 97896, 146987, 149822, 71866, 90797, 104732, 54997, 50139, 134115, 133017, 144979, 89428, 124750, 91833, 57252, 67195, 121624, 102706, 138245, 127700, 124098, 110382, 121557, 103613, 133576, 122801, 112306, 120203, 134696, 76129, 84576, 80854, 147237, 71025, 127513, 143631, 125090, 115698, 57979, 84880, 120177, 147389, 88380, 114688, 56355, 126265, 58220, 63523, 130179 };
            int sum = 0;
            for (var i = 0; i < masses.Length; i++)
            {
                sum += CalcLuckaEtt(masses[i]);
            }
            Console.WriteLine(sum);
        }

        public static int CalcLuckaEtt(decimal mass)
        {

            int sum = 0;
            while (mass > 0)
            {
                mass = (int)Math.Floor(mass / 3) - 2;
                if (mass > 0)
                {
                    sum += (int)mass;
                }
            }

            return sum;
        }
    }
}
