public class MyCircularDeque {
    private int[] deque;
    private int k;
    private int front;
    private int rear;
    private int size;

    public MyCircularDeque(int k) {
        this.k = k;
        deque = new int[k];
        front = 0;
        rear = 0;
        size = 0;
    }
    
    public bool InsertFront(int value) {
        if (IsFull()) return false;
        front = (front - 1 + k) % k;
        deque[front] = value;
        size++;
        return true;
    }
    
    public bool InsertLast(int value) {
        if (IsFull()) return false;
        deque[rear] = value;
        rear = (rear + 1) % k;
        size++;
        return true;
    }
    
    public bool DeleteFront() {
        if (IsEmpty()) return false;
        front = (front + 1) % k;
        size--;
        return true;
    }
    
    public bool DeleteLast() {
        if (IsEmpty()) return false;
        rear = (rear - 1 + k) % k;
        size--;
        return true;
    }
    
    public int GetFront() {
        if (IsEmpty()) return -1;
        return deque[front];
    }
    
    public int GetRear() {
        if (IsEmpty()) return -1;
        return deque[(rear - 1 + k) % k];
    }
    
    public bool IsEmpty() {
        return size == 0;
    }
    
    public bool IsFull() {
        return size == k;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
