"""
You are given two linked lists representing two non-negative numbers. 
The digits are stored in reverse order and each of their nodes contain a single digit. 
Add the two numbers and return it as a linked list.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8

Subscribe to see which companies asked this question

"""

# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution(object):
    def addTwoNumbers(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """

        l_return = None
        l_last = None
        carry = 0
        while l1 is not None or l2 is not None:
            sum_ = carry
            if l1 is not None:
                sum_ += l1.val
            if l2 is not None:
                sum_ += l2.val
            carry = int(sum_ / 10)
            if l_return is None:
                l_return = ListNode(sum_ % 10)
                l_last = l_return
            else:
                l_last.next = ListNode(sum_ % 10)
                l_last = l_last.next
            if l1 is not None:
                l1 = l1.next
            if l2 is not None:
                l2 = l2.next

        if carry == 1:
            l_last.next = ListNode(1)

        return l_return

s = Solution()

def test1():
    n1 = ListNode(2)
    n2 = ListNode(4)
    n3 = ListNode(3)
    n1.next = n2
    n2.next = n3

    n4 = ListNode(5)
    n5 = ListNode(6)
    n6 = ListNode(4)
    n4.next = n5
    n5.next = n6

    r1 = s.addTwoNumbers(n1, n4)
    r2 = r1.next
    r3 = r2.next
    print(r1.val)
    print(r2.val)
    print(r3.val)

def test2():
    n1 = ListNode(5)
    n2 = ListNode(5)
    r1 = s.addTwoNumbers(n1, n2)
    print(r1.val)
    r2 = r1.next
    print(r2.val)

if __name__ == "__main__":
    test2()