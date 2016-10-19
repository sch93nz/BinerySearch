using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearch
{
    public class Node
    {
        private Node Left;
        private Node right;
        private int data;
        /**
         * Basic Constructer of i am just making a node 
         */
        public Node(int value)
        {
            data = value;
        }

        /**
         * Returns the left child of course
         */
        public Node getLeft()
        {
            return Left;
        }
        /**
         * sets the left child of course
         */
        public Node setLeft(Node child)
        {
            Left = child;
            return Left;
        }
        /**
         * Returns the Right child of course
         */
        public Node getRight()
        {
            return right;
        }

        /**
         * sets the right child of course
         */
         public Node setRight(Node child)
        {
            right = child;
            return right;
        }
        
        public int getdata()
        {
            return data;
        }
    }

    public class BinerySearch
    {
        Node Root;

        public Node addChild(Node child)
        {
            Node temp = Root;

            if(Root == null)
            {
                Root = child;

            }
            /*
             *complicated stuff to making all this work  
             * 
             */
            while (true) { 
            if (temp.getdata() < child.getdata())
            {
                if (temp.getLeft() == null)
                {
                    return temp.setLeft(child);
                }
                    else
                {
                    temp = temp.getLeft();
                }
            }
            else if (temp.getdata() > child.getdata())
            {
                    if(temp.getRight()== null)
                    {
                        return temp.setRight(child);
                    }
                    else
                    {
                        temp = temp.getRight();
                    }
            }


        }
            
            
        }

        public Node addChild(int value)
        {
            Node child = new Node(value);
            return addChild(child);
        }

    }
}
