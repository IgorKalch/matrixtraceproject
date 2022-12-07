using System;

namespace MatrixTraceLibrary
{
    public class Matrix
    {
        public int Rows { get; private  set; }        
        public int Columns { get; private set; }

        private int[,] _value { get;  set; }
        public int this[int rows, int columns]
        {
            get => _value[rows, columns];
            set => _value[rows, columns] = value;
        }

        public Matrix( int[,] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }
            Rows = ValidateDimension(data.GetLength(0));
            Columns = ValidateDimension(data.GetLength(1));
            
            _value = (int[,])data.Clone();
        }

        public Matrix(int rows , int columns )
        {
            Rows = ValidateDimension(rows);
            Columns = ValidateDimension(columns);
            
            _value = new int[Rows, Columns];            
        }

        private int ValidateDimension(int dimention) 
        {
            if (dimention <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return dimention;
        }
    }
}
