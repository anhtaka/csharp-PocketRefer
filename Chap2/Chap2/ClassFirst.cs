using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    public class ClassFirst
    {
        // フィールド
        float x;
        float y;
        float area;

        // メソッド
        float GetArea(float height, float bottom)
        {
            return height * bottom / 2;
        }

        void GetArea2(float height, float bottom)
        {
            this.area = height * bottom / 2;
        }
    }
}
