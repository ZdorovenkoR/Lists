using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBraintests
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    public interface ILinkedList
    {
        int GetCount();
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента

        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент

        Node findNode(int searchValue); // ищет элемент по его значению

    }
    public class LinkedList : ILinkedList
    {
        private int _count = 0;
        private Node _startNode;
        private Node _endNode;
        public void AddNode(int value)
        {
            if (_startNode == null)
            {
                _startNode = new Node { Value = value };
                _endNode = _startNode;
            }
            _count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var nextItem = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextItem;
        }

        public Node findNode(int searchValue)
        {
            {
                var currentNode = _startNode;

                while (currentNode != null)
                {
                    if (currentNode.Value == value)
                        return currentNode;

                    currentNode = currentNode.NextNode;
                }

                return null;
            }

        }

        public int getCount()
        {
            return _count;
        }

        public void RemoveNode(int index)
        {
            
            if (index == 0)
            {
                var newStartNode = _startNode.NextNode;
                _startNode.NextNode = null;
                return;
            }

            int currentIndex = 0;
            var currentNode = _startNode;
            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    RemoveNode(currentNode);
                    return;
                }

                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return;
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
