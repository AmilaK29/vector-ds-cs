namespace Vector{
    public class Vectore<T>{

        private int count = 0;
        private int capacity = 10;
        
        private T[] data = new T[10];

        public int Count { get { return count; } }

        // [1,2,3]
        // [0,1,2]
        public void Add(T element){
            if(count == capacity){
                ExtendData(capacity * 2);
            }

            
        }

        public RemoveAT(int index){

        }
    }
}