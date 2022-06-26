using System;

namespace Learn.Enum
{
    /// <summary>
    /// 花色
    /// </summary>
    internal enum SuitEnum
    {
        /// <summary>
        /// 黑桃
        /// </summary>
        Spade,
        /// <summary>
        /// 紅心
        /// </summary>
        Heart,
        /// <summary>
        /// 方塊
        /// </summary>
        Diamond,
        /// <summary>
        /// 梅花
        /// </summary>
        Club,
    }
    internal static class SuitEnumExtension
    {
        public static string ToStr(this SuitEnum suit)
        {
            switch (suit)
            {
                case SuitEnum.Spade:
                    return "♠";
                case SuitEnum.Heart:
                    return "♥";
                case SuitEnum.Diamond:
                    return "♦";
                case SuitEnum.Club:
                    return "♣";
            }

            throw new NotSupportedException($"{suit} not support {ToStr}().");
        }
    }
}
