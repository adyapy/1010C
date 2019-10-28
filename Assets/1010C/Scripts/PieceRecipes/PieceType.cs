﻿using System.Collections;
using System.Collections.Generic;
using _1010C.Scripts.Misc;
using UnityEngine;

namespace _1010C.Scripts.PieceRecipes
{
    public abstract partial class PieceType : Enumeration
    {
        public static readonly PieceType onePiece = new OnePieceType();
        public static readonly PieceType twoPieceVertical = TwoPieceType.mTwoPieceVertical;
        public static readonly PieceType twoPieceHorizontal = TwoPieceType.mTwoPieceHorizontal;
        public static readonly PieceType threePieceVertical = ThreePieceType.mThreePieceVertical;
        public static readonly PieceType threePieceHorizontal = ThreePieceType.mThreePieceHorizontal;

        private PieceType(int id, string name)
            : base(id, name)
        {
        }

        public abstract Vector2[] GetPiecePositions();
        public abstract float GetCubeSeparationAmount();

        public static PieceType GetNextPiece()
        {
            return GetAll<PieceType>().PickRandom();
        }

        private class OnePieceType : PieceType
        {
            public OnePieceType() : base(0, "OnePiece")
            {
            }

            public override Vector2[] GetPiecePositions()
            {
                return new[] {Vector2.zero};
            }

            public override float GetCubeSeparationAmount()
            {
                return 0.1f;
            }
        }

        private abstract class TwoPieceType : PieceType
        {
            public static readonly TwoPieceType mTwoPieceVertical = new TwoPieceVertical();
            public static readonly TwoPieceType mTwoPieceHorizontal = new TwoPieceHorizontal();

            private TwoPieceType(int value, string name) : base(value, name)
            {
            }

            public override float GetCubeSeparationAmount()
            {
                return 0.015f;
            }

            private class TwoPieceVertical : TwoPieceType
            {
                public TwoPieceVertical() : base(1, "TwoPieceVertical")
                {
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(0, -0.5f),
                        new Vector2(0, +0.5f),
                    };
                }
            }

            private class TwoPieceHorizontal : TwoPieceType
            {
                public TwoPieceHorizontal() : base(2, "TwoPieceHorizontal")
                {
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(-0.5f, 0),
                        new Vector2(+0.5f, 0),
                    };
                }
            }
        }

        private abstract class ThreePieceType : PieceType
        {
            public static readonly ThreePieceType mThreePieceVertical = new ThreePieceVertical();
            public static readonly ThreePieceType mThreePieceHorizontal = new ThreePieceHorizontal();

            private ThreePieceType(int value, string name) : base(value, name)
            {
            }

            public override float GetCubeSeparationAmount()
            {
                return 0.1f;
            }

            private class ThreePieceVertical : ThreePieceType
            {
                public ThreePieceVertical() : base(3, "ThreePieceVertical")
                {
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(0, -1),
                        new Vector2(0, 0),
                        new Vector2(0, +1),
                    };
                }
            }

            private class ThreePieceHorizontal : ThreePieceType
            {
                public ThreePieceHorizontal() : base(4, "ThreePieceHorizontal")
                {
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(-1, 0),
                        new Vector2(0, 0),
                        new Vector2(+1f, 0),
                    };
                }
            }
        }
    }
}