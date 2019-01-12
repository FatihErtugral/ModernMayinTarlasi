using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp
{
    public class MatrisField2D
    {
        Random rand = new Random();


        private ushort width2D_Arr;
        private ushort height2D_Arr;
        private ushort mine;
        public  int[,] _2DArray;


        public MatrisField2D(ushort width, ushort height, ushort mine)
        {
            this.width2D_Arr    = width;
            this.height2D_Arr   = height;
            this.mine           = mine;

            set2DArray();
            MatrixSetRandMine(this.mine);
        }

        public void set2DArray()
        {
            this._2DArray = new int[this.width2D_Arr, this.height2D_Arr];
        }
        public int[,] get2DArray()
        {
            
            return this._2DArray;
        }
        
        public void MatrixSetRandMine(ushort mineNum) // Matrisin içine rastgele indislere 9 değeri yazılıyor, 9 => mayınlı indisi temsil ediyor.
        {
            int randWidth;
            int randHeight;

            while (mineNum != 0)
            {
                randWidth   = rand.Next(this.width2D_Arr);
                randHeight  = rand.Next(this.height2D_Arr);
                if (this._2DArray[randWidth, randHeight] != 9)
                {
                    this._2DArray[randWidth, randHeight] = 9;
                    MineCount(randWidth, randHeight);
                    mineNum--;
                }

            }
        }
        // 9 mayınları, 0 boş alanları, diğer rakamlar mayın çevresini temsil ediyor
        // matris içindeki mayınların çevresindeki indis değerlerini bir attırıyor. 1,1 indiste mayın varsayılarak aşağıda kordinatlar yorum satırı olarak verilmiştir.

        public void MineCount(int width, int height) 
        {
            if (width - 1   >= 0    && this._2DArray[width - 1, height] != 9) // 0,1
                this._2DArray[width - 1, height]++;

            if (height - 1  >= 0    && this._2DArray[width, height - 1] != 9) // 1,0
                this._2DArray[width, height - 1]++;

            if (width + 1   < this.width2D_Arr      && this._2DArray[width + 1, height] != 9) // 2,1
                this._2DArray[width + 1, height]++;

            if (height + 1  < this.height2D_Arr     && this._2DArray[width, height + 1] != 9) // 1,2
                this._2DArray[width, height + 1]++;

            if (width - 1   >= 0    && height + 1 < this.height2D_Arr   && this._2DArray[width - 1, height+1] != 9) // 0,2
                this._2DArray[width - 1, height + 1]++;

            if (height - 1  >= 0    && width + 1 < this.width2D_Arr     && this._2DArray[width + 1, height - 1] != 9) // 2,0
                this._2DArray[width + 1, height - 1]++;

            if (width - 1   >= 0    && height - 1 >= 0      && this._2DArray[width - 1, height - 1] != 9) // 0,0
                this._2DArray[width - 1, height - 1]++;

            if (width + 1   < this.width2D_Arr      && height + 1 < this.height2D_Arr   && this._2DArray[width + 1, height + 1] != 9) // 2,2
                this._2DArray[width + 1, height + 1]++;
        }
    }
}
