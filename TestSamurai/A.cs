using EfSamurai.Domain;

namespace EfSamurai.Test
{
    internal class A
    {
        public static Battle Battle1
        {
            get
            {
                return new Battle {
                    Name = "Battle1",

                };
            }
        }

              public static Battle Battle2
        {
            get
            {
                return new Battle
                {
                    Name = "Battle2"
                };
            }
        }
    }
}