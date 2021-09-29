using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = new ListNode();
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            int i = 0;
            ListNode toReturn = Head;
            while (i <= index && toReturn.next != null)
            {
                toReturn = toReturn.next;
                i++;
            }
            if (i < index && toReturn == null)
            {
                return -1;
            }
            return toReturn.val;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode addAtHead = new ListNode(val);
            addAtHead.next = Head;
            Head = addAtHead;
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            //ListNode tail = new ListNode(val, null);
            //Tail.next = tail;
            //tail 

            ListNode tracker = Head;
            while (tracker.next != null)
            {
                tracker = tracker.next;
            }
            ListNode addAtTail = new ListNode(val);
            tracker.next = addAtTail;
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            ListNode cur = new ListNode(val);
            ListNode tracker = Head;
            int i = 0;
            while (tracker.next != null && i < index)
            {
                tracker = tracker.next;
                i++;
            }
            if (i == index && tracker.next != null)
            {
                cur.next = tracker.next;
                tracker.next = cur;
            }
            else if (tracker.next == null && i == index)
            {
                tracker.next = cur;
            }

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            ListNode walkerFront = Head;
            ListNode walkerBack = null;
            int i = 0;
            while (walkerFront.next != null && i < index)
            {
                walkerBack = walkerFront;
                walkerFront = walkerFront.next;
                i++;
            }
            if (i == index && walkerFront.next != null)//end of list
            {
                walkerBack.next = null;
            }
            else if (walkerFront.next == null && i == index)//in list
            {
                walkerBack.next = walkerFront.next;
            }

        }
    }
}
