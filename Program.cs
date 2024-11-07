namespace Name
{
    class Neuron{ //item b
        private List<double> inputsList;
        private List<double> weightsList;
        private Random random;

        public Neuron(){
            inputsList=new List<double>(4);
            weightsList=new List<double>(4);
            random=new Random();

            for (int i = 0; i < 4; i++)
            {
                weightsList.add((random.NextDouble() * 2) - 1); //random double number between -1 and 1
            }
        }

        public void Control(List<double> inputValues){
            if (inpinputValuesuts.Length!=4)
            {
                throw new ArgumentException("Input count must be 4.");
            }
            inputsList = new List<double>(inputValues);
        }

        public double Calculate(){ //calculate neuron output
            double result=0.0;
            
            for (int i = 0; i < inputsList.Count; i++)
            {
                result += inputsList[i] * weightsList[i];
            }

            return result;
        }
    }
    
    class Program{
        
        //item a
        //create first character
        public static  List<int[,]> GenerateOnePattern(){
            List<int[,]> firstPatternsList= new List<int[][]>();
            int[,] firstPattern = {
                { 0, 0, 1, 0, 0 },
                { 0, 1, 1, 0, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 1, 0, 0 }
            };

            int[,] variation1={
                {0,0,1,0,0},
                {0,1,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {1,1,1,1,1}
            };

            int[,] variation2={
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {1,1,1,1,1}
            };

            int[,] variation3={
                {0,0,1,0,0},
                {0,1,1,0,0},
                {1,0,1,0,0},
                {0,0,1,0,0},
                {1,1,1,1,1}
            };

            int[,] variation4={
                {0,0,1,0,0},
                {0,1,1,0,0},
                {1,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0}
            };

            int[,] variation5={
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0}
            };

            int[,] variation6={
                {0,0,0,1,0},
                {0,0,1,1,0},
                {0,0,0,1,0},
                {0,0,0,1,0},
                {0,0,0,1,0}
            };

            int[,] variation7={
                {0,0,0,0,1},
                {0,0,0,1,1},
                {0,0,0,0,1},
                {0,0,0,0,1},
                {0,0,0,0,1}
            };

            int[,] variation8={
                {0,1,0,0,0},
                {1,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0}
            };

            int[,] variation9={
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0}
            };

            firstPatternsList.AddRange(new List<int[][]> {firstPattern,variation1,variation2,variation3,variation4,variation5,variation6,variation7,variation8,variation9});

            return firstPatternsList;
        }

        //create second character
        public static  List<int[,]> generateTwoPattern() {
            List<int[,]> secondPatternsList= new List<int[][]>();
            int[,] secondPattern = {
                { 0, 1, 1, 1, 0 },
                { 1, 0, 0, 0, 1 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 1, 1, 1, 1, 1 }
            };
            int[,] variation1 = {
                { 1, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 1 }
            };

            int[,] variation2 = {
                { 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 1 },
                { 0, 1, 1, 1, 0 },
                { 1, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1 }
            };

            int[,] variation3 = {
                { 0, 1, 1, 1, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 1, 1, 1, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 1, 1, 0 }
            };

            int[,] variation4 = {
                { 1 ,1 ,1 ,1 ,1 },
                { 0 ,0 ,0 ,1 ,1 },
                { 1 ,1 ,1 ,1 ,1 },
                { 1 ,1 ,0 ,0 ,0 },
                { 1 ,1 ,1 ,1 ,1 }
            };

            int[,] variation5 = {
                { 1 ,1 ,1 ,1 ,0},
                { 0 ,0 ,0 ,1 ,0},
                { 1 ,1 ,1 ,1 ,0},
                { 1 ,0 ,0 ,0 ,0},
                { 1 ,1 ,1 ,1 ,0}
            };

            int[,] variation6 = {
                { 0, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 1, 1, 1, 1, 1 }
            };

            int[,] variation7 = {
                { 0, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 1, 1, 1, 1 }
            };

            int[,] variation8 = {
                { 1, 1, 1, 0, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 1, 1, 1, 1, 0 }
            };

            int[,] variation9 = {
                { 0, 1 ,1 ,1 ,1},
                { 0, 0 ,0 ,0 ,1},
                { 0, 1 ,1 ,1 ,1},
                { 0, 1 ,0 ,0 ,0},
                { 0, 1 ,1 ,1 ,1}
            };

            secondPatternsList.AddRange(new List<int[][]> {secondPattern,variation1,variation2,variation3,variation4,variation5,variation6,variation7,variation8,variation9});

            return secondPatternsList;
        }

        static void Main(string[] args){
            Neuron neuron = new Neuron();
            neuron.Control(new List<double> { 0.5, 0.8, 0.2, 0.1 });
            double result = neuron.Calculate();

        }
    }

}