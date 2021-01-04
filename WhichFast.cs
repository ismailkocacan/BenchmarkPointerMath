using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WhichFast
{
    const int cCount = 100000;
    int[] anArray = new int[cCount];

    public WhichFast()
    {
        for (int i = 0; i < cCount; i++)
            anArray[i] = i;
    }



    [Benchmark]
    public void TestClassicFor()
    {
        int value;
        for (int i = 0; i < cCount; i++)
        {
            value = anArray[i];
        }
    }

    [Benchmark]
    public unsafe void TestClassicForEach()
    {
        foreach (int value in anArray)
        {

        }
    }

    [Benchmark]
    public unsafe void TestPointerMath()
    {
        int low = anArray.GetLowerBound(0);
        int high = anArray.GetUpperBound(0);
        fixed (int* pBegin = &anArray[low], pEnd = &anArray[high])
        {
            int* pCurrent = pBegin;
            while (pCurrent <= pEnd)
            {
                pCurrent++;
            }
        }
    }
}

