/*
* * Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements".
* It is not necessary to keep the tree balanced. Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() 
* and the operators for comparison  == and !=. Add and implement the ICloneable interface for deep copy of the tree. Remark: Use two types – 
* structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). 
* Implement IEnumerable<T> to traverse the tree.
*/

using System;

namespace BinarySearchTree
{
    public class BinarySearchTree<T>:ICloneable where T : IComparable<T>
    {
        #region Fields
        
        private BinaryTreeNode<T> root;
        
        #endregion
        
        #region Constructors
        
        public BinarySearchTree()
        {
            this.root = null;
        }
        
        #endregion
        
        #region Methods
        
        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Null items can not be inserted!");
            }
            this.root = Insert(value, null, root);
        }
        
        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareResult = value.CompareTo(node.value);
                if (compareResult < 0)
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else
                {
                    if (compareResult > 0)
                    {
                        node.rightChild = Insert(value, node, node.rightChild);
                    }
                }
            }
            return node;
        }
        
        private BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = this.root;
            while (node != null)
            {
                int compareResult = value.CompareTo(node.value);
                if (compareResult < 0)
                {
                    node = node.leftChild;
                }
                if (compareResult > 0)
                {
                    node = node.rightChild;
                }
                else
                {
                    break;
                }
            }
            return node;
        }
        
        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete == null)
            {
                return;
            }
            Remove(nodeToDelete);
        }
        
        private void Remove(BinaryTreeNode<T> node)
        {
            if (node.leftChild != null && node.rightChild != null)
            {
                BinaryTreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }
                node.value = replacement.value;
                node = replacement;
            }
            
            BinaryTreeNode<T> theChild = node.leftChild != null ? node.leftChild : node.rightChild;
            
            if (theChild != null)
            {
                theChild.parent = node.parent;
                if (node.parent == null)
                {
                    root = theChild;
                }
                else
                {
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = theChild;
                    }
                    else
                    {
                        node.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                if (node.parent == null)
                {
                    root = null;
                }
                else
                {
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = null;
                    }
                    else
                    {
                        node.parent.rightChild = null;
                    }
                }
            }
        }
        
        private void PrintDFS(BinaryTreeNode<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(spaces + root.value);
            PrintDFS(root.leftChild, spaces + "  ");
            PrintDFS(root.rightChild, spaces + "  ");
        }
        
        public void PrintDFS()
        {
            PrintDFS(this.root, string.Empty);
        }
    
        #endregion



        public BinarySearchTree<T> Clone()
        {
            BinarySearchTree<T> cloned = new BinarySearchTree<T>();
            cloned.root = new BinaryTreeNode<T>(this.root.value);
            
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
