namespace DefiningClassesPart2
{
    using System;

    public class Matrix<T>
        where T : IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            matrix = new T[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rows cannot be less than 0!");
                }
                else
                {
                    this.rows = value;
                }
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cols cannot be less than 0!");
                }
                else
                {
                    this.cols = value;
                }
            }
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
           firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("The two matrixes must have same dimensions !");
            }

            Matrix<T> matrixRes = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    matrixRes[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                }
            }
            return matrixRes;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
           firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("The two matrixes must have same dimensions !");
            }

            Matrix<T> matrixRes = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    matrixRes[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                }
            }
            return matrixRes;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.matrix.GetLength(1) != matrixTwo.matrix.GetLength(0))
            {
                throw new ArgumentException("The two matrices must have same dimensions !");
            }

            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixTwo.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    for (int i = 0; i < matrixOne.matrix.GetLength(1); i++)
                    {
                        result[row, col] += (dynamic)matrixOne[row, i] * (dynamic)matrixTwo[i, col];
                    }
                }
            }
            return result;
        }
    }
}
