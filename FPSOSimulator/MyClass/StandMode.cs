using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSOSimulator.MyClass
{
    class StandMode
    {

        public double[,] VR = new double[2000, 12];
        public double[,] V = new double[100, 3];
        public double[,] VT = new double[10, 3];
        public double[] VARI = new double[32];

        public Int32 RowFuelRack = 0;
        public Int32 Nmax = 0;

        public Single[] AverSqut = new Single[10];
        public Single[] AverMax = new Single[10];
        public Single[] AverMin = new Single[10];

        //        Public VR(1 To 2000, 1 To 12) As Single '原始建模数据
        //Public V(1 To 100, 1 To 3) As Single '柴油机标准模型
        //Public VT(1 To 10, 1 To 3) As Single '增压器标准模型
        //Public VARI(1 To 32) As Single '

        //        Dim RowFuelRack As Integer, Nmax As Integer
        //Dim AverSqut(1 To 10) As Single, AverMax(1 To 10) As Single, AverMin(1 To 10) As Single
        //Dim I, J, K As Integer, AverLength As Integer, AverNum As Integer
        //Dim Squt As Single, Max As Single, Min As Single, Averg As Single, AverNumber As Integer
        //Dim D1 As Single, D2 As Single, D3 As Single, D4 As Single
        //Dim K1 As Integer, K2 As Integer, K3 As Integer, K4 As Integer
        //Public MESpeedShow As Single
        //Public FuelRackShow As Single



        ////////'柴油机标准模型

        //    Open MyPath + "Vr.txt" For Input As #1

        //For I = 1 To 1100
        //    For J = 1 To 12
        //        Input #1, VR(I, J)
        //    Next J
        //Next I

        //Close #1
        //Nmax = VR(1, 2)  '最高转速

        public void EngineStandMode()
        {
            //柴油机标准模型
            //int i = 0;
            //int j = 0;
            int K = 0;
            double D1 = 0;
            int K1 = 1;
            double D2 = 0;
            int K2 = 1;
            double D3 = 0;
            int K3 = 1;
            double D4 = 0;
            int K4 = 1;
            for (int I = 1; I < 10; I++)
            {

                for (int J = 0; J < 10; J++)
                {
                    //?? Nmax 最高转速 额定转速 or 遍历转速求最大值
                    V[10 * (I - 1) + J, 1] = I * 0.1 * Nmax;
                    V[10 * (I - 1) + J, 2] = J * 0.1;
                    D1 = System.Math.Sqrt((VR[1, 3] - V[10 * (I - 1) + J, 1]) * (VR[1, 3] - V[10 * (I - 1) + J, 1]) + (VR[1, 4] - V[10 * (I - 1) + J, 2]) * (VR[1, 4] - V[10 * (I - 1) + J, 2]));

                    for (K = 2; K < 1100; K++)
                    {
                        if (System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D1)
                        {
                            D1 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 3]) * (VR[K, 3] - V[10 * (I - 1) + J, 2]));
                            K1 = K;
                        }


                    }

                    if (K1 != 1)
                    {
                        D2 = System.Math.Sqrt((VR[1, 3] - V[10 * (I - 1) + J, 1]) * (VR[1, 3] - V[10 * (I - 1) + J, 1]) + (VR[1, 4] - V[10 * (I - 1) + J, 2]) * (VR[1, 4] - V[10 * (I - 1) + J, 2]));
                        K2 = 1;
                        for (K = 2; K < 1100; K++)
                        {
                            if (K != K1 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D2)
                            {
                                D2 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K2 = K;

                            }

                        }

                    }
                    else
                    {
                        D2 = System.Math.Sqrt((VR[2, 3] - V[10 * (I - 1) + J, 1]) * (VR[2, 3] - V[10 * (I - 1) + J, 1]) + (VR[2, 4] - V[10 * (I - 1) + J, 2]) * (VR[2, 4] - V[10 * (I - 1) + J, 2]));
                        K2 = 2;

                        for (K = 2; K < 1100; K++)
                        {

                            if (K != K1 && (System.Math.Sqrt((VR[K, 3]) - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D2)
                            {
                                D2 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K2 = K;
                            }
                        }
                    }

                    if (K1 != 1 && K2 != 1)
                    {
                        D3 = System.Math.Sqrt((VR[1, 3] - V[10 * (I - 1) + J, 1]) * (VR[1, 3] - V[10 * (I - 1) + J, 1]) + (VR[1, 4] - V[10 * (I - 1) + J, 2]) * (VR[1, 4] - V[10 * (I - 1) + J, 2]));

                        K3 = 1;

                        for (K = 2; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D3)
                            {
                                D3 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K3 = K;
                            }

                        }
                    }
                    else if ((K1 != 2 && K2 != 2))
                    {
                        D3 = System.Math.Sqrt((VR[2, 3] - V[10 * (I - 1) + J, 1]) * (VR[2, 3] - V[10 * (I - 1) + J, 1]) + (VR[2, 4] - V[10 * (I - 1) + J, 2]) * (VR[2, 4] - V[10 * (I - 1) + J, 2]));

                        K3 = 2;
                        for (K = 3; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D3)
                            {
                                D3 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K3 = K;
                            }

                        }

                    }
                    else
                    {
                        D3 = System.Math.Sqrt((VR[3, 3] - V[10 * (I - 1) + J, 1]) * (VR[3, 3] - V[10 * (I - 1) + J, 1]) + (VR[3, 4] - V[10 * (I - 1) + J, 2]) * (VR[3, 4] - V[10 * (I - 1) + J, 2]));
                        K3 = 3;
                        for (K = 4; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && System.Math.Sqrt((VR[K, 1] - V[10 * (I - 1) + J, 1]) * (VR[K, 1] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 3]) * (VR[K, 4] - V[10 * (I - 1) + J, 3])) < D3)
                            {
                                D3 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K3 = K;
                            }
                        }

                    }


                    if (K1 != 1 && K2 != 1 && K3 != 1)
                    {

                        D4 = System.Math.Sqrt((VR[1, 3] - V[10 * (I - 1) + J, 1]) * (VR[1, 3] - V[10 * (I - 1) + J, 1]) + (VR[1, 4] - V[10 * (I - 1) + J, 2]) * (VR[1, 4] - V[10 * (I - 1) + J, 2]));

                        K4 = 1;
                        for (K = 2; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && K != K3 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D4)
                            {
                                D4 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K4 = K;
                            }

                        }
                    }
                    else if (K1 != 2 && K2 != 2 && K3 != 2)
                    {
                        D4 = System.Math.Sqrt((VR[2, 3] - V[10 * (I - 1) + J, 1]) * (VR[2, 3] - V[10 * (I - 1) + J, 1]) + (VR[2, 4] - V[10 * (I - 1) + J, 2]) * (VR[2, 4] - V[10 * (I - 1) + J, 2]));

                        K4 = 2;

                        for (K = 2; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && K != K3 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D4)
                            {
                                D4 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K4 = K;
                            }

                        }


                    }
                    else if (K1 != 3 && K2 != 3 && K3 != 3)
                    {

                        D4 = System.Math.Sqrt((VR[3, 3] - V[10 * (I - 1) + J, 1]) * (VR[3, 3] - V[10 * (I - 1) + J, 1]) + (VR[3, 4] - V[10 * (I - 1) + J, 2]) * (VR[3, 4] - V[10 * (I - 1) + J, 2]));

                        K4 = 3;

                        for (K = 4; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && K != K3 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D4)
                            {
                                D4 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K4 = K;
                            }

                        }

                    }
                    else
                    {

                        D4 = System.Math.Sqrt((VR[4, 3] - V[10 * (I - 1) + J, 1]) * (VR[4, 3] - V[10 * (I - 1) + J, 1]) + (VR[4, 4] - V[10 * (I - 1) + J, 2]) * (VR[4, 4] - V[10 * (I - 1) + J, 2]));
                        K4 = 4;

                        for (K = 5; K < 1100; K++)
                        {
                            if (K != K1 && K != K2 && K != K3 && System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2])) < D4)
                            {
                                D4 = System.Math.Sqrt((VR[K, 3] - V[10 * (I - 1) + J, 1]) * (VR[K, 3] - V[10 * (I - 1) + J, 1]) + (VR[K, 4] - V[10 * (I - 1) + J, 2]) * (VR[K, 4] - V[10 * (I - 1) + J, 2]));
                                K4 = K;
                            }

                        }



                    }

                    V[10 * (I - 1) + J, 3] = ((D2 + D3 + D4) / (D1 + D2 + D3 + D4) * VR[K1, 5] + (D1 + D3 + D4) / (D1 + D2 + D3 + D4) * VR[K2, 5] + (D1 + D2 + D4) / (D1 + D2 + D3 + D4) * VR[K3, 5] + (D1 + D2 + D3) / (D1 + D2 + D3 + D4) * VR[K4, 5]) / 3;

                }

            }

        }

        public void TurbochargerStandMode()
        {
            //增压器标准模型
            //?? Nmax 最高转速 额定转速 or 遍历转速求最大值
            //        ' 打开原始建模数据文件
            //Open MyPath +"Vr.txt" For Input As #1

            //For I = 1 To 1100
            //    For J = 1 To 12
            //        Input #1, VR(I, J)
            //    Next J
            //Next I

            //Close #1
            //柴油机标准模型
            //int i = 0;
            //int j = 0;
            int K = 0;
            double D1 = 0;
            int K1 = 1;
            double D2 = 0;
            int K2 = 1;
            //double D3 = 0;
            //int K3 = 1;
            //double D4 = 0;
            //int K4 = 1;
            double Nmax = VR[1, 2];  //'最高转速

            for (int I = 1; I < 10; I++)
            {
                VT[I, 1] = I * 0.1 * Nmax;
                D1 = System.Math.Abs(VR[1, 3] - VT[I, 1]);
                K1 = 1;
                for (K = 2; K < 110; K++)
                {
                    if (System.Math.Abs(VR[K, 3] - VT[I, 1]) < D1)
                    {
                        D1 = System.Math.Abs(VR[K, 3] - VT[I, 1]);
                        K1 = K;
                    }

                }

                if (K1 != 1)
                {
                    D2 = System.Math.Abs(VR[1, 3] - VT[I, 1]);
                    K2 = 1;

                    for (K = 2; K < 110; K++)
                    {
                        if (K != K1 && System.Math.Abs(VR[K, 3] - VT[I, 1]) < D2)
                        {

                            D2 = System.Math.Abs(VR[K, 3] - VT[I, 1]);
                            K2 = K;
                        }

                    }



                }
                else
                {
                    D2 = System.Math.Abs(VR[2, 3] - VT[I, 1]);
                    K2 = 2;
                    for (K = 3; K < 110; K++)
                    {
                        if (K != K1 && System.Math.Abs(VR[K, 3] - VT[I, 1]) < D2)
                        {
                            D2 = System.Math.Abs(VR[K, 3] - VT[I, 1]);
                            K2 = K;
                        }

                    }
                }
                VT[I, 2] = D2 / (D1 + D2) * VR[K1, 5] + D1 / (D1 + D2) * VR[K2, 5];

            }

        }


    }
}
