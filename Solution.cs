/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var outputStartNode = new ListNode();
        ListNode currNode = outputStartNode;
        do {
            if (l1 != null) {
                currNode.val += l1.val;
                l1 = l1.next;
            }
            if (l2 != null) {
                currNode.val += l2.val;
                l2 = l2.next;
            }

            if (currNode.val > 9) {
                var remainder = currNode.val % 10;
                currNode.val = remainder;
                if (currNode.next == null)
                    currNode.next = new ListNode();
                currNode.next.val++;
            } else if (l1 != null || l2 != null) {
                currNode.next = new ListNode();
            }
            currNode = currNode.next;
        } while (currNode != null);
        return outputStartNode;
    }
}
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}