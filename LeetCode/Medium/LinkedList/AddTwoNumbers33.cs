namespace LeetCode.Medium.LinkedList;

public class AddTwoNumbers33
{
    public class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // Перенос (то, что "в уме")
        var carry = 0;
        
        // Фиктивная голова результирующего списка
        var dummy = new ListNode();
        var current = dummy;
        
        // Пока есть цифры в списках или есть перенос
        while (l1 != null || l2 != null || carry != 0)
        {
            // Берём цифры или 0, если список закончился
            var x = l1?.val ?? 0;
            var y = l2?.val ?? 0;
            
            // Складываем
            var total = x + y + carry;
            
            // Создаём узел с цифрой результата
            current.next = new ListNode(total % 10);

            // Обновляем перенос
            carry = total / 10;
            
            // Сдвигаем указатель результата
            current = current.next;
            
            // Переходим к следующим узлам
            l1 = l1?.next;
            l2 = l2?.next;
        }
        
        // Возвращаем голову нового списка
        return dummy.next;
    }
}