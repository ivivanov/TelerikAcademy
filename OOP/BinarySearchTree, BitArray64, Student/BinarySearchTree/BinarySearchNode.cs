using System;

namespace BinarySearchTree
{
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>>, ICloneable where T : IComparable<T>
    {
        #region Fields

        internal T value;
        internal BinaryTreeNode<T> parent;
        internal BinaryTreeNode<T> leftChild;
        internal BinaryTreeNode<T> rightChild;

        #endregion

        #region Constructors

        public BinaryTreeNode(T value)
        {
            this.value = value;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return value.ToString();
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = obj as BinaryTreeNode<T>;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }

        public static bool operator ==(BinaryTreeNode<T> a, BinaryTreeNode<T> b)
        {
            return BinaryTreeNode<T>.Equals(a, b);
        }

        public static bool operator !=(BinaryTreeNode<T> a, BinaryTreeNode<T> b)
        {
            return !BinaryTreeNode<T>.Equals(a, b);
        }

        public BinaryTreeNode<T> Clone()
        {
            BinaryTreeNode<T> clone = new BinaryTreeNode<T>(this.value);
            //clone.parent = this.parent.Clone();
            clone.parent = new BinaryTreeNode<T>(this.parent.value);
            clone.leftChild = new BinaryTreeNode<T>(this.leftChild.value);
            clone.rightChild = new BinaryTreeNode<T>(this.rightChild.value);
            return clone;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        #endregion
    }
}
