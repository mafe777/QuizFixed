namespace QuizArrays.logic
{
    public class OneDimension 
    {
        private int[] _array;
        private int _top;

        private bool IsFull => _top == N;
        private int IsEmpty => _array == 0;

        public OneDimension(int n)
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }

        public int N { get;}

        public void Add(int number)
        {
            if (IsFull)
            {
                throw new Exception("The array is full.");
            }

            _array[_top] = number;
            _top++;
        }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                output += $"{_array[i]}\t";
                output += "\n";
            }
            return output;
        }
    }

    public class TwoDimensions
    {
        private int[] _array;
        public int M { get; }
        public int N { get; }


        public void Fill(int min, int max)
        {
            var random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    _array[i, j] = random.Next(min, max);
                }
            }
        }
        public TwoDimensions(int n, int m)
        {
            N = n;
            M = m;
            _array = new int[N, M];
        }
        public ToOneDimension(int n)
        {
            N = n;
            M = n;
            _array = new int[N,M];
        }
        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    output += $"{_array[j]}\t";
                }
                output += "\n";
            }
            return output;
        }

    }
}