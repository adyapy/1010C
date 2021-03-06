﻿using _1010C.Scripts.Components.Piece;
using UnityEngine;

namespace _1010C.Scripts.PieceRecipes
{
    public abstract partial class PieceType
    {
        private abstract class FivePieceType : PieceType
        {
            public static readonly FivePieceType mFivePieceVertical = new FivePieceVertical();
            public static readonly FivePieceType mFivePieceHorizontal = new FivePieceHorizontal();

            private FivePieceType(int value, string name) : base(value, name)
            {
            }
            
            public override CubeColor GetCubeColor()
            {
                return CubeColor.Red;
            }

            private class FivePieceVertical : FivePieceType
            {
                public FivePieceVertical() : base(16, "FivePieceVertical")
                {
                }

                public override float GetDragPivotDifference()
                {
                    return 3.5f;
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(0, -2),
                        new Vector2(0, -1),
                        new Vector2(0, 0),
                        new Vector2(0, +1),
                        new Vector2(0, +2),
                    };
                }
            }

            private class FivePieceHorizontal : FivePieceType
            {
                public FivePieceHorizontal() : base(17, "FivePieceHorizontal")
                {
                }

                public override float GetDragPivotDifference()
                {
                    return 1.5f;
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(-2, 0),
                        new Vector2(-1, 0),
                        new Vector2(0, 0),
                        new Vector2(+1f, 0),
                        new Vector2(+2f, 0),
                    };
                }
            }
        }
    }
}