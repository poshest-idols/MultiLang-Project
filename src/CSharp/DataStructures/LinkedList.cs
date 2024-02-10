using System;
namespace MultiLangProject.DataStructures {
  public class LinkedList<T> {
    private class Node {
      public T Value;
      public Node Next;
      public Node(T value) { Value = value; }
    }
    private Node head;
    public void Add(T value) {
      if (head == null) head = new Node(value);
      else {
        Node current = head;
        while (current.Next != null) current = current.Next;
        current.Next = new Node(value);
      }
    }
  }
}
