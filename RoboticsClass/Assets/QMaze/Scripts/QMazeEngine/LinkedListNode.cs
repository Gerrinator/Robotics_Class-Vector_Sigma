using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace qtools.qmaze
{



    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
