using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearch
{
    public class Node<T> where T : IComparable<T>
    {
        private Node<T> Left;
        private Node<T> right;
        private T data;
        /**
         * Basic Constructer of i am just making a node 
         */
        public Node(T value)
        {
            data = value;
        }

        /**
         * Returns the left child of course
         */
        public Node<T> getLeft()
        {
            return Left;
        }
        /**
         * sets the left child of course
         */
        public Node<T> setLeft(Node<T> child)
        {
            Left = child;
            return Left;
        }
        /**
         * Returns the Right child of course
         */
        public Node<T> getRight()
        {
            return right;
        }

        /**
         * sets the right child of course
         */
         public Node<T> setRight(Node<T> child)
        {
            right = child;
            return right;
        }
        
        public T getdata()
        {
            return data;
        }

       
    }

    public class BinerySearch<T> where T : IComparable<T>
    {
        Node<T> Root;

        public Node<T> addChild(Node<T> child)
        {
            Node<T> temp = Root;

            if(Root == null)
            {
                Root = child;

            }

            /*
             *complicated stuff to making all this work  
             * 
             */
            while (true) { 
            if (temp.getdata().CompareTo(child.getdata())>0)
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
            else if (temp.getdata().CompareTo(child.getdata()) < 0)
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

        public Boolean addChild(T value)
        {
            Node<T> child = new Node<T>(value);
            child = addChild(child);

            if (child == null) return false;
            else return true;
        }

    }
}
