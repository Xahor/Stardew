﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace AreaOverlay
{
    public static class ScarecrowRadius
    {
        // this is really just to make "new Vector2" shorter so it looks more like a circle; yes, really
        private static Vector2 V(int x, int y) { return new Vector2(x, y); }

        public static readonly List<Vector2> AffectedTile = new List<Vector2> {
                                                    V(-4,-8), V(-3,-8), V(-2,-8), V(-1,-8), V(0,-8), V(1,-8), V(2,-8), V(3,-8), V(4,-8),

                                          V(-5,-7), V(-4,-7), V(-3,-7), V(-2,-7), V(-1,-7), V(0,-7), V(1,-7), V(2,-7), V(3,-7), V(4,-7), V(5,-7),

                                V(-6,-6), V(-5,-6), V(-4,-6), V(-3,-6), V(-2,-6), V(-1,-6), V(0,-6), V(1,-6), V(2,-6), V(3,-6), V(4,-6), V(5,-6),  V(6,-6),

                      V(-7,-5), V(-6,-5), V(-5,-5), V(-4,-5), V(-3,-5), V(-2,-5), V(-1,-5), V(0,-5), V(1,-5), V(2,-5), V(3,-5), V(4,-5), V(5,-5),  V(6,-5), V(7,-5),

            V(-8,-4), V(-7,-4), V(-6,-4), V(-5,-4), V(-4,-4), V(-3,-4), V(-2,-4), V(-1,-4), V(0,-4), V(1,-4), V(2,-4), V(3,-4), V(4,-4), V(5,-4),  V(6,-4), V(7,-4), V(8,-4),

            V(-8,-3), V(-7,-3), V(-6,-3), V(-5,-3), V(-4,-3), V(-3,-3), V(-2,-3), V(-1,-3), V(0,-3), V(1,-3), V(2,-3), V(3,-3), V(4,-3), V(5,-3),  V(6,-3), V(7,-3), V(8,-3),

            V(-8,-2), V(-7,-2), V(-6,-2), V(-5,-2), V(-4,-2), V(-3,-2), V(-2,-2), V(-1,-2), V(0,-2), V(1,-2), V(2,-2), V(3,-2), V(4,-2), V(5,-2),  V(6,-2), V(7,-2), V(8,-2),

            V(-8,-1), V(-7,-1), V(-6,-1), V(-5,-1), V(-4,-1), V(-3,-1), V(-2,-1), V(-1,-1), V(0,-1), V(1,-1), V(2,-1), V(3,-1), V(4,-1), V(5,-1),  V(6,-1), V(7,-1), V(8,-1),

            V(-8, 0), V(-7, 0), V(-6, 0), V(-5, 0), V(-4, 0), V(-3, 0), V(-2, 0), V(-1, 0), V(0, 0), V(1, 0), V(2, 0), V(3, 0), V(4, 0), V(5, 0),  V(6, 0), V(7, 0), V(8, 0),

            V(-8, 1), V(-7, 1), V(-6, 1), V(-5, 1), V(-4, 1), V(-3, 1), V(-2, 1), V(-1, 1), V(0, 1), V(1, 1), V(2, 1), V(3, 1), V(4, 1), V(5, 1),  V(6, 1), V(7, 1), V(8, 1),

            V(-8, 2), V(-7, 2), V(-6, 2), V(-5, 2), V(-4, 2), V(-3, 2), V(-2, 2), V(-1, 2), V(0, 2), V(1, 2), V(2, 2), V(3, 2), V(4, 2), V(5, 2),  V(6, 2), V(7, 2), V(8, 2),

            V(-8, 3), V(-7, 3), V(-6, 3), V(-5, 3), V(-4, 3), V(-3, 3), V(-2, 3), V(-1, 3), V(0, 3), V(1, 3), V(2, 3), V(3, 3), V(4, 3), V(5, 3),  V(6, 3), V(7, 3), V(8, 3),

            V(-8, 4), V(-7, 4), V(-6, 4), V(-5, 4), V(-4, 4), V(-3, 4), V(-2, 4), V(-1, 4), V(0, 4), V(1, 4), V(2, 4), V(3, 4), V(4, 4), V(5, 4),  V(6, 4), V(7, 4), V(8, 4),

                      V(-7, 5), V(-6, 5), V(-5, 5), V(-4, 5), V(-3, 5), V(-2, 5), V(-1, 5), V(0, 5), V(1, 5), V(2, 5), V(3, 5), V(4, 5), V(5, 5),  V(6, 5), V(7, 5),

                                V(-6, 6), V(-5, 6), V(-4, 6), V(-3, 6), V(-2, 6), V(-1, 6), V(0, 6), V(1, 6), V(2, 6), V(3, 6), V(4, 6), V(5, 6),  V(6, 6),

                                          V(-5, 7), V(-4, 7), V(-3, 7), V(-2, 7), V(-1, 7), V(0, 7), V(1, 7), V(2, 7), V(3, 7), V(4, 7), V(5, 7),

                                                    V(-4, 8), V(-3, 8), V(-2, 8), V(-1, 8), V(0, 8), V(1, 8), V(2, 8), V(3, 8), V(4, 8),
        };


        public static readonly List<Vector2> DeluxeAffectedTile = new List<Vector2> {
                                                                                                                                                    V(-5, -16), V(-4, -16), V(-3, -16), V(-2, -16), V(-1, -16), V(0, -16), V(1, -16), V(2, -16), V(3, -16), V(4, -16), V(5, -16),

                                                                                                                            V(-7, -15), V(-6, -15), V(-5, -15), V(-4, -15), V(-3, -15), V(-2, -15), V(-1, -15), V(0, -15), V(1, -15), V(2, -15), V(3, -15), V(4, -15), V(5, -15), V(6, -15), V(7, -15),

                                                                                                    V(-9, -14), V(-8, -14), V(-7, -14), V(-6, -14), V(-5, -14), V(-4, -14), V(-3, -14), V(-2, -14), V(-1, -14), V(0, -14), V(1, -14), V(2, -14), V(3, -14), V(4, -14), V(5, -14), V(6, -14), V(7, -14), V(8, -14), V(9, -14), 

                                                                                       V(-10, -13), V(-9, -13), V(-8, -13), V(-7, -13), V(-6, -13), V(-5, -13), V(-4, -13), V(-3, -13), V(-2, -13), V(-1, -13), V(0, -13), V(1, -13), V(2, -13), V(3, -13), V(4, -13), V(5, -13), V(6, -13), V(7, -13), V(8, -13), V(9, -13), V(10, -13),

                                                             V(-12, -12), V(-11, -12), V(-10, -12), V(-9, -12), V(-8, -12), V(-7, -12), V(-6, -12), V(-5, -12), V(-4, -12), V(-3, -12), V(-2, -12), V(-1, -12), V(0, -12), V(1, -12), V(2, -12), V(3, -12), V(4, -12), V(5, -12), V(6, -12), V(7, -12), V(8, -12), V(9, -12), V(10, -12), V(11, -12), V(12, -12),

                                                             V(-12, -11), V(-11, -11), V(-10, -11), V(-9, -11), V(-8, -11), V(-7, -11), V(-6, -11), V(-5, -11), V(-4, -11), V(-3, -11), V(-2, -11), V(-1, -11), V(0, -11), V(1, -11), V(2, -11), V(3, -11), V(4, -11), V(5, -11), V(6, -11), V(7, -11), V(8, -11), V(9, -11), V(10, -11), V(11, -11), V(12, -11),

                                                V(-13, -10), V(-12, -10), V(-11, -10), V(-10, -10), V(-9, -10), V(-8, -10), V(-7, -10), V(-6, -10), V(-5, -10), V(-4, -10), V(-3, -10), V(-2, -10), V(-1, -10), V(0, -10), V(1, -10), V(2, -10), V(3, -10), V(4, -10), V(5, -10), V(6, -10), V(7, -10), V(8, -10), V(9, -10), V(10, -10), V(11, -10), V(12, -10), V(13, -10),

                                    V(-14, -9), V(-13,  -9), V(-12,  -9), V(-11,  -9), V(-10,  -9), V(-9,  -9), V(-8,  -9), V(-7,  -9), V(-6,  -9), V(-5,  -9), V(-4,  -9), V(-3,  -9), V(-2,  -9), V(-1,  -9), V(0,  -9), V(1,  -9), V(2,  -9), V(3,  -9), V(4,  -9), V(5,  -9), V(6,  -9), V(7,  -9), V(8,  -9), V(9,  -9), V(10,  -9), V(11,  -9), V(12,  -9), V(13,  -9), V(14, -9),

                                    V(-14, -8), V(-13,  -8), V(-12,  -8), V(-11,  -8), V(-10,  -8), V(-9,  -8), V(-8,  -8), V(-7,  -8), V(-6,  -8), V(-5,  -8), V(-4,  -8), V(-3,  -8), V(-2,  -8), V(-1,  -8), V(0,  -8), V(1,  -8), V(2,  -8), V(3,  -8), V(4,  -8), V(5,  -8), V(6,  -8), V(7,  -8), V(8,  -8), V(9,  -8), V(10,  -8), V(11,  -8), V(12,  -8), V(13,  -8), V(14, -8),

                        V(-15, -7), V(-14, -7), V(-13,  -7), V(-12,  -7), V(-11,  -7), V(-10,  -7), V(-9,  -7), V(-8,  -7), V(-7,  -7), V(-6,  -7), V(-5,  -7), V(-4,  -7), V(-3,  -7), V(-2,  -7), V(-1,  -7), V(0,  -7), V(1,  -7), V(2,  -7), V(3,  -7), V(4,  -7), V(5,  -7), V(6,  -7), V(7,  -7), V(8,  -7), V(9,  -7), V(10,  -7), V(11,  -7), V(12,  -7), V(13,  -7), V(14, -7), V(15, -7),

                        V(-15, -6), V(-14, -6), V(-13,  -6), V(-12,  -6), V(-11,  -6), V(-10,  -6), V(-9,  -6), V(-8,  -6), V(-7,  -6), V(-6,  -6), V(-5,  -6), V(-4,  -6), V(-3,  -6), V(-2,  -6), V(-1,  -6), V(0,  -6), V(1,  -6), V(2,  -6), V(3,  -6), V(4,  -6), V(5,  -6), V(6,  -6), V(7,  -6), V(8,  -6), V(9,  -6), V(10,  -6), V(11,  -6), V(12,  -6), V(13,  -6), V(14, -6), V(15, -6),

            V(-16, -5), V(-15, -5), V(-14, -5), V(-13,  -5), V(-12,  -5), V(-11,  -5), V(-10,  -5), V(-9,  -5), V(-8,  -5), V(-7,  -5), V(-6,  -5), V(-5,  -5), V(-4,  -5), V(-3,  -5), V(-2,  -5), V(-1,  -5), V(0,  -5), V(1,  -5), V(2,  -5), V(3,  -5), V(4,  -5), V(5,  -5), V(6,  -5), V(7,  -5), V(8,  -5), V(9,  -5), V(10,  -5), V(11,  -5), V(12,  -5), V(13,  -5), V(14, -5), V(15, -5), V(16, -5),

            V(-16, -4), V(-15, -4), V(-14, -4), V(-13,  -4), V(-12,  -4), V(-11,  -4), V(-10,  -4), V(-9,  -4), V(-8,  -4), V(-7,  -4), V(-6,  -4), V(-5,  -4), V(-4,  -4), V(-3,  -4), V(-2,  -4), V(-1,  -4), V(0,  -4), V(1,  -4), V(2,  -4), V(3,  -4), V(4,  -4), V(5,  -4), V(6,  -4), V(7,  -4), V(8,  -4), V(9,  -4), V(10,  -4), V(11,  -4), V(12,  -4), V(13,  -4), V(14, -4), V(15, -4), V(16, -4),

            V(-16, -3), V(-15, -3), V(-14, -3), V(-13,  -3), V(-12,  -3), V(-11,  -3), V(-10,  -3), V(-9,  -3), V(-8,  -3), V(-7,  -3), V(-6,  -3), V(-5,  -3), V(-4,  -3), V(-3,  -3), V(-2,  -3), V(-1,  -3), V(0,  -3), V(1,  -3), V(2,  -3), V(3,  -3), V(4,  -3), V(5,  -3), V(6,  -3), V(7,  -3), V(8,  -3), V(9,  -3), V(10,  -3), V(11,  -3), V(12,  -3), V(13,  -3), V(14, -3), V(15, -3), V(16, -3),

            V(-16, -2), V(-15, -2), V(-14, -2), V(-13,  -2), V(-12,  -2), V(-11,  -2), V(-10,  -2), V(-9,  -2), V(-8,  -2), V(-7,  -2), V(-6,  -2), V(-5,  -2), V(-4,  -2), V(-3,  -2), V(-2,  -2), V(-1,  -2), V(0,  -2), V(1,  -2), V(2,  -2), V(3,  -2), V(4,  -2), V(5,  -2), V(6,  -2), V(7,  -2), V(8,  -2), V(9,  -2), V(10,  -2), V(11,  -2), V(12,  -2), V(13,  -2), V(14, -2), V(15, -2), V(16, -2),

            V(-16, -1), V(-15, -1), V(-14, -1), V(-13,  -1), V(-12,  -1), V(-11,  -1), V(-10,  -1), V(-9,  -1), V(-8,  -1), V(-7,  -1), V(-6,  -1), V(-5,  -1), V(-4,  -1), V(-3,  -1), V(-2,  -1), V(-1,  -1), V(0,  -1), V(1,  -1), V(2,  -1), V(3,  -1), V(4,  -1), V(5,  -1), V(6,  -1), V(7,  -1), V(8,  -1), V(9,  -1), V(10,  -1), V(11,  -1), V(12,  -1), V(13,  -1), V(14, -1), V(15, -1), V(16, -1),

            V(-16,  0), V(-15,  0), V(-14,  0), V(-13,   0), V(-12,   0), V(-11,   0), V(-10,   0), V(-9,   0), V(-8,   0), V(-7,   0), V(-6,   0), V(-5,   0), V(-4,   0), V(-3,   0), V(-2,   0), V(-1,   0), V(0,   0), V(1,   0), V(2,   0), V(3,   0), V(4,   0), V(5,   0), V(6,   0), V(7,   0), V(8,   0), V(9,   0), V(10,   0), V(11,   0), V(12,   0), V(13,   0), V(14,  0), V(15,  0), V(16,  0),

            V(-16,  1), V(-15,  1), V(-14,  1), V(-13,   1), V(-12,   1), V(-11,   1), V(-10,   1), V(-9,   1), V(-8,   1), V(-7,   1), V(-6,   1), V(-5,   1), V(-4,   1), V(-3,   1), V(-2,   1), V(-1,   1), V(0,   1), V(1,   1), V(2,   1), V(3,   1), V(4,   1), V(5,   1), V(6,   1), V(7,   1), V(8,   1), V(9,   1), V(10,   1), V(11,   1), V(12,   1), V(13,   1), V(14,  1), V(15,  1), V(16,  1),

            V(-16,  2), V(-15,  2), V(-14,  2), V(-13,   2), V(-12,   2), V(-11,   2), V(-10,   2), V(-9,   2), V(-8,   2), V(-7,   2), V(-6,   2), V(-5,   2), V(-4,   2), V(-3,   2), V(-2,   2), V(-1,   2), V(0,   2), V(1,   2), V(2,   2), V(3,   2), V(4,   2), V(5,   2), V(6,   2), V(7,   2), V(8,   2), V(9,   2), V(10,   2), V(11,   2), V(12,   2), V(13,   2), V(14,  2), V(15,  2), V(16,  2),

            V(-16,  3), V(-15,  3), V(-14,  3), V(-13,   3), V(-12,   3), V(-11,   3), V(-10,   3), V(-9,   3), V(-8,   3), V(-7,   3), V(-6,   3), V(-5,   3), V(-4,   3), V(-3,   3), V(-2,   3), V(-1,   3), V(0,   3), V(1,   3), V(2,   3), V(3,   3), V(4,   3), V(5,   3), V(6,   3), V(7,   3), V(8,   3), V(9,   3), V(10,   3), V(11,   3), V(12,   3), V(13,   3), V(14,  3), V(15,  3), V(16,  3),

            V(-16,  4), V(-15,  4), V(-14,  4), V(-13,   4), V(-12,   4), V(-11,   4), V(-10,   4), V(-9,   4), V(-8,   4), V(-7,   4), V(-6,   4), V(-5,   4), V(-4,   4), V(-3,   4), V(-2,   4), V(-1,   4), V(0,   4), V(1,   4), V(2,   4), V(3,   4), V(4,   4), V(5,   4), V(6,   4), V(7,   4), V(8,   4), V(9,   4), V(10,   4), V(11,   4), V(12,   4), V(13,   4), V(14,  4), V(15,  4), V(16,  4),

            V(-16,  5), V(-15,  5), V(-14,  5), V(-13,   5), V(-12,   5), V(-11,   5), V(-10,   5), V(-9,   5), V(-8,   5), V(-7,   5), V(-6,   5), V(-5,   5), V(-4,   5), V(-3,   5), V(-2,   5), V(-1,   5), V(0,   5), V(1,   5), V(2,   5), V(3,   5), V(4,   5), V(5,   5), V(6,   5), V(7,   5), V(8,   5), V(9,   5), V(10,   5), V(11,   5), V(12,   5), V(13,   5), V(14,  5), V(15,  5), V(16,  5),

                        V(-15,  6), V(-14,  6), V(-13,   6), V(-12,   6), V(-11,   6), V(-10,   6), V(-9,   6), V(-8,   6), V(-7,   6), V(-6,   6), V(-5,   6), V(-4,   6), V(-3,   6), V(-2,   6), V(-1,   6), V(0,   6), V(1,   6), V(2,   6), V(3,   6), V(4,   6), V(5,   6), V(6,   6), V(7,   6), V(8,   6), V(9,   6), V(10,   6), V(11,   6), V(12,   6), V(13,   6), V(14,  6), V(15,  6),

                        V(-15,  7), V(-14,  7), V(-13,   7), V(-12,   7), V(-11,   7), V(-10,   7), V(-9,   7), V(-8,   7), V(-7,   7), V(-6,   7), V(-5,   7), V(-4,   7), V(-3,   7), V(-2,   7), V(-1,   7), V(0,   7), V(1,   7), V(2,   7), V(3,   7), V(4,   7), V(5,   7), V(6,   7), V(7,   7), V(8,   7), V(9,   7), V(10,   7), V(11,   7), V(12,   7), V(13,   7), V(14,  7), V(15,  7),

                                    V(-14,  8), V(-13,   8), V(-12,   8), V(-11,   8), V(-10,   8), V(-9,   8), V(-8,   8), V(-7,   8), V(-6,   8), V(-5,   8), V(-4,   8), V(-3,   8), V(-2,   8), V(-1,   8), V(0,   8), V(1,   8), V(2,   8), V(3,   8), V(4,   8), V(5,   8), V(6,   8), V(7,   8), V(8,   8), V(9,   8), V(10,   8), V(11,   8), V(12,   8), V(13,   8), V(14,  8),

                                    V(-14,  9), V(-13,   9), V(-12,   9), V(-11,   9), V(-10,   9), V(-9,   9), V(-8,   9), V(-7,   9), V(-6,   9), V(-5,   9), V(-4,   9), V(-3,   9), V(-2,   9), V(-1,   9), V(0,   9), V(1,   9), V(2,   9), V(3,   9), V(4,   9), V(5,   9), V(6,   9), V(7,   9), V(8,   9), V(9,   9), V(10,   9), V(11,   9), V(12,   9), V(13,   9), V(14,  9),

                                                V(-13,  10), V(-12,  10), V(-11,  10), V(-10,  10), V(-9,  10), V(-8,  10), V(-7,  10), V(-6,  10), V(-5,  10), V(-4,  10), V(-3,  10), V(-2,  10), V(-1,  10), V(0,  10), V(1,  10), V(2,  10), V(3,  10), V(4,  10), V(5,  10), V(6,  10), V(7,  10), V(8,  10), V(9,  10), V(10,  10), V(11,  10), V(12,  10), V(13,  10),

                                                             V(-12,  11), V(-11,  11), V(-10,  11), V(-9,  11), V(-8,  11), V(-7,  11), V(-6,  11), V(-5,  11), V(-4,  11), V(-3,  11), V(-2,  11), V(-1,  11), V(0,  11), V(1,  11), V(2,  11), V(3,  11), V(4,  11), V(5,  11), V(6,  11), V(7,  11), V(8,  11), V(9,  11), V(10,  11), V(11,  11), V(12,  11),

                                                             V(-12,  12), V(-11,  12), V(-10,  12), V(-9,  12), V(-8,  12), V(-7,  12), V(-6,  12), V(-5,  12), V(-4,  12), V(-3,  12), V(-2,  12), V(-1,  12), V(0,  12), V(1,  12), V(2,  12), V(3,  12), V(4,  12), V(5,  12), V(6,  12), V(7,  12), V(8,  12), V(9,  12), V(10,  12), V(11,  12), V(12,  12),

                                                                                       V(-10,  13), V(-9,  13), V(-8,  13), V(-7,  13), V(-6,  13), V(-5,  13), V(-4,  13), V(-3,  13), V(-2,  13), V(-1,  13), V(0,  13), V(1,  13), V(2,  13), V(3,  13), V(4,  13), V(5,  13), V(6,  13), V(7,  13), V(8,  13), V(9,  13), V(10,  13),

                                                                                                    V(-9,  14), V(-8,  14), V(-7,  14), V(-6,  14), V(-5,  14), V(-4,  14), V(-3,  14), V(-2,  14), V(-1,  14), V(0,  14), V(1,  14), V(2,  14), V(3,  14), V(4,  14), V(5,  14), V(6,  14), V(7,  14), V(8,  14), V(9,  14), 

                                                                                                                            V(-7,  15), V(-6,  15), V(-5,  15), V(-4,  15), V(-3,  15), V(-2,  15), V(-1,  15), V(0,  15), V(1,  15), V(2,  15), V(3,  15), V(4,  15), V(5,  15), V(6,  15), V(7,  15),

                                                                                                                                                    V(-5,  16), V(-4,  16), V(-3,  16), V(-2,  16), V(-1,  16), V(0,  16), V(1,  16), V(2,  16), V(3,  16), V(4,  16), V(5,  16),
        };
    }
}
