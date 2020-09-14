using System;

namespace Homework5
{
    class InvalidMatrixSizesException: ArgumentException
    {
        public int rows { get; private set; }
        public int columns { get; private set; }

        public InvalidMatrixSizesException(int rows, int columns): base($"Matrix sizes are invalid: {rows}x{columns}") 
        {
            this.rows = rows;
            this.columns = columns;
            throw new ArgumentException(base.Message);
        }

        public InvalidMatrixSizesException(int rows, int columns, string paramName) : base($"Matrix sizes are invalid: {rows}x{columns}", paramName)
        {
            this.rows = rows;
            this.columns = columns;
            throw new ArgumentException(base.Message);
        }

        public InvalidMatrixSizesException(int rows, int columns, string paramName, Exception ex) : base($"Matrix sizes are invalid: {rows}x{columns}", paramName, ex)
        {
            this.rows = rows;
            this.columns = columns;
            throw new ArgumentException(base.Message);
        }
    }
}
