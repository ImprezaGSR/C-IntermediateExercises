namespace Stack
{
    class Stack
    {
        private List<object> objects = new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                objects.Insert(0, obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Pop() { 
            object tempObj;
            if(objects.Count != 0)
            {
                tempObj = objects[0];
                objects.RemoveAt(0);
                return tempObj;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Clear()
        {
            objects.Clear();
        }
    }
}
