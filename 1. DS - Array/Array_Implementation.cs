using System;

class MyArray
    {
        public int length;
        private Object[] data;

        public MyArray()
        {
            this.length = 0;
            this.data = new Object[1];
        }

        public Object get(int index)
        {
            return data[index];
        }

        public Object[] push(Object item)
        {
            if (this.data.Length == this.length)
            {
                Object[] temp = new Object[this.length];
                Array.Copy(this.data, temp, length);
                this.data = new Object[length + 1];
                Array.Copy(temp, this.data, length);
            }
            this.data[this.length] = item;
            this.length++;
            return this.data;
        }

        public Object pop()
        {
            Object poped = data[this.length - 1];
            this.data[this.length - 1] = null;
            this.length--;
            return poped;
        }

        public Object delete(int index)
        {
            Object itemToDelete = data[index];
            shiftItems(index);
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