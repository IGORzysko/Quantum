using System.Numerics;

namespace QuantumMath.Application.Vector
{
    public struct QuantumVector
    {
        public float Alpha { get; private set; }
        public float Beta { get; private set; }

        public Vector2 Zero { get; private set; }
        public Vector2 One { get; private set; }

        public Vector2 Result { get; private set; }

        public QuantumVector(float alpha, float beta)
        {
            this.Alpha = alpha;
            this.Beta = beta;

            this.Zero = new Vector2(1, 0);
            this.One = new Vector2(0, 1);

            this.Result = Vector2.Add(
                Vector2.Multiply(this.Alpha, this.Zero),
                Vector2.Multiply(this.Beta, this.One)
            );
        }
    }
}