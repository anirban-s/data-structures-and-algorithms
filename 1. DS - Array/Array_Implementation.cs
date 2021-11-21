using System;

class MyArray
    {
        public int length;
        private Object[] data;
        //creating constructors
        public MyArray()
        {
            this.length = 0;
            this.data = new Object[1];
        }

        public Object get(int index)
        {
            return data[index];
        }
    
        //pushing items at last index
        public Object[] push(Object item)
        {
            if (this.data.Length == this.length)
            {
                Object[] temp = new Object[this.length]; // creates a temp array 
                Array.Copy(this.data, temp, length); //copies all data to temp array     
                this.data = new Object[length + 1]; //increases size of temp array
                Array.Copy(temp, this.data, length);
            }
            this.data[this.length] = item;  //inserts item into last index
            this.length++; 
            return this.data;
        }

        public Object pop()
        {
            Object poped = data[this.length - 1];
            this.data[this.length - 1] = null;  //nulling out the last item
            this.length--; //decresing the length by 1 index            
            return poped; //returning the poped array
        }

        public Object delete(int index)
        {
            Object itemToDelete = data[index];
            shiftItems(index); //calling the shiftItems method to shift the items at index
            return itemToDelete;
        }

        private void shiftItems(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[length - 1] = null;
            length--;
        }

        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();

            myArray.push("Hello");
            myArray.push("World");
            myArray.push("!");

            //for (int i = 0; i < myArray.length; i++)
            //{
            //    Console.WriteLine(myArray.get(i));
            //}

            //myArray.pop();

            myArray.delete(1);

            for (int i = 0; i < myArray.length; i++)
            {
                Console.WriteLine(myArray.get(i));
            }
        }
    }
