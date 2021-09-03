using System;

namespace DZ_2._6
{
    class Program
    {
        [Flags]
        public enum WeekDays
        {
            Monday = 0b_1000000,
            Tuesday = 0b_0100000,
            Wednesday = 0b_0010000,
            Thursday = 0b_0001000,
            Friday = 0b_0000100,
            Saturday = 0b_0000010,
            Sunday = 0b_0000001,

        }



        static void Main(string[] args)
        {
            WeekDays MT = WeekDays.Monday | WeekDays.Tuesday;
            WeekDays MTW = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday;
            WeekDays MTWT = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday;
            WeekDays MTWTF = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            WeekDays MTWTFS = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday;
            WeekDays MTWTFSS = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;
            WeekDays TW = WeekDays.Tuesday | WeekDays.Wednesday;
            WeekDays TWT = WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday;
            WeekDays TWTF = WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            WeekDays TWTFS = WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday;
            WeekDays TWTFSS = WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;
            WeekDays WT = WeekDays.Wednesday | WeekDays.Thursday;
            WeekDays WTF = WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            WeekDays WTFS = WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday;
            WeekDays WTFSS = WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;
            WeekDays TF = WeekDays.Thursday | WeekDays.Friday;
            WeekDays TFS = WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday;
            WeekDays TFSS = WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;
            WeekDays FSA = WeekDays.Friday | WeekDays.Saturday;
            WeekDays FSS = WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;

            WeekDays FSU = WeekDays.Saturday;
            WeekDays MO = WeekDays.Monday;
            WeekDays TU = WeekDays.Tuesday;
            WeekDays WE = WeekDays.Wednesday;
            WeekDays TH = WeekDays.Thursday;
            WeekDays FR = WeekDays.Friday;
            WeekDays SA = WeekDays.Saturday;
            WeekDays SU = WeekDays.Sunday;

            WeekDays MWFS = WeekDays.Monday | WeekDays.Wednesday | WeekDays.Friday | WeekDays.Sunday;
            WeekDays TTS = WeekDays.Tuesday | WeekDays.Thursday | WeekDays.Saturday;


            WeekDays RabDays = (WeekDays)0b_1101101; //ИЗМЕНЯЕМАЯ ПЕРЕМЕННАЯ  0-нерабочий день  1-рабочий день

            Console.WriteLine($"Офис работает в {RabDays}");
            if (RabDays == MT)
            { Console.WriteLine($"Офис работает с понедельника по вторник."); }
            else if (RabDays == MTW)
            { Console.WriteLine($"Офис работает с понедельника по среду."); }
            else if (RabDays == MTWT)
            { Console.WriteLine($"Офис работает с понедельника по четверг."); }
            else if (RabDays == MTWTF)
            { Console.WriteLine($"Офис работает с понедельника по пятницу."); }
            else if (RabDays == MTWTFS)
            { Console.WriteLine($"Офис работает с понедельника по субботу."); }
            else if (RabDays == MTWTFSS)
            { Console.WriteLine($"Офис работает с понедельника по воскресенье."); }
            else if (RabDays == TW)
            { Console.WriteLine($"Офис работает со вторника по среду."); }
            else if (RabDays == TWT)
            { Console.WriteLine($"Офис работает со вторника по четверг."); }
            else if (RabDays == TWTF)
            { Console.WriteLine($"Офис работает со вторника по пятницу."); }
            else if (RabDays == TWTFS)
            { Console.WriteLine($"Офис работает со вторника по субботу."); }
            else if (RabDays == TWTFSS)
            { Console.WriteLine($"Офис работает со вторника по воскресенье."); }
            else if (RabDays == WT)
            { Console.WriteLine($"Офис работает со среды по четверг."); }
            else if (RabDays == WTF)
            { Console.WriteLine($"Офис работает со среды по пятницу."); }
            else if (RabDays == WTFS)
            { Console.WriteLine($"Офис работает со среды по субботу."); }
            else if (RabDays == WTFSS)
            { Console.WriteLine($"Офис работает со среды по воскресенье."); }
            else if (RabDays == TF)
            { Console.WriteLine($"Офис работает с четверга  по пятницу."); }
            else if (RabDays == TFS)
            { Console.WriteLine($"Офис работает с четверга по субботу."); }
            else if (RabDays == TFSS)
            { Console.WriteLine($"Офис работает с четверга по воскресенье."); }
            else if (RabDays == FSA)
            { Console.WriteLine($"Офис работает с пятницы по субботу."); }
            else if (RabDays == FSS)
            { Console.WriteLine($"Офис работает с пятницы по воскресенье."); }
            else if (RabDays == FSU)
            { Console.WriteLine($"Офис работает с субботы по воскресенье."); }
            else if (RabDays == MO)
            { Console.WriteLine($"Офис работает только в понедельник."); }
            else if (RabDays == TU)
            { Console.WriteLine($"Офис работает только во вторник."); }
            else if (RabDays == WE)
            { Console.WriteLine($"Офис работает только в среду ."); }
            else if (RabDays == TH)
            { Console.WriteLine($"Офис работает только в четверг."); }
            else if (RabDays == FR)
            { Console.WriteLine($"Офис работает только в пятницу."); }
            else if (RabDays == SA)
            { Console.WriteLine($"Офис работает только в субботу."); }
            else if (RabDays == SU)
            { Console.WriteLine($"Офис работает только в воскресенье."); }
            else if (RabDays == MWFS)
            { Console.WriteLine($"Офис работает только по нечетным дням недели"); }
            else if (RabDays == TTS)
            { Console.WriteLine($"Офис работает только по четным дням."); }
            Console.ReadKey();
        }
    }
}
