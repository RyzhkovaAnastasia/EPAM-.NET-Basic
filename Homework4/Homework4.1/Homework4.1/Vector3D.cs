namespace Homework4_1
{
    public class Vector3D
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        public double X
        {
            get {
                return _x;
            }
        }
        public double Y
        {
            get {
                return _y;
            }
        }
        public double Z
        {
            get {
                return _z;
            }
        }

        public Vector3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        /// <summary>
        /// Addition of two 3D Vectors
        /// </summary>
        /// <param name="vector1">Vector 1</param>
        /// <param name="vector2">Vector 2</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator+ (Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.X + vector2.X,
                                vector1.Y + vector2.Y,
                                vector1.Z+ vector2.Z);
        }

        /// <summary>
        /// Additional of 3D Vector to a number
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="term">number</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator+ (Vector3D vector, double term)
        {
            return new Vector3D(vector.X + term,
                              vector.Y + term,
                              vector.Z + term);
        }
        public static Vector3D operator +(double term, Vector3D vector)
        {
            return vector + term;
        }

        /// <summary>
        /// Substraction of two 3D Vectors
        /// </summary>
        /// <param name="vector1">Vector 1</param>
        /// <param name="vector2">Vector 2</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator- (Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.X - vector2.X,
                                vector1.Y - vector2.Y,
                                vector1.Z - vector2.Z);
        }
        /// <summary>
        /// Substraction a 3D vector with a number
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="term">number</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator- (Vector3D vector, double term)
        {
            return new Vector3D(vector.X - term,
                              vector.Y - term,
                              vector.Z - term);
        }
   
        /// <summary>
        /// Scalar multiplication of two 3D Vectors
        /// </summary>
        /// <param name="vector1">Vector 1</param>
        /// <param name="vector2">Vector 2</param>
        /// <returns>double value of projection length </returns>
        public static double operator* (Vector3D vector1, Vector3D vector2)
        {
            return (vector1.X * vector2.X +
                    vector1.Y * vector2.Y +
                    vector1.Z * vector2.Z);
        }
        /// <summary>
        /// Multiplication of 3D Vector by a number
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="multiplier">number</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator *(Vector3D vector, double multiplier)
        {
            return new Vector3D(vector.X * multiplier,
                                vector.Y * multiplier,
                                vector.Z * multiplier);
        }
        public static Vector3D operator *(double multiplier, Vector3D vector)
        {
            return vector * multiplier;
        }

        /// <summary>
        /// Cross multiplication of 3D Vector
        /// </summary>
        /// <param name="vector1">Vector 1</param>
        /// <param name="vector2">Vector 2</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator% (Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.Y * vector2.Z - vector1.Z * vector2.Y,
                                vector1.Z * vector2.X - vector1.X * vector2.Z,
                                vector1.X * vector2.Y - vector1.Y * vector2.X);
        }

        /// <summary>
        /// Devision a 3D vector by a number
        /// </summary>
        /// <param name="vector">Vector</param>
        /// <param name="term">number</param>
        /// <returns>Vector3D value</returns>
        public static Vector3D operator /(Vector3D vector, double term)
        {
            return new Vector3D(vector.X / term,
                              vector.Y / term,
                              vector.Z / term);
        }

        public override string ToString()
        {
            return $"x: {this.X}, y: {this.Y}, z: {this.Z}";
        }
    }
}
