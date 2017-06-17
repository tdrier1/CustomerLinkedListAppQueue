using System;

namespace CustomerLinkedListApp
{
    class Node
    {
        public Customer info;
        public Node handle;
        public Node (Customer data)
        {
            info = data;
            handle = null;
        }

    }
    
}