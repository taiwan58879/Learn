using System;

namespace Learn.Enum
{
    /// <summary>
    /// 點數
    /// </summary>
    internal enum RankEnum
    {
        __A,
        __2,
        __3,
        __4,
        __5,
        __6,
        __7,
        __8,
        __9,
        _10,
        __J,
        __Q,
        __K,
    }

    internal static class RankEnumExtension
    {
        public static string ToStr(this RankEnum rank)
        {
            switch (rank)
            {
                case RankEnum.__2:
                    return " 2";
                case RankEnum.__3:
                    return " 3";
                case RankEnum.__4:
                    return " 4";
                case RankEnum.__5:
                    return " 5";
                case RankEnum.__6:
                    return " 6";
                case RankEnum.__7:
                    return " 7";
                case RankEnum.__8:
                    return " 8";
                case RankEnum.__9:
                    return " 9";
                case RankEnum._10:
                    return "10";
                case RankEnum.__J:
                    return " J";
                case RankEnum.__Q:
                    return " Q";
                case RankEnum.__K:
                    return " K";
                case RankEnum.__A:
                    return " A";
            }

            throw new NotSupportedException($"{rank} not support {ToStr}().");
        }
    }
}
